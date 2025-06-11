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
        public static void AddAlert(int TargetId, DateTime WindowStart, DateTime WindowEnd, string Reason, DateTime CreatedAt)
        {
            string sql = $"INSERT INTO alerts(TargetId, WindowStart, WindowEnd, Reason, CreatedAt)" +
                $"VALUES('{TargetId}', '{WindowStart}', '{WindowEnd}', '{Reason}', '{CreatedAt}')";
            DBConnection.Execute(sql);
        }
    }
}
