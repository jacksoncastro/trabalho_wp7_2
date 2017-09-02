using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_wp7_2
{
    public class LoginManager
    {
        public static ObservableCollection<User> Users = new ObservableCollection<User>();

        public static User currentUser = null;
    }
}