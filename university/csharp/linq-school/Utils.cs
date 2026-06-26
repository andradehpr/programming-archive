using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqSchool
{
    internal class Utils
    {
        // predicate é um como se fosse um delegate , mas para um booleano
        internal static IEnumerable<int> magico(int limite,Predicate<int>predi)
        {
            for (int i = 0; i < limite; i++)
            {
                Thread.Sleep(100);
                if (predi(i)) yield return i;
            }
        }



        internal bool Eprimo(int n)
        {
            if (n < 2) return false;
            int div = 2, r, quoc;
            do
            {
                r = n % div;
                quoc = n / div;
            } while (r != 0 && quoc > div);

            return r != 0 || n == 2;

        }
    }
}
