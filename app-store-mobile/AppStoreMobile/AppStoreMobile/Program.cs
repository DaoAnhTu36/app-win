using AppStoreMobile.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AppStoreMobile
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseMySql(connStr, ServerVersion.AutoDetect(connStr))
                .Options;

            using var db = new AppDbContext(options);
            db.Database.EnsureCreated();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(options));
        }
    }
}