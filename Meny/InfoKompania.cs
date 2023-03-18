using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPerseritje.Meny
{
    public class InfoKompania
    {
        public InfoKompania()
        {
            Console.WriteLine("Kompania:" + Globalja.EmriKompanise);

            Console.WriteLine("Menaxheri i Kompanise eshte:");
            var menaxher = Globalja.menaxheri;
            Console.WriteLine($"{menaxher.Emri} dhe eshte vetem {menaxher.Mosha} vjec.");

            Console.WriteLine("Punetoret e Kompanise jane:");
            foreach (var item in Globalja.menaxheri.Punetoret)
            {
                Console.WriteLine($"{item.Emri} | {item.Mosha} vjec.");
            }

            var detyratEkryera = Globalja.listaDetyrave.Where(d => d.Statusi == StatusDetyre.E_KRYER);
            if(detyratEkryera.Any()) 
            { 
                Console.WriteLine("Kompania ka kryer me sukses keto detyra:");
                foreach (var item in detyratEkryera)
                {
                    Console.Write($"{item.Emertimi} ");
                }
            }
        }
    }
}
