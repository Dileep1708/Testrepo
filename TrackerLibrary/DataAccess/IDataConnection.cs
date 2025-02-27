using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection : IDisposable
    {
        public void CreatePrize(PrizeModel model)
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public void CreatePerson(PersonModel model)
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

        public void UpdateMatchup(MatchUpModel model)
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        public void CompleteTournament(TournamentModel model)
        {
            throw new NotImplementedException("Database connection is disabled.");
        }

        List<TeamModel> GetTeam_All();

        List<PersonModel> GetPerson_All();

        List<TournamentModel> GetTournament_All();
    }
}
