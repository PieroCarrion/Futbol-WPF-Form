using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos {
    public class DataBase {
        private SqlConnection conn = null; 
        public SqlConnection conectaDB() {
            try {
                conn = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = futbolDB; Integrated Security = True");
                conn.Open();
                return conn;
            } catch (SqlException ex) {
                return null;
            }
        }
        public void desconectaDB() {
            conn.Close();
        }
    }
}
