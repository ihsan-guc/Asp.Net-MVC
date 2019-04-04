using System.Data.Entity;

namespace Asp.Net.MVC.Models
{
    public class DatabesSetInitializer : DropCreateDatabaseIfModelChanges<LoginContext>
    {
        protected override void Seed(LoginContext context)
        {
            var login = new Login
            {
                Id = 0,
                UserName = "eysan",
                Password = "123",
                Email = "yedisinek@outlook.com"

            };
            context.Logins.Add(login);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}