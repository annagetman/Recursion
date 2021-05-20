using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRecursion
{
    public class Film
    {  
        public string Name { get; set; }
       
        public int Duration { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is Film)
            {
                Film film = (Film)obj;

                if (Duration == film.Duration && Name ==film.Name)
                {
                    result = true;
                }
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            int hour = Duration / 60;
            int minute = Duration % 60;
            string strMinute = minute == 0 ? "00" : minute.ToString();
            string time = $"{hour}:{strMinute}";
            result.Append($"{time} {Name} ");

            return result.ToString().Trim();
        }
    }
}

