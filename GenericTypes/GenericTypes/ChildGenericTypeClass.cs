using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public class ChildGenericTypeClass<T1, T2> : ParentGenericTypeClass<T1> where T1 : new() // dziedziczenie klas typów generycznych + wymaganie konstruktora bezparametrowego na typie
    {
    }
}
