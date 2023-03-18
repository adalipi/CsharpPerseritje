using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPerseritje
{
    public class Detyra
    {
        private int _id;

        public Detyra(int id) 
        { 
            _id = id;
        }

        public string Emertimi 
        { 
            get { return $"DETYRA: {this._id}"; }
        }

        public int MinutatEPunuara { get; set; }
        public StatusDetyre Statusi { get; set; } = StatusDetyre.E_LIRE;
        public int KohezgjatjaNeMinuta { get; set; } = 5;
    }
}
