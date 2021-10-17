using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5and6
{
    public class UsersList
    {
        public static event SuccessLoginDelegate SuccessLogin;
        public static event UnsuccessLoginDelegate UnsuccessLogin;

        static List<User> users = new List<User>();
        
        public static void OnLogIn(string username, string password)
        {
            foreach (User user in users)
            {
                if (username == user.Username)
                {
                    if ( password == user.Password)
                        if (SuccessLogin != null)
                        {
                            SuccessLogin(user, "Welcome");
                            user.isLogin = true;
                            return;
                        }
                        else
                            if (UnsuccessLogin != null)
                            {
                                UnsuccessLogin(null, "Wrong password");
                                return;
                            }
                }
            }
            if (UnsuccessLogin != null)
                UnsuccessLogin(null, "User name does not exist ");
        }
    }
}
