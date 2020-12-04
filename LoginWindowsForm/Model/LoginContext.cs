
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWindowsForm.Model
{    class LoginContext : DbContext
    { 
        public LoginContext() : base("name=con") 
        {
            Database.SetInitializer(new LogingDbInitializer());
        }
       public DbSet<User> Users { get; set; }
    }
}
