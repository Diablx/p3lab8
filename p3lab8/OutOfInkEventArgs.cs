using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3lab8
{
    public class OutOfInkEventArgs
    {
        public OutOfInkEventArgs(string c)
        {
            Color = c;
        }
        public string Color { get; set; }
    }
}
