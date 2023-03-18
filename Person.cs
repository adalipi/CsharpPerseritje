using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPerseritje
{
    public abstract class Person
    {
        public int Mosha { get; set; }
        public string Emri { get; set; }

        public virtual void Flet()
        {
            Console.WriteLine($"Personi {Emri} po flet.");
        }

        public void ShenoIdentitet()
        {

            this.ShenoIdentitetin();
        }
    }
}
