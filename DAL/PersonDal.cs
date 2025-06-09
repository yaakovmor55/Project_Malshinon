using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Malshinon.DAL
{
    internal class PersonDal
    {
        public static void AddPerson(string FirstName, string LastName, string SecretCode, string type)
        {
            int num_reports = 0;
            int num_mentions = 0;
            var sql = $"INSERT INTO people(FirstName, LastName, SecretCode, type, num_reports, num_mentions)" +
                $"VALUES('{FirstName}', '{LastName}', '{SecretCode}', '{type}', '{num_reports}', '{num_mentions}')"; 

            DBConnection.Execute(sql);
        }
    }
}
