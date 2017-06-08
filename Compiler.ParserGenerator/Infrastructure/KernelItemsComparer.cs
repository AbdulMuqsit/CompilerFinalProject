﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Compiler.Common;

namespace Compiler.ParserGenerator.Infrastructure
{
    public class KernelItemsComparer : IEqualityComparer<List<Item>>
    {
        public bool Equals(List<Item> x, List<Item> y)
        {
            for (int i = 0; i < y.Count; i++)
            {
                if (x[i] != y[i])
                {
                    return false;
                }

            }
            return true;
        }

        public int GetHashCode(List<Item> obj)
        {
            return obj.GetHashCode();
        }
    }
}
