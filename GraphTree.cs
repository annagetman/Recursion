using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaRecursion
{
    public class GraphTree
    {
        List<Film> movieList;
        Node root;
        public List<TableWithTreeTime> allTableWithFreeTime = new List<TableWithTreeTime>();
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
            foreach (var film in movieList)
            {
                if (node.RemainingTime >= film.Duration)
                {
                    List<Film> tmp = new List<Film>(node.CurrentFilms);
                    tmp.Add(film);
                    Node newNode = new Node(node.RemainingTime - film.Duration, tmp);
                    node.AddNext(newNode);
                    CreateGraph(newNode);
                }
            }
            bool b = true;
            foreach (var item in movieList)
            {
                if (node.RemainingTime >= item.Duration)
                { b = false; }
            }
            if (b)
            {
                TableWithTreeTime currentTable = new TableWithTreeTime();
                currentTable.FreeTime = node.RemainingTime;
                currentTable.Table = new List<Film>();
                foreach (var value in node.CurrentFilms)
                {
                    currentTable.Table.Add(new Film { Name = value.Name, Duration = value.Duration });
                }
                allTableWithFreeTime.Add(currentTable);
            }
        }

        public List<TableWithTreeTime> CreateOptimalTable()
        {
            List<TableWithTreeTime> result = new List<TableWithTreeTime>(allTableWithFreeTime);

            for (int i = allTableWithFreeTime.Count - 1; i > 0; i--)
            {
                result.RemoveAt(i);
            }
            return result;
        }
    }
}
