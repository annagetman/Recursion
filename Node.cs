﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRecursion
{
    public class Node
    {

        public int RemainingTime { get; set; }
        public List<Film> CurrentFilms;
        public List<Node> Next { get; set; }
        public Node(int freeTime, List<Film> currentFilms)
        {
            RemainingTime = freeTime;
            CurrentFilms = currentFilms;
            Next = new List<Node>();
        }
        public void AddNext(Node node)
        {
            Next.Add(node);
        }

    }
}
