using Project_Malshinon.DAL;
using System;
using System.Collections.Generic;
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
                Console.Write("Enter Secret Name: ");
                string CodeName = Console.ReadLine();

                Console.Write("Enter the type: ");
                string type = Console.ReadLine();

                PersonDal.AddPerson(CodeNameOrFullName, CodeName, type);

            }
            else
            {
                Console.Write("Enter Full Name: ");
                string FullName = Console.ReadLine();

                Console.Write("Enter the type: ");
                string type1 = Console.ReadLine();
                PersonDal.AddPerson(FullName, CodeNameOrFullName, type1);
            }
        }
    }
}
