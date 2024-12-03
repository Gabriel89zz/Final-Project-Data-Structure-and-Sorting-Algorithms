using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Data_Structure_and_Sorting_Algorithms
{
    internal class SortMetrics
    {
        public int ComparisonsCount { get; set; }
        public int SwapsCount { get; set; }

        public SortMetrics()
        {
            ComparisonsCount = -1;
            SwapsCount = 0;
        }
    }
}
