using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Malshinon.DAL
{
    internal class ReportDal
    {
        public static void AddReport(int ReporterId, int TargetId, string ReportText)
        {
            
            DateTime SubmittedAt = DateTime.Now;
            var sql = $"INSERT INTO reports(ReporterId, TargetId, ReportText, SubmittedAt)" +
              $"VALUES('{ReporterId}', '{TargetId}', '{ReportText}', '{SubmittedAt:yyyy-mm-dd HH:mm:ss}')";

            DBConnection.Execute(sql);
            var updateSql = $"UPDATE people SET num_reports = num_reports + 1 WHERE Id = {ReporterId}";
            DBConnection.Execute(updateSql);
        }



    }
}
