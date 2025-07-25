﻿using Project_Malshinon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Malshinon.Services
{
    internal class ReportService
    {
        public static void AddDataToReport()
        {
            Console.Write("your your Full Name or Secret Name: ");
            string ReporterName = Console.ReadLine();
            var ReporterId = Convert.ToInt32(PersonDal.CheackIfExsist(ReporterName));


            Console.Write("Enter terget's Full Name or Secret Name: ");

            string TargetName = Console.ReadLine();
            var TargetId = Convert.ToInt32(PersonDal.CheackIfExsist(TargetName));
            

            Console.Write("Please enter the report: ");
            string textReport = Console.ReadLine();


            ReportDal.AddReport(ReporterId, TargetId, textReport);
            PersonDal.SetReporterType(ReporterId);
            PersonDal.SetTargetType(TargetId);
            AlertService.AddAlert(TargetId);
            Console.WriteLine("The report was submitted\n\n");
        }
    }
}
