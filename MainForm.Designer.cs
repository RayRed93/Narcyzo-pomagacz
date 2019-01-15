namespace Narcyzo_pomagacz
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.years = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel_Bilanse = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.instructionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(144, 12);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(126, 46);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.krs,
            this.years,
            this.Completed});
            this.dataGridView.Location = new System.Drawing.Point(12, 66);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(747, 339);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Nazwa firmy";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // krs
            // 
            this.krs.HeaderText = "KRS";
            this.krs.Name = "krs";
            this.krs.ReadOnly = true;
            // 
            // years
            // 
            this.years.HeaderText = "Lata";
            this.years.Name = "years";
            this.years.ReadOnly = true;
            this.years.Width = 130;
            // 
            // Completed
            // 
            this.Completed.FalseValue = "false";
            this.Completed.HeaderText = "Zakończone";
            this.Completed.Name = "Completed";
            this.Completed.TrueValue = "true";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripProgressBar,
            this.toolStripStatusLabel_Bilanse,
            this.toolStripStatusLabel_Date,
            this.toolStripStatusLabel_Name});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(771, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel2.Text = "Status";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripStatusLabel_Bilanse
            // 
            this.toolStripStatusLabel_Bilanse.Name = "toolStripStatusLabel_Bilanse";
            this.toolStripStatusLabel_Bilanse.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.toolStripStatusLabel_Bilanse.Size = new System.Drawing.Size(101, 20);
            this.toolStripStatusLabel_Bilanse.Text = "Bilanse: 0";
            // 
            // toolStripStatusLabel_Date
            // 
            this.toolStripStatusLabel_Date.Name = "toolStripStatusLabel_Date";
            this.toolStripStatusLabel_Date.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.toolStripStatusLabel_Date.Size = new System.Drawing.Size(123, 20);
            this.toolStripStatusLabel_Date.Text = "Data: __-__-____";
            this.toolStripStatusLabel_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_Name
            // 
            this.toolStripStatusLabel_Name.Name = "toolStripStatusLabel_Name";
            this.toolStripStatusLabel_Name.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.toolStripStatusLabel_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel_Name.Size = new System.Drawing.Size(177, 20);
            this.toolStripStatusLabel_Name.Text = "Korespondent: ________";
            this.toolStripStatusLabel_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(276, 7);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(332, 51);
            this.instructionsLabel.TabIndex = 7;
            this.instructionsLabel.Text = "1. Open PDF and wait for complete process\r\n2. Process to create folder tree in sp" +
    "ecified location\r\n3. Double click list item to open related folder\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 446);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Narcyzo-pomagacz v0.01";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Bilanse;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn krs;
        private System.Windows.Forms.DataGridViewTextBoxColumn years;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
        private System.Windows.Forms.Label instructionsLabel;
    }
}

