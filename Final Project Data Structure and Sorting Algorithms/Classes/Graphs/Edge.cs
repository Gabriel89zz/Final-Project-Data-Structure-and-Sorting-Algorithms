using Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Graphs
{
    internal class Edge
    {
        public GraphNode To { get; set; }
        public int Weight { get; set; }

        public Edge(GraphNode to, int weight)
        {
            To = to;
            Weight = weight;
        }

        public Edge(GraphNode to)
        {
            To = to;
        }

    }
}
