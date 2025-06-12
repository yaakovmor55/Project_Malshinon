using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Project_Malshinon.DAL;

namespace Project_Malshinon.Services
{
    internal class Menu
    {
        public static void Start()
        {
            
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("\t\t\t===== 🤖Malshinon - Community Intel Reporting System🤖 ====\n");
                Console.WriteLine("\t\t\t\t1. Submit Report 💀");
                Console.WriteLine("\t\t\t\t2. Import Repots From CSV 🧐");
                Console.WriteLine("\t\t\t\t3. Show Secret Code By Name 🤔");
                Console.WriteLine("\t\t\t\t4. Analysis Dashboard");
                Console.WriteLine("\t\t\t\t5. Exit 📤");
                Console.Write("\t\t\t\t");
                string chois = Console.ReadLine();


                switch (chois)
                {
                    case "1":
                        ReportService.AddDataToReport();
                    break;

                    case "2":
                        CSV.ImportCsv();
                        break;

                    case "3":
                       PersonService.ShowSecretName();
                        break;
                    case "4":
                        AlertService.ShowDiagnosticOnPerson();
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
