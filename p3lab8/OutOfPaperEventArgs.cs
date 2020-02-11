using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3lab8
{
    public class OutOfPaperEventArgs : EventArgs
    {
        public int PageNumber { get; set; }
        public OutOfPaperEventArgs(int pgnum)
        {
            PageNumber = pgnum;
        }
    }
}
