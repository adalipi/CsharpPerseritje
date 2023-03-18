using CsharpPerseritje.Implementime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPerseritje
{
    public class OperacioneMenaxhimi
    {
        public void PaguajPunetoret(List<Punetor> punetoret)
        {
            Console.WriteLine("Pagat u leshuan per punetoret: ");
            foreach (var p in punetoret) 
            { 
                Console.WriteLine(p.Emri);
            }
        }
    }
}
