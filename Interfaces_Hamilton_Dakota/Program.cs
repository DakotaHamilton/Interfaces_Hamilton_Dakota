using System;

namespace Interfaces_Hamilton_Dakota
{
    class Program
    {   
        /// <summary>
        /// Gives the Interface Values and Instructions
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Game myGame = new Game("T", "TPS", "Fortnite");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("PG", "Comedy/Fantasy", "Ghostbusters");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
