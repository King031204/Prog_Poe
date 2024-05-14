using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prog_Poe
{
    class Ingredients
    {
        public string Name;
        public double Quantity;
        public string UnitOfMeasurement;
        public int Calories;
        public string FoodGroups;

        public Ingredients(string name, double quantity, string unitOfMeasurement, int calories, string foodGroups)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.UnitOfMeasurement = unitOfMeasurement;
            this.Calories = calories;
            this.FoodGroups = foodGroups;    
        }

        public void ScaleQuantity(double scaleFactor)
        {
            Quantity *= scaleFactor;
        }

        public void ResetQuantity()
        {
            // Implement your logic to reset the quantity back to the original value
        }

        public override string ToString()
        {
            return Name + ": " + Quantity + " " + UnitOfMeasurement + " " + Calories + " " + FoodGroups;
        }
    }
}
      
 
