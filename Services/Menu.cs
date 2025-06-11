using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Malshinon.DAL;

namespace Project_Malshinon.Services
{
    internal class Menu
    {
        public static void Start()
        {
            Console.WriteLine("Malshinon - Community Intel Reporting System\n");
            while (true)
            {
                Console.WriteLine("1. Submit Report");
                Console.WriteLine("2. Import Repots From CSV");
                Console.WriteLine("3. Show Secret Code By Name");
                Console.WriteLine("4. Analysis Dashboard");
                Console.WriteLine("5. Exit");

                string chois = Console.ReadLine();


                switch (chois)
                {
                    case "1":
                        ReportService.AddDataToReport();
                    break;

                    //case "2":

                    case "3":
                       PersonService.ShowSecretName();
                        break;

                    case "5":
                        return;
                        
                    default:
                        Console.WriteLine("Invalid selection Enter a number between 1 and 5\n");
                        break;

                }
            }
        }
    }
}
