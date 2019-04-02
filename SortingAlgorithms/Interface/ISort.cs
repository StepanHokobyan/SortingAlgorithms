﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Interface
{
    interface ISort
    {
        int n { get; set; }
        int[] arr { get; set; } 

        void Compare();
        void SetValues();

    }
}
