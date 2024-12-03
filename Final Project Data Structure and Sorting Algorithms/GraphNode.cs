using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal class GraphNode
    {
        public string Name { get; set; }
        public List<Edge> Neighbors { get; set; }

        public GraphNode(string name)
        {
            Name = name;
            Neighbors = new List<Edge>();
        }
    }
}
