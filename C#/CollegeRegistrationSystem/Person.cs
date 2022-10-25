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
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRegistrationSystem
{
    public class Person
    {
        private string _firstname;
        private string _lastname;
        private Address _address;
        private string _email;
        private Schedule Schedule;

        // Overloading constructors
        public Person()
        {
            _firstname = "";
            _lastname = "";
            _address = new Address();
            _email = "";
            Schedule = new Schedule();
        }
        // Constructor with arguments
        public Person(string fn, string ln, Address add, string em)
        {
            this._firstname = fn;
            this._lastname = ln;
            this._address = add;
            this._email = em;
            Schedule = new Schedule();
        }
        // ============ Behaviors ======================
        //Getters and Setters
        public string Firstname { get { return _firstname; }set { _firstname = value; } }
        public string Lastname { get { return _lastname; } set { _lastname = value; } }
        public Address Address { get { return _address; } set { _address = value; } }
        public string Email { get { return _email; } set {_email = value;} }
        
        //  Add Section Method

        public void addSection(Section sec1)
        {
            Schedule.add(sec1);
        }
        //============== toString method =========================

        public Schedule ScheduleRef() { 
            return Schedule;
        }
        public void display()
        {
            System.Diagnostics.Debug.WriteLine("Firstname : " + this._firstname);
            System.Diagnostics.Debug.WriteLine("Lastname  : " + this._lastname);
            _address.display();
            System.Diagnostics.Debug.WriteLine("Email  : " + this._email + "\n");
            Schedule.Display();
        }

        virtual public string toString() {
            return "Firstname" + Firstname + "LastName " + Lastname+ "Address " + Address + "Email " +Email;
        }

    }
}
