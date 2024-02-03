using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Tool : Collectable
    {
        public Tool(string description) : base(description)
        {
        }

        public virtual void DoAction()
        {
            Console.WriteLine($"{Description} is displayed");
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            DoAction();
        }
    }
}
