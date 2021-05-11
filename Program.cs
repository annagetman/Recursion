using System;
using System.Collections.Generic;

namespace CinemaRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Film> userFilmsList = new List<Film>();
            int filmCount;
            int cinemaWorkingMinutes = 840;

            Console.WriteLine("введите количество фильмов в прокате:");
            filmCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите подробную информацию о каждом фильме(название и продолжительности фильма в минутах)");

            for(int i = 1; i <=filmCount; i++)
            {
                Console.WriteLine($"Введите название фильма № {i}:");
                string filmName = Console.ReadLine();
                Console.WriteLine($"Введите длительность фильма №{i} (в минутах):");
                int filmDuration = Convert.ToInt32(Console.ReadLine());
                userFilmsList.Add(new Film { Duration = filmDuration, Name = filmName });
            }
            GraphTree cinemaTable = new GraphTree(userFilmsList, cinemaWorkingMinutes,);
            cinemaTable.CreateTree();
            List<TableWithFreeTime> optimalTable = cinemaTable.CreateOptimalTable();
            PrintSchedule.PrintTable(optimalTable);
        }
    }
}

