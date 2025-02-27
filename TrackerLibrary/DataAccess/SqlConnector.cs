using System;
using System.Collections.Generic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public void CreatePerson(PersonModel model)
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public void CreatePrize(PrizeModel model)
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public void CreateTeam(TeamModel model)
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public void CreateTournament(TournamentModel model)
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public List<PersonModel> GetPerson_All()
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public List<TeamModel> GetTeam_All()
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public List<TournamentModel> GetTournament_All()
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public void UpdateMatchup(MatchUpModel model)
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public void CompleteTournament(TournamentModel model)
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public void Dispose()
        {
            // No resources to dispose
        }
    }
}
