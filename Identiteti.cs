using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPerseritje
{
    public static class Identitetiti
    {
        public static void ShenoIdentitetin (this object personi)
        {
            var njeriu = personi as Person;
            var tipi = personi?.GetType().ToString();
            Console.WriteLine($"Profesioni i {njeriu?.Emri} qe ka moshen {njeriu?.Mosha}, eshte {tipi}.");
        }
    }
}
