using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Malshinon.Models
{
    internal class Report
    {
        public string ReportedId { get; set; }
        public string TargetId {  get; set; }
        public string ReportText {  get; set; }
        public DateTime SubmitAt { get; set; }

        public Report(string reportedId, string targetId, string reportText)
        {
            ReportedId = reportedId;
            TargetId = targetId;
            ReportText = reportText;
            SubmitAt = DateTime.Now;
        }
    }
}
