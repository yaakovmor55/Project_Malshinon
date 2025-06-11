using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Malshinon.DAL;

namespace Project_Malshinon.Services
{
    internal class AlertService
    {
        public static void AddAlertOnTarget()
        {
            Console.Write("Enter the target full name: ");
            string fullName = Console.ReadLine();
            int TargetId = 0;
            if (PersonDal.CheackIfFullNameExsist(fullName))
            {
                TargetId = Convert.ToInt32(PersonDal.CheackIfExsist(fullName));

                int NumOFReports = AlertsDal.CheckAndTriggerAlerts(TargetId);
                if (NumOFReports >= 20)
                {
                    AlertsDal.AddAlert(TargetId, "potential threat alert");
                    Console.WriteLine($"{fullName} have {NumOFReports} and he added to alerts\n");
                }
                else
                {
                    Console.WriteLine($"{fullName} have {NumOFReports} and he not added to alerts\n");
                }
            }
            else
            {
                Console.WriteLine($"{fullName} is not in the table\n");
            }
        }
    }
}
