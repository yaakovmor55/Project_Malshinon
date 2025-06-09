using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Malshinon.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public string CodeName { get; set; }
        public DateTime Date { get; set; }


        public Person(string name, string code)
        {
            Name = name;
            CodeName = code;
            Date = DateTime.Now;
        }
    }
}
