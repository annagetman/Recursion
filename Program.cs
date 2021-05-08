using System;
using System.Collections.Generic;

namespace Recursion
{
    class Program
    {
        


        static List<Film> Films = new List<Film> { };
        static int _countOfFilms;
        static int _filmDuration;
        static string _filmName;
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Enter count of films");
            _countOfFilms = Int32.Parse(Console.ReadLine());


            for (int i = 0; i <= _countOfFilms; i++)
            {
            Console.WriteLine("Enter film name:");
            _filmName = Console.ReadLine();

            Console.WriteLine("Enter film duration:");
            _filmDuration = Int32.Parse(Console.ReadLine());

                Films.Add(new Film { FilmName = _filmName, FilmDuration = _filmDuration });
            }           

        }
    }
}

