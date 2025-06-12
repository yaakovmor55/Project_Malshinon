using Project_Malshinon.DAL;
using Project_Malshinon.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Malshinon.Services
{
    internal class AlertService
    {
        public static void ShowDiagnosticOnPerson()
        {
            Console.Write("Enter the target full name: ");
            string TargetName = Console.ReadLine();
            int TargetId = 0;
            if (PersonDal.CheackIfFullNameExsist(TargetName))
            {
                TargetId = Convert.ToInt32(PersonDal.CheackIfExsist(TargetName));

                int NumOFReports = AlertsDal.CheckAndTriggerAlerts(TargetId);
                if (NumOFReports >= 3)
                {
                    
                    Console.WriteLine($"{TargetName} have {NumOFReports} and he added to alerts\n");
                    Logger.Log($"Alert: Name: {TargetName} have {NumOFReports} reports");
                }
                else
                {
                    Console.WriteLine($"{TargetName} have {NumOFReports} and he not added to alerts\n");
                }
            }
            else
            {
                Console.WriteLine($"{TargetName} is not in the table\n");
            }
        }
        public static void AddAlert(int targetId)
        {
            int numOfReports = AlertsDal.CheckAndTriggerAlerts(targetId);
            if (numOfReports >= 3)
            {
                AlertsDal.AddAlert(targetId, "potential threat alert");
            }
        }
    }
}
