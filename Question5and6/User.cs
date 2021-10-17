using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5and6
{
    public class User
    {
        public event SuccessLoginDelegate SuccessLogin;
        public event UnsuccessLoginDelegate UnsuccessLogin;
        public bool isLogin = false;
        public string Username {  get; set; }
        public string Password {  get; set; }
    }
}
