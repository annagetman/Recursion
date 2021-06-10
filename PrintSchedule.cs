using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRecursion
{
    public class PrintSchedule
    {
        public static void PrintTable(TimeTable bestTable)
        {
            Console.WriteLine("\nОптимальное расписание работы зала кинотеатра:");

            DateTime startFilmTime = new DateTime(2021, 06, 10, 10, 00, 00);
            Console.WriteLine($"\nРасписание работы зала :");
                foreach (var currentFilm in  bestTable.Table)
                {
                    DateTime endFilmTime = startFilmTime.AddMinutes(currentFilm.Duration);
                    Console.WriteLine($"{startFilmTime.ToShortDateString()}-{endFilmTime.ToShortDateString()} {currentFilm.Name}, время{currentFilm.Duration} минут");
                    startFilmTime = endFilmTime;
                }
                Console.WriteLine($"Оставшееся свободное время в зале: {bestTable.FreeTime} минут");          
        }
    }    
}
