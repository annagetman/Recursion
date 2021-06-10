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
    }
}

