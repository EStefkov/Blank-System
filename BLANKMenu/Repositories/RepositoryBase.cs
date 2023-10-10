using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace BLANKMenu.Repositories
{
   public abstract class RepositoryBase
    {
        private readonly string _connectionString;

        // connection with DB
        public RepositoryBase() 
        {
            //Server=localhost\MSSQLSERVER01;Database=master;Trusted_Connection=True;
            //  
            _connectionString = "Server=localhost\\MSSQLSERVER01;Database=BlankSystem; Integrated Security=true";
        }


        
        protected SqlConnection GetConnection()  
        {
            return new SqlConnection(_connectionString);
        }
    }
}
