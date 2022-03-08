using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Value
    {
        public List<int> value;

        public Value(int n, int seed)
        {
            Random r = new Random(seed);
            value = new List<int>();
            for (int i = 0; i < n; i++)
            {
                value.Add(r.Next(1,30));        //losowanie wartości i wagi od 1 do 30
            }

        }

        public override string ToString()
        {
            string wartosci = string.Join(" ", value.ToArray());  
            return wartosci;
        }
    }
}
