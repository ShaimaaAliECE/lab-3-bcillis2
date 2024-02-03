using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }

        public Collectable()
        {
        }

        public Collectable(string description)
        {
            Description = description;
        }

        public virtual void AddMe(List<Collectable> collection)
        {
                collection.Add(this);
                Console.WriteLine($"{Description} Collected, Congrats!!!!");
        
        }

        public virtual void Display()
        {
            Console.WriteLine($"{Description} is displayed.");
        }
    }
}
