using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3lab8
{
    public class Ink
    {
        public string Color { get; set; }
        public double Level { get; set; }

        public Ink(string c, double l)
        {
            Color = c;
            Level = l;
        }
    }
}
