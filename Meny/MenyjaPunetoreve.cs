using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPerseritje.Meny
{
    public class MenyjaPunetoreve
    {
        public MenyjaPunetoreve()
        {
            while (true)
            {
                Console.WriteLine("Menyja e punetoreve.");
                Console.WriteLine("Zgjidh punetorin: ");

                for (int i = 0; i < Globalja.listaePunetoreve.Count; i++)
                {
                    Console.WriteLine($"{i} {Globalja.listaePunetoreve[i].Emri}");
                }

                var zgjidhja = int.Parse(Console.ReadLine());

                if (zgjidhja < 0 && zgjidhja > Globalja.listaePunetoreve.Count-1)
                    return;

                var puntori = Globalja.listaePunetoreve[zgjidhja];

                Console.WriteLine($"Zgjodhet punteorin {puntori.Emri}");

                break;
            }
        }
    }
}
