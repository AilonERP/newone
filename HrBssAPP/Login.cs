using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HrDBAPP;

namespace HrBssAPP
{
    public class Login
    {
        public bool LoginAmin(string user, string pass) 
        {
            Admain admin = new Admain();
         return admin.Login(user, pass);
        
        }


    }
}
