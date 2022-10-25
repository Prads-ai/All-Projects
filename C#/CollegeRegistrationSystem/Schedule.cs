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
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace CollegeRegistrationSystem
{
    public class Schedule
    {
        public List<Section> courseList = new List<Section>();
        public int count;

        // Overloading Constructors
        public Schedule()
        {
            courseList = new List<Section>();
            count = 0;
        }
        // Behaviors
        public void add(Section c)
        {
            courseList.Add(c);
            count++;
            
        }

        public void drop(int index)
        {
            courseList.RemoveAt(index - 1);
            //count--;
            System.Diagnostics.Debug.WriteLine("This section has been removed");
        }
        // Display Method
        public void Display()
        {

            for (int i = 0; i < courseList.Count; i++)
            {
                count++;
                System.Diagnostics.Debug.WriteLine("====== Schedule {0}", count);
         
                courseList[i].display();
            }
            
        }
        public string toString() {
            for (int i = 0; i < courseList.Count; i++)
            {
                count++;
                System.Diagnostics.Debug.WriteLine("====== Schedule {0}", count);
                 courseList[i].toString();
            }
            return courseList.ToString();
          

        }
    }
}
