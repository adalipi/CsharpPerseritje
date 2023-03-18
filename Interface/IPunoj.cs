using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPerseritje.Interface
{
    public interface IPunoj
    {
        void MerrDetyren(Detyra detyra);
        void PunoNeDetyren(int idEdetyres, int minuta);
    }
}
