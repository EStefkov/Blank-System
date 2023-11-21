using BLANKMenu.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BLANKMenu.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }


        /*
        Методът "AuthenticateUser" се използва за идентификация на потребител чрез предоставени потребителско име и парола.
        Той установява свързаност с база данни, използвайки "GetConnection," и изпраща SQL заявка за проверка на потребителско име и парола.
        Ако съответните данни съществуват в базата данни, методът връща "true," указвайки, че потребителят е валиден; в противен случай, връща "false."
        */

        public bool AuthenticateUser(NetworkCredential credential) // NetworkCredential credential се използва за предаване на потребителско име и парола към метода AuthenticateUser.
        {
            bool validUser= true;
            using (var connection = GetConnection())
            using (var command = new SqlCommand()) 
            {
            connection.Open(); 
                command.Connection = connection;
                command.CommandText = "select *from [Userrr] where username=@username and [password]=@password";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = credential.UserName;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = credential.Password;
                validUser = command.ExecuteScalar() == null ? false : true;
            }
                return validUser;
        }

        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetByAll()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        /*
        Методът "GetByUsername" извлича потребител от базата данни, като търси запис със съответно потребителско име.
        Този метод установява връзка с базата данни, използвайки "GetConnection," и изпраща SQL заявка за извличане на потребител.
        Ако намери съответния запис, създава модел на потребител и го връща; в противен случай, връща "null."
        */

        public UserModel GetByUsername(string username)
        {
            UserModel user=null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select *from [Userrr] where username=@username";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                using (var reader = command.ExecuteReader()) 
                { 
                if (reader.Read())
                    {
                        user = new UserModel()
                        {
                            Id = reader[0].ToString(),
                            Username = reader[1].ToString(),
                            Password = string.Empty,
                            Name = reader[3].ToString(),
                            LastName = reader[4].ToString(),
                            Email = reader[5].ToString(),
                        };
                    }
                }
               
            }
            return user;
        }

        public object GetByUsername(IPrincipal? currentPrincipal)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
