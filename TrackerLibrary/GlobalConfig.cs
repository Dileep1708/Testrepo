using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static string PrizesFile { get; private set; }
        public static string PeopleFile { get; private set; }
        public static string TeamFile { get; private set; }
        public static string TournamentFile { get; private set; }
        public static string MatchupFile { get; private set; }
        public static string MatchupEntryFile { get; private set; }

        public static bool IsDbConnectionEnabled { get; set; } = true;

        public static IDataConnection Connection { get; private set; }
        private static IConfiguration Configuration { get; set; }

        public static void InitializeConnections(DatabaseType db, IConfiguration configuration)
        {
            Configuration = configuration;

            PrizesFile = Configuration["AppSettings:PrizesFile"];
            PeopleFile = Configuration["AppSettings:PeopleFile"];
            TeamFile = Configuration["AppSettings:TeamFile"];
            TournamentFile = Configuration["AppSettings:TournamentFile"];
            MatchupFile = Configuration["AppSettings:MatchupFile"];
            MatchupEntryFile = Configuration["AppSettings:MatchupEntryFile"];


            if (IsDbConnectionEnabled && db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }

        }

        public static string ConnectionString(string connectionName)
        {
            return Configuration.GetConnectionString(connectionName);
        }

        public static string AppKeyLookup(string key)
        {
            return Configuration["AppSettings:" + key];
        }
    }
}
