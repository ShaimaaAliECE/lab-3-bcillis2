using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool
    {
        public MagicWand(string description) : base(description)
        {
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
