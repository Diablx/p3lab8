using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3lab8
{
    class Program
    {
        public static bool printerOk = true;
        static void Main()
        {
            Printer printer = new Printer(22);
            printer.OutOfPaperEvent += OutOfPaperEventHandler_new;
            printer.OutOfInkEvent += OutOfInkEventHandler_new;

            for (int i = 1; i < 20; i++)
            {
                printer.Print(i);
                if (!printerOk)
                {
                    return;
                }
            }
        }

        static void OutOfPaperEventHandler_new(object sender, OutOfPaperEventArgs args)
        {
            Console.WriteLine("Please refill the paper. Continue printing from page: " + args.PageNumber);
            printerOk = false;
        }
        static void OutOfInkEventHandler_new(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine("Please refill ink: " + args.Color);
            printerOk = false;
        }
    }
}