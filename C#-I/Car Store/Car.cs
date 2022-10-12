using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Store
{
    public class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }

        public double Price { get; set; }

        // constructor
        public Car() {

            this.Model = "Unknown model";
            this.Make = "Unknown make";
            this.Price = 0.0;
        }

        public Car(string model, string make, double price)
        {
            this.Model = model;
            this.Make = make;
            this.Price = price;
        }

       
        public override string ToString()
        {
            return Model +" "+ " "+ Make +" $"+ Price;
        }

    }
}
