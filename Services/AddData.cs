using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Malshinon.DAL;

namespace Project_Malshinon.Services
{
    internal class AddData
    {
        public static void AddDataToReport()
        {
            Console.Write("your Full Name or Secret Name: ");
            string ReporterName = Console.ReadLine();
            var ReporterId = Convert.ToInt32(PersonDal.CheackIfExsist(ReporterName));
            

            Console.Write("Enter Full Name or Secret Name: ");
            string TargetName = Console.ReadLine();
            var TargetId = Convert.ToInt32(PersonDal.CheackIfExsist(TargetName));

            Console.Write("Please enter the report: ");
            string textReport = Console.ReadLine();

            ReportDal.AddReport(ReporterId, TargetId, textReport);
            Console.WriteLine("The report was submitted\n\n");
        }

        public static void AddNewPerson(string CodeNameOrFullName)
        {
            var parts = CodeNameOrFullName.Split();
            if (parts.Length >= 2)
            {
                Console.Write("Enter Secret Name: ");
                string CodeName = Console.ReadLine();

                Console.Write("Enter the type: ");
                string type = Console.ReadLine();

                PersonDal.AddPerson(CodeNameOrFullName, CodeName, type);
                
            }
            Console.Write("Enter Full Name: ");
            string FullName = Console.ReadLine();

            Console.Write("Enter the type: ");
            string type1 = Console.ReadLine();
            PersonDal.AddPerson(FullName, CodeNameOrFullName, type1);
        }

        public static void ShowSecretName()
        {
            Console.Write("Enter the secret name: ");
            var SecretCode = Console.ReadLine();
            PersonDal.ShowSecretNameByCodeName(SecretCode); 
        }





    }
}
