using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Weight
    {
        public List<int> weight;

        public Weight(int n, int seed)
        {
            Random r = new Random(seed+1);//żeby było różne od wagi
            weight = new List<int>();
            for (int i = 0; i < n; i++)
            {
                weight.Add(r.Next(1, 30));   //losowanie wagi od 1 do 30
            }

        }

        public override string ToString()
        {
            string wagi = string.Join(" ", weight.ToArray());
            return wagi;
        }
    }
}
