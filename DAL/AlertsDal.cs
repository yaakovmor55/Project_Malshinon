using Project_Malshinon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Malshinon.DAL
{
    internal class AlertsDal
    {
        public static void AddAlert(int TargetId,  string Reason)
        {
            DateTime CreatedAt = DateTime.Now;
            string sql = $"INSERT INTO alerts(TargetId, Reason, CreatedAt)" +
                $"VALUES({TargetId}, '{Reason}', '{CreatedAt}')";
            DBConnection.Execute(sql);
        }

        public static int CheckAndTriggerAlerts(int targetId)
        {
            string sql = $"SELECT num_reports FROM people WHERE Id = {targetId}";
            return Convert.ToInt32(DBConnection.ExecuteScalar(sql));
        }
    }
}
