﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class MergeSort : ISort
    {
        public void sort(List<int> list)
        {
            Console.WriteLine("im doing merge sort");
        }
    }
}
