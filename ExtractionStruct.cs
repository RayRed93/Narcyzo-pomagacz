using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narcyzo_pomagacz
{
    public class PdfExtraction
    {
        public List<ExtractionRecord> extractionList;
        public string date;
        public string targetName;

        public PdfExtraction(List<ExtractionRecord> _extractionList, string _date, string _targetName)
        {
            extractionList = _extractionList;
            date = _date;
            targetName = _targetName;
        }
    }

    public class ExtractionRecord
    {
        public short id { get; set; }
        public string name { get; set; }
        public int KRS { get; set; }
        public List<int> years { get; set; }
        public ExtractionRecord(short _id, string _name, int _KRS, List<int> _years)
        {
            id = _id;
            name = _name;
            KRS = _KRS;
            years = _years;
        }

        public string GetYearsString()
        {
            string yearsOut = "";
            for (int i = 0; i < years.Count - 1; i++)
            {              
                yearsOut += string.Format("{0}, ", (years[i] + 2000).ToString());
            }
            yearsOut += years.Last() + 2000;
            return yearsOut;
        }
    }
}
