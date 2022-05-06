using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class CreateGenericClass<M> where M : IComparable
    {
        public M a, b, c;
        public CreateGenericClass(M a, M b, M c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static M MaxValueGeneric<M>(M a, M b, M c) where M : IComparable<M>
        {

            if ((a.CompareTo(b) > 0 && (a.CompareTo(c) > 0)) || (a.CompareTo(b) >= 0 && a.CompareTo(c) > 0) || (a.CompareTo(b) > 0 && a.CompareTo(c) >= 0))
            {
                return a;
            }
            if ((b.CompareTo(a) > 0 && b.CompareTo(c) > 0) || (b.CompareTo(a) >= 0 && b.CompareTo(c) > 0) || (b.CompareTo(a) > 0 && b.CompareTo(c) >= 0))
            {
                return b;
            }
            else if ((c.CompareTo(a) > 0 && c.CompareTo(b) > 0) || (c.CompareTo(a) >= 0 && c.CompareTo(b) > 0) || (c.CompareTo(a) > 0 && c.CompareTo(b) >= 0))
            {
                return c;
            }

            return default;
        }
    }
}
    
