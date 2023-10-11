using EZTechConsoleApp.BusinessLogic;
using EZTechConsoleApp.DataAccess;
using System;

namespace EZTechConsoleApp
{
    class Program
    {
        static void Main()
        {
            char choice;
            IMovieRepository movieRepository = new MovieRepository();
            IMovieBusiness movieBusiness = new MovieBusiness(movieRepository);

            do
            {
                Console.Write("Would you like to store additional movies? (Y/N): ");
                choice = Console.ReadKey().KeyChar;

                if (choice != 'Y' && choice != 'y' && choice != 'N' && choice != 'n')
                {
                    Console.WriteLine("\nInvalid choice. Please enter 'Y' or 'N'.");
                }
            } while (choice != 'Y' && choice != 'y' && choice != 'N' && choice != 'n');

            if (choice == 'Y' || choice == 'y')
            {
                do
                {
                    movieBusiness.AddMovie();
                    Console.Write("Would you like to store additional movies? (Y/N): ");
                    choice = Console.ReadKey().KeyChar;

                    if (choice != 'Y' && choice != 'y' && choice != 'N' && choice != 'n')
                    {
                        Console.WriteLine("\nInvalid choice. Please enter 'Y' or 'N'.");
                    }
                } while (choice == 'Y' || choice == 'y');
            }

            movieBusiness.DisplayMovies();
        }
    }
}
