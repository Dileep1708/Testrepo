using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            GlobalConfig.IsDbConnectionEnabled = false; // Set this to false to disable the database connection
            GlobalConfig.InitializeConnections(DatabaseType.TextFile, configuration);


            Application.Run(new TournamentDashboardForm());
        }
    }
}
