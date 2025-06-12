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
        

        public static void AddPerson(string FullName)
        {
            int num_reports = 0;
            int num_mentions = 0;
            string SecretCode = Guid.NewGuid().ToString("N").Substring(0,8);
            var sql = $"INSERT INTO people(FullName, SecretCode, num_reports, num_mentions)" +
                $"VALUES('{FullName}', '{SecretCode}', '{num_reports}', '{num_mentions}')"; 

            DBConnection.Execute(sql);
        }

        public static object CheackIfExsist(string codeNameOrFullName)
        {
            
            string sqlCodeName = $"SELECT Id FROM people WHERE SecretCode = '{codeNameOrFullName.Replace("'", "''")}' OR FullName = '{codeNameOrFullName.Replace("'", "''")}'";
            var id = DBConnection.ExecuteScalar(sqlCodeName);
            if (id != null)
                return id;

            
            PersonService.AddNewPerson(codeNameOrFullName);

            
            string sqlAfterInsert = $"SELECT Id FROM people WHERE SecretCode = '{codeNameOrFullName.Replace("'", "''")}' OR FullName = '{codeNameOrFullName.Replace("'", "''")}'";
            var newId = DBConnection.ExecuteScalar(sqlAfterInsert);
            return newId;
        }

        public static object ShowSecretNameByCodeName(string FullName)
        {
            string safeFullName = FullName.Replace("'", "''");

            string sql = $"SELECT SecretCode FROM people WHERE FullName = '{safeFullName}'";
            return DBConnection.ExecuteScalar(sql);
        }

        public static bool CheackIfFullNameExsist(string fullName)
        {
            var sql = $"SELECT Id FROM people WHERE FullName = '{fullName.Replace("'", "''")}'";
            var exsist = DBConnection.ExecuteScalar(sql);
            return exsist != null;
        }

        public static void SetTargetType(int TargetId)
        {
            string SqlUpdate = $"UPDATE people SET type = 'Target' WHERE Id = {TargetId};";
            DBConnection.Execute(SqlUpdate);
        }

        public static void SetReporterType(int reporterId)
        {
            string SqlUpdate = $"UPDATE people SET type = 'Reporter' WHERE Id = {reporterId};";
            DBConnection.Execute(SqlUpdate);
        }
    }


}
