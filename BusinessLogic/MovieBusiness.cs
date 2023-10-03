using System;
using System.Collections.Generic;
using EZTechConsoleApp.DataAccess;
using EZTechConsoleApp.Models;

namespace EZTechConsoleApp.BusinessLogic
{
    public class MovieBusiness : IMovieBusiness
    {
        private IMovieRepository movieRepository;

        public MovieBusiness(IMovieRepository repository)
        {
            movieRepository = repository;
        }

        public void AddMovie()
        {
            EZTechMovie movie = new EZTechMovie();

            Console.Write("\nMovie Title: ");
            movie.Name = Console.ReadLine();

            Console.Write("Main Cast Count: ");
            if (!int.TryParse(Console.ReadLine(), out int castCount) || castCount <= 0)
            {
                Console.WriteLine("Invalid cast count. Please enter a positive integer.");
                return;
            }

            movie.Cast = new List<string>();
            Console.WriteLine("Cast Members:");
            for (int i = 0; i < castCount; i++)
            {
                Console.Write($"Main-Cast {i + 1} First & Last Name: ");
                movie.Cast.Add(Console.ReadLine());
            }

            Console.Write("Enter the movie rating: ");
            movie.Rating = Console.ReadLine();

            movieRepository.AddMovie(movie);
        }

        public void DisplayMovies()
        {
            List<EZTechMovie> movies = movieRepository.GetAllMovies();

            foreach (var movie in movies)
            {
                Console.WriteLine("----");
                Console.WriteLine("You entered");
                Console.WriteLine($"Movie Title: {movie.Name}");
                Console.WriteLine($"Main Cast: {movie.Cast.Count}");
                for (int i = 0; i < movie.Cast.Count; i++)
                {
                    Console.WriteLine($"Cast Member {i + 1}: {movie.Cast[i]}");
                }
                Console.WriteLine($"Rating: {movie.Rating}");
                Console.WriteLine("----");
            }
        }
    }
}
