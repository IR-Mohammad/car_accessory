using Dapper;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccess
{
    public class LoadAndSaveAccessDb
    {
        public List<T> LoadData<T,U>(string conn, string query, U parameters)
        {
           

            using (IDbConnection sql = new SQLiteConnection(conn))
            {
                List<T> output = sql.Query<T>(query, parameters).ToList();
                return output;
            }
        }
        public void SaveData<T>(string conn, string query, T parameters)
        {
            using (IDbConnection sql = new SQLiteConnection(conn))
            {
                sql.Execute(query, parameters);
            }
        } 

    }
}
