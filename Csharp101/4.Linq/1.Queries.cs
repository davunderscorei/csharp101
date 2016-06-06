using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp101_1.Linq
{
    class Queries
    {
        void Test()
        {
            var items = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // standard loop search approach
            var findResult = 0.0;

            foreach (var item in items)
            {
                if (item == 4)
                {
                    findResult = item;
                    break;
                }
            }

            // LINQ search
            findResult = items.Where(i => i == 4).First();

            // complex LINQ search
            findResult = items.OrderByDescending(i => i)
                              .Skip(1)
                              .Where(i => i > 3)
                              .Average();
        }
    }
}
