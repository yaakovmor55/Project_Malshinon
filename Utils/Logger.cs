﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_Malshinon.Utils
{
    internal class Logger
    {
        public static void Log(string message)
        {
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            Console.WriteLine(logEntry);
            File.AppendAllText("log.txt", logEntry + Environment.NewLine);
        }
        public static string Read()
        {
            if (!File.Exists("log.txt"))
            {
                return string.Empty;
            }
            return File.ReadAllText("log.txt");
        }
    }
}

