using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class UsingGenericMethods<M>where M : IComparable<M>
    {
        
        public M[] inputArray;
        public UsingGenericMethods(M[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public static M MaxOfMultiplevalueGenerics<M>(params M[] inputArray)
        {
            Array.Sort(inputArray);
            return inputArray[inputArray.Length - 1];

        }
    }
    
}

   