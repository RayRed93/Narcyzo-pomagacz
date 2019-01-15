using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using IronOcr;

using IronOcr.Languages;

using System.Windows.Shell;
using System.Diagnostics;
using IronOcr;

namespace Narcyzo_pomagacz
{
    public partial class MainForm : Form
    {
        private OpenFileDialog pdfOpenDialog;
        private FolderBrowserDialog folderDialog;
        private delegate void PdfProcessCompleted(PdfExtraction pdfExtraction);

        private PdfExtraction pdfExtResult;

        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            InitializeComponent();
            pdfOpenDialog = new OpenFileDialog();
            folderDialog = new FolderBrowserDialog();
           


        }



        private void ProcessPDF(string path, PdfProcessCompleted completedCallback)
        {
            List<ExtractionRecord> extractionStruct = new List<ExtractionRecord>();
            AutoOcr pdfOcr = new AutoOcr();
            pdfOcr.Language = IronOcr.Languages.Polish.OcrLanguagePack;
            pdfOcr.ReadBarCodes = false;
            OcrResult ocrRes = pdfOcr.ReadPdf(path);

            //AspriseOCR.SetUp();
            //AspriseOCR ocr = new AspriseOCR();
            //string lann = AspriseOCR.ListSupportedLangs();
            //ocr.StartEngine("eng", AspriseOCR.SPEED_FASTEST);
            //string ocrResultText = ocr.Recognize(path, -1, -1, -1, -1, -1, AspriseOCR.RECOGNIZE_TYPE_TEXT, AspriseOCR.OUTPUT_FORMAT_PLAINTEXT);
            //ocr.StopEngine();

            string ocrString = ocrRes.Text;

            string[] pdfLines = ocrString.Split(new char[] { '\r', '\n' });
            string date = pdfLines.Where(s => s.Contains("Dnia")).First().Replace("Dnia ", "");
            string targetName = pdfLines.Where(s => s.Contains("Korespondent")).First().Replace("Korespondent", "").Trim();
            string[] bill = pdfLines.Where(x => x.Contains("BILANS")).ToArray();

            foreach (var line in bill)
            {
                var splitedLine = line.Split(new char[] { ' ' }, 3, StringSplitOptions.RemoveEmptyEntries);
                short id = short.Parse(splitedLine[0]);
                int krs = Int32.Parse(splitedLine[1]);
                string name = splitedLine[2].Substring(0, splitedLine[2].IndexOf("BILANS")).Trim();
                var years = splitedLine[2].Substring(splitedLine[2].LastIndexOf("BILANS") + "BILANS".Length).Trim().Split(';').Where(year => year.Length > 0).Select(s => Int32.Parse(s)).ToList();
                var extraction = new ExtractionRecord(id, name, krs, years);
                extractionStruct.Add(extraction);
            }

            PdfExtraction pdfExtract = new PdfExtraction(extractionStruct, date, targetName);
            completedCallback.Invoke(pdfExtract);
        }


        private void ProcessData(PdfExtraction pdfResult)
        {
            pdfExtResult = pdfResult;
            if (this.dataGridView.InvokeRequired)
            {
                this.dataGridView.Invoke(new MethodInvoker(delegate () {
                    pdfResult.extractionList.ForEach(element => dataGridView.Rows.Add(element.id, element.name, element.KRS, element.GetYearsString()));
                    toolStripProgressBar.Style = ProgressBarStyle.Continuous;
                    toolStripProgressBar.MarqueeAnimationSpeed = 0;
                    toolStripProgressBar.Value = toolStripProgressBar.Maximum;
                    toolStripStatusLabel_Date.Text = string.Format("Data: {0}", pdfResult.date);
                    toolStripStatusLabel_Bilanse.Text = string.Format("Bilanse: {0}", pdfResult.extractionList.Count());
                    toolStripStatusLabel_Name.Text = string.Format("Korespondent: {0}", pdfResult.targetName);

                }));
            }
            else
            {
                pdfResult.extractionList.ForEach(element => dataGridView.Rows.Add(element.id, element.name, element.KRS, element.GetYearsString()));
                toolStripProgressBar.Style = ProgressBarStyle.Continuous;
                toolStripProgressBar.MarqueeAnimationSpeed = 0;
                toolStripProgressBar.Value = toolStripProgressBar.Maximum;
                toolStripStatusLabel_Date.Text = string.Format("Data: {0}", pdfResult.date);
                toolStripStatusLabel_Bilanse.Text = string.Format("Bilanse: {0}", pdfResult.extractionList.Count());
                toolStripStatusLabel_Name.Text = string.Format("Korespondent: {0}", pdfResult.targetName);


            }

            Application.UseWaitCursor = false;
            
            MessageBox.Show("Process completed", "PDF Process", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = pdfOpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {              
                string path = pdfOpenDialog.FileName;
                ThreadStart ts = new ThreadStart(() => ProcessPDF(path, (pdfResult) => ProcessData(pdfResult)));
                Thread pdfTherad = new Thread(ts);
                pdfTherad.Priority = ThreadPriority.Highest;
                pdfTherad.Start();
                toolStripProgressBar.Style = ProgressBarStyle.Marquee;
                toolStripProgressBar.MarqueeAnimationSpeed = 30;
                Application.UseWaitCursor = true;



                Console.WriteLine("koniec");
                
            }
        }

        string projPath = "";
        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if(folderDialog.ShowDialog() == DialogResult.OK && pdfExtResult != null)
            {
                string folderPath = folderDialog.SelectedPath;
                string projectPath = Path.Combine(folderPath, pdfExtResult.date);
                projPath = projectPath;
                if (!Directory.Exists(projectPath))
                {
                    Directory.CreateDirectory(projectPath);
                    foreach (var company in pdfExtResult.extractionList)
                    {
                        string folderName = string.Format("{0}_{1}", company.KRS, company.years.Last());
                        Directory.CreateDirectory(Path.Combine(projectPath, folderName));
                    } 
                }
                string cmd = "explorer.exe";
                string arg = "/select, " + projectPath;
                Process.Start(cmd, arg);
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                var selectedRow = pdfExtResult.extractionList[e.RowIndex];
                string folderTarget = string.Format("{0}_{1}", selectedRow.KRS, selectedRow.years.Last());

                string folderTargetPath = Path.Combine(projPath, folderTarget);

                string cmd = "explorer.exe";
                string arg = "/open, " + folderTargetPath;
                Process.Start(cmd, arg);

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
