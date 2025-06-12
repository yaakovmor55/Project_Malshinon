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

            string SubmittedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var sql = $"INSERT INTO reports(ReporterId, TargetId, ReportText, SubmittedAt)" +
              $"VALUES('{ReporterId}', '{TargetId}', '{ReportText.Replace("'", "''")}', '{SubmittedAt}')";

            DBConnection.Execute(sql);
            var updateeRporterSql = $"UPDATE people SET num_reports = num_reports + 1 WHERE Id = {ReporterId}";
            var updateTargetSql = $"UPDATE people SET num_mentions = num_mentions + 1 WHERE Id = {TargetId}";
            DBConnection.Execute(updateeRporterSql);
            DBConnection.Execute(updateTargetSql);
        }



    }
}
