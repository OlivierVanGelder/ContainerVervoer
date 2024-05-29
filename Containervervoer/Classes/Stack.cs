using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer.Classes
{
    public class Stack
    {
        public List<Container> Containers { get; set; } = new();
        public int RowIndex { get; set; }
        public int StackIndex { get; set; }

        public Stack(int rowIndex, int stackIndex) 
        { 
            RowIndex = rowIndex;
            StackIndex = stackIndex;
        }

        public int CalculateTotalWeigth()
        {
            return Containers.Sum(c => c.Weight);
        }

        public bool TryAdd(Container container, Func<int, int, int, bool> checkEmptySurrounding)
        {            
            if (Containers.LastOrDefault()?.Valuable ?? false)
            {
                if (container.Valuable)
                    return false;
                if (CalculateTotalWeigth() > 120)
                    return false;
                Containers.Insert(0, container);
                return true;
            }
            else
            {
                if (container.Valuable)
                    if (!checkEmptySurrounding(RowIndex, StackIndex, Containers.Count))
                        return false;
                if ((Containers.Skip(1).Sum(c => c.Weight) + container.Weight) > 120)
                    return false;
                Containers.Add(container);
                return true;
            }
        }
    }
}