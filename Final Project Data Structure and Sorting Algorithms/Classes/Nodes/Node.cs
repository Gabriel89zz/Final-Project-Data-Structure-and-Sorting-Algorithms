using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Nodes
{
    internal class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }
        public Node()
        {
            Value = 0;
            Next = null;
        }
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
