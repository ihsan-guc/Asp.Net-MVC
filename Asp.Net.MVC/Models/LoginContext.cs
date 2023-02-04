using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.Net.MVC.Models
{
    public class LoginContext : DbContext
    {
        public LoginContext() : base("LoginContext")
        {

        }
        public DbSet<Login> Logins { get; set; }
    }
}