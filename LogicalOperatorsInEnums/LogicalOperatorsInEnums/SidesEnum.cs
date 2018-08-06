using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperatorsInEnums
{
    [Flags]
    public enum SidesEnum
    {
        None = 0,
        Left = 1, Right = 2, Top = 4, Bottom = 8,
        LeftOrRight = Right | Left,
    }
}
