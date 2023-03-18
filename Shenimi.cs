using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPerseritje
{
    public class Shenimi<T> where T : class
    {
        public Shenimi() 
        {
            var tipi = Activator.CreateInstance<T>();
            tipi.ShenoIdentitetin();

            var metodatPublike = tipi.GetType().GetMethods(System.Reflection.BindingFlags.Public);
            var metodaEPare = metodatPublike.OrderBy(o => o.Name).FirstOrDefault();
            Console.WriteLine($"Metoda e pare eshte {metodaEPare?.Name}");

            Console.Write("Metodat tjera jane:");
            for (int i = 0; i < metodatPublike.Length; i++)
            {
                Console.Write($" {metodatPublike[i].Name}");
                
                var pikeOsePresje = i == metodatPublike.Length - 1 ? "." : ",";
                
                Console.Write(pikeOsePresje);
            }
        }
    }
}
