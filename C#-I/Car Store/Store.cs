using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Store
{
    public class Store
    {
       public List<Car>store = new List<Car>();
       public List<Car>shopping = new List<Car>();
       public static int count;

        public Store() { 
            store = new List<Car> ();
            shopping = new List<Car>();
            count = 0;
        }
        // Getters and Setters 
        public List<Car> getstore { set; get;}
        public List<Car> getshopping { set; get;}

        public double Checkout() {
            double total = 0;

            foreach (var car in store)
            {
                total = total + car.Price;
            }
            return total;
        }
        
    }
}
