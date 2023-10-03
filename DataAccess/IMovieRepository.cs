using EZTechConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZTechConsoleApp.DataAccess
{
    public interface IMovieRepository
    {
        void AddMovie(EZTechMovie movie);
        List<EZTechMovie> GetAllMovies();
    }
}
