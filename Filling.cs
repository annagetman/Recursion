using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public class Filling
    {
        public static List<int> Boxes;
        public int EmptyPlace { get; set; }

        public List<int> CurrentBoxes { get; set; }

        public List<Filling> Next { get; set; }
        public static int Count { get; private set; }

        public Filling (int emptyPlace, List<int> currentBoxes = null)
        {
            EmptyPlace = emptyPlace;
            Next = new List<Filling>();
            if(currentBoxes is null)
            {
                currentBoxes = new List<int>();
            }
            else
            {
                CurrentBoxes = currentBoxes;
            }
        }

        public void CreateGraph()
        {
            foreach(int box in Boxes)
            {
                if(EmptyPlace >=box)
                {
                    List<int> tmp = new List<int>(CurrentBoxes);
                    tmp.Add(box);
                    Filling filling = new Filling(EmptyPlace - box, tmp);
                    Next.Add(filling);
                    filling.CreateGraph();
                }
            }
        }

        public void WriteAllLeaves()
        {
            if (Filling.Count ==0)
            {

                foreach (int b in CurrentBoxes )
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
;            }
            else
            {
                foreach(Filling n in Next)
                {
                    n.WriteAllLeaves();
                }
            }
        }
    }
}
