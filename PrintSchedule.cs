using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRecursion
{
    public class PrintSchedule
    {
        public static void PrintTable(List<TableWithTreeTime> allTablesWithFreeTime)
        {
            Console.WriteLine("\nОптимальное расписание работы зала кинотеатра:");
            foreach (var currentTable in allTablesWithFreeTime)
            {
                DateTime startFilmTime = new DateTime(2021, 05, 12, 10, 00, 00);
                Console.WriteLine($"\nРасписание работы зала :");
                foreach (var currentFilm in currentTable.Table)
                {
                    DateTime endFilmTime = startFilmTime.AddMinutes(currentFilm.Duration);
                    Console.WriteLine($"{startFilmTime.ToShortDateString()}-{endFilmTime.ToShortDateString()} {currentFilm.Name}, продолжительность:{currentFilm.Duration} минут");
                    startFilmTime = endFilmTime;
                }
                Console.WriteLine($"Оставшееся свободное время в зале: {currentTable.FreeTime} минут");
                Console.WriteLine("\n*************");
            }
        }
    }    
}
