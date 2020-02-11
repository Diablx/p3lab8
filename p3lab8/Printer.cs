using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3lab8
{
    public class Printer
    {
        public event EventHandler<OutOfPaperEventArgs> OutOfPaperEvent;
        public event EventHandler<OutOfInkEventArgs> OutOfInkEvent;
        private int PaperCount { get; set; }

        private readonly List<Ink> Inks;
        private readonly Random Random = new Random();
        public void Print(int pageNumber)
        {
            if (PaperCount == 0)
            {
                OutOfPaperEvent?.Invoke(this, new OutOfPaperEventArgs(pageNumber));
                return;
            }
            else
            {
                foreach (var ink in Inks)
                {
                    if (ink.Level <= 0)
                    {
                        OutOfInkEvent.Invoke(this, new OutOfInkEventArgs(ink.Color));
                        return;
                    }
                }

                Console.WriteLine("Printing");
                --PaperCount;
                foreach (var ink in Inks)
                {
                    ink.Level -= Random.NextDouble();
                }
            }
        }
        private void OutOfPaperEventHandler(object sender, OutOfPaperEventArgs args)
        {
            Console.WriteLine("[Printer log] Out of paper");
        }
        private void OutOfInkEventHandler(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine("[Printer log] Out of ink " + args.Color);
        }
        public Printer(int paperCount) : this()
        {
            PaperCount = paperCount;
        }
        public Printer()
        {
            OutOfPaperEvent += OutOfPaperEventHandler;
            OutOfInkEvent += OutOfInkEventHandler;
            Inks = new List<Ink>{
                new Ink("Black",1),
                new Ink("Green",1),
                new Ink("Blue",1),
                new Ink("Red",1)
            };
        }
    }
}
