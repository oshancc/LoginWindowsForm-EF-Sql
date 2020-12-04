using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWindowsForm.Model
{
    public static class Service
    {
        public static bool LoginUser(string userName, string password)
        {
            using(LoginContext db = new LoginContext())
            {
                var rec = db.Users.Where(a => a.UserName == userName && a.Password == password).FirstOrDefault();
                if(rec != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
