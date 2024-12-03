using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms.Classes.Nodes
{
    internal class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode? Next { get; set; }
        public DoubleNode? Prev { get; set; }

        public DoubleNode()
        {
            Value = 0;
            Next = null;
            Prev = null;
        }

        public DoubleNode(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
