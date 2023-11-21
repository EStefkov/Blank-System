using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLANKMenu.Models
{

    /*
  Класът "UserAccountModel" представлява модел на потребителския акаунт и съдържа информация, свързана с потребителския интерфейс.
    */
   public class UserAccountModel
    {
        public UserAccountModel() {
            Uername = string.Empty;
            DisplayName = string.Empty;
            ProfilePicture = null;
        }
        public string Uername { get; set; }
        public string DisplayName { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
