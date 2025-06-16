using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class PrimeNumberCollection : IEnumerable<int>
    {
        private int start;
        private int end;

        public PrimeNumberCollection(int start, int end)
        {
            if (start > end)
                throw new ArgumentException("Start must be less than or equal to end");

            this.start = start;
            this.end = end;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    yield return i;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }

}
