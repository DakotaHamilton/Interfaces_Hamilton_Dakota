using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Hamilton_Dakota
{
    /// <summary>
    /// Inherits the Get and Set Values for the Game class and Returns it
    /// </summary>
    class Game : IGenre
    {
        public string ESRB { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }


        public Game(string esrbParam, string genreParam, string titleParam)
        {
            ESRB = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }

    public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {ESRB}!";
        }


    }
}
