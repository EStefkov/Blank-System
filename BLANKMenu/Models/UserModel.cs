using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLANKMenu.Models
{
    /*
  Класът "UserModel" представлява модел на потребителския акаунт и съдържа информация, свързана с потребителите в системата.
    */
   public class UserModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}
