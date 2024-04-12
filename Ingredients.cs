using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Poe
{
    class Ingredients
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }

        public Ingredients(string name, double quantity, string unitOfMeasurement)
        {
            Name = name;
            Quantity = quantity;
            UnitOfMeasurement = unitOfMeasurement;
        }

        public void Display()
        {
            Console.WriteLine($"{Name} - {Quantity} {UnitOfMeasurement}");
        }
    }
}
      
 
