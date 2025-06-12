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
    internal class PersonService
    {
        public static void ShowSecretName()
        {
            Console.Write("Enter the Full name: ");
            var fullName = Console.ReadLine();


            if (PersonDal.CheackIfFullNameExsist(fullName))
            {
                var secretCode = PersonDal.ShowSecretNameByCodeName(fullName);
                Console.WriteLine($"Secret code: {secretCode}\n");
            }
            else
            {
                Console.WriteLine("This name is not in the table\n");
            }
        }

        public static void AddNewPerson(string CodeNameOrFullName)
        {
            var parts = CodeNameOrFullName.Split();
            if (parts.Length >= 2)
            {




                PersonDal.AddPerson(CodeNameOrFullName);
                Logger.Log($"New Person: Name: {CodeNameOrFullName} ");

            }
            else
            {
                Console.Write("Enter Full Name: ");
                string FullName = Console.ReadLine();


                PersonDal.AddPerson(FullName);
                Logger.Log($"New Person: Name: {FullName}");
            }
        }
    }
}
