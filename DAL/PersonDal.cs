using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Project_Malshinon.Services;

namespace Project_Malshinon.DAL
{
    internal class PersonDal
    {
        

        public static void AddPerson(string FullName, string SecretCode, string type)
        {
            int num_reports = 0;
            int num_mentions = 0;
            var sql = $"INSERT INTO people(FullName, SecretCode, type, num_reports, num_mentions)" +
                $"VALUES('{FullName}', '{SecretCode}', '{type}', '{num_reports}', '{num_mentions}')"; 

            DBConnection.Execute(sql);
        }

        public static object CheackIfExsist(string CodeNameOrFullName)
        {
            string sqlCodeName = $"SELECT Id FROM people WHERE SecretCode = '{CodeNameOrFullName}'";
            var id = DBConnection.ExecuteScalar(sqlCodeName);
            if (id != null)
            {
                return id;
            }
            else if (id == null)
            {
                string sqlFullName = $"SELECT Id FROM people WHERE FullName = '{CodeNameOrFullName}'";
                var id2 = DBConnection.ExecuteScalar(sqlCodeName);
                if (id != null)
                {
                    return id2;
                }              
            }
            AddData.AddNewPerson(CodeNameOrFullName);
            CheackIfExsist(CodeNameOrFullName);
            return null;

        }
        public static void ShowSecretNameByCodeName(string SecretName)
        {
            string sql = $"SELECT SecretCode FROM people WHERE SecretCode = '{SecretName}'";
            DBConnection.ExecuteScalar(sql);
        }
    }
}
