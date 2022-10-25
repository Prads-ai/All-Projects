/********************************
 C# Programming II - Lab 5
 Title: Course Class
 Date: October 3 , 2022
 Author: Pradsley D'haiti
 I wrote these code myself
******************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRegistrationSystem
{
    public class Address
    {
        string street;
        string city;
        string state;
        int zip;

        // ============= Overloading constructors =========================
        //Empty Constructor
        public Address()
        {
            street = "";
            city = "";
            state = "";
            zip = 0;
        }
        // Constructor with arguments
        public Address(string street, string city, string state, int zip)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }
        // ================= Behaviors ===================== 
        //Getters and Setters
        public string Street { get { return street; } set { street = value; } }
        public string City { get { return city; } set { city = value; } }
        public string State { get { return state; } set { state = value; } }
        public int Zip { get { return zip; } set { zip = value; } }

        // ==================== Display Method ============================================

        public void display()
        {
            System.Diagnostics.Debug.WriteLine("Street : " + this.street);
            System.Diagnostics.Debug.WriteLine("City : " + this.city);
            System.Diagnostics.Debug.WriteLine("State : " + this.state);
            System.Diagnostics.Debug.WriteLine("Zip Code : " + this.zip);

            //Little note : Console.Writeline was displaying anything to the console, so i've used the command System.Diagnostics.Debug.WriteLine instead
        }
        public override string ToString()
        {
            return "Street " +Street+ " City "+ City+" State "+State+" Zip "+ Zip;
        }
    }
}
