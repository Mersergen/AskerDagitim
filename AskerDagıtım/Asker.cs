using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskerDagıtım
{
    internal class Asker
    {
        public string Kisi { get; set; }
        public string Sehir { get; set; }

        public override string ToString()
        {
            return this.Kisi + "-->" + this.Sehir;
        }
    }
}
