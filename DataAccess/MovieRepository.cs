using System.Collections.Generic;
using EZTechConsoleApp.DataAccess;
using EZTechConsoleApp.Models;

namespace EZTechConsoleApp.DataAccess
{
    public class MovieRepository : IMovieRepository
    {
        private List<EZTechMovie> movieDatabase = new List<EZTechMovie>();

        public void AddMovie(EZTechMovie movie)
        {
            movieDatabase.Add(movie);
        }

        public List<EZTechMovie> GetAllMovies()
        {
            return movieDatabase;
        }
    }
}
