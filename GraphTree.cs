using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRecursion
{
    public class GraphTree
    {
        List<Film> movieList;
        Node root;
        public List<TableWithFreeTime> allTableWithFreeTime = new List<TableWithFreeTime>();
        public GraphTree(List<Film> list, int FreeTime)
        {
            movieList = list;
            root = new Node(FreeTime, new List<Film>());
        }
        public void CreateTree()
        {
            CreateGraph(root);
        }
        public void CreateGraph(Node node)
        {

        }
    }
}
