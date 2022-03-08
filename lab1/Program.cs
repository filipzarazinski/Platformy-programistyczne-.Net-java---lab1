using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> plecak;
            plecak = new List<int>();


            Console.WriteLine("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seed:" );
            int seed = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the capacity:");
            int cap = int.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine);
            Value wartosci = new Value(n, seed);
            Weight wagi = new Weight(n, seed);

            for (int i = 0; i < n; i++)
            {
             
                var a = (i).ToString();

                Console.WriteLine(a  + "." + " v= " + wartosci.value[i] + "  w= " + wagi.weight[i]);
            }


            int suma_wagi = 0;
            int suma_wartosci = 0;
            for (int i = 0; i < n; i++)
            {   if (wagi.weight[i] + suma_wagi <= cap)
                {
                    plecak.Add(i);
                    suma_wagi += wagi.weight[i];
                    suma_wartosci += wartosci.value[i];
                }
                
                
                
               
            }
            Console.WriteLine("Przedmioty, ktore sie zmiescily:");
            for (int i = 0; i < plecak.Count; i++)
            {
                var a = (i).ToString(); 
                Console.WriteLine(plecak[i] + "."+ " v= " + wartosci.value[plecak[i]] + "  w= " + wagi.weight[plecak[i]]);
            }
            Console.WriteLine("Laczna waga = " + suma_wagi + " Laczna wartosc = " + suma_wartosci);
        }
    }
}
