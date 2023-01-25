using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Hamilton_Dakota
{
    /// <summary>
    /// Inherits the Get and Set Values for the Movie class and Returns it
    /// </summary>
    class Movie : IGenre
    {
        public string ESRB { get ; set ; }
        public string Genre { get ; set ; }
        public string Title { get ; set ; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            ESRB = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSsssshhhhh!");
        }

        public string Describe()
        {
            return $"The movie, {Title} is a {Genre} movie, rated {ESRB}!";
        }
    }
}
