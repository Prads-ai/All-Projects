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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CollegeRegistrationSystem
{
    public class Section
    {
        private int crn;
        private string course_id;
        private string timeday;
        private string roomNo;
        private int instructor_id;

        // ============ Constructor ================

        public Section()
        {
            crn = 0;
            course_id = "";
            roomNo = "";
            instructor_id = 0;
        }
        // ========== Constructor with arguments
        public Section(int crn, string course_id, string timeday, string roomNo, int instructor)
        {
            this.crn = crn;
            this.course_id = course_id;
            this.roomNo = roomNo;
            this.instructor_id = instructor;
            this.timeday = timeday;
        }
        // ========= Behaviors =====================
        // Getters and Setters
        public int Crn { get { return crn; } set { crn = value; } }
        public string CourseId { get { return course_id; } set { course_id = value; } }
        public string TimeDay { get { return timeday; } set { timeday = value; } }
        public string RoomNo { get { return roomNo; } set { roomNo = value;} }
        public int Instructor { get { return instructor_id; } set { instructor_id = value; } }

        // Display Method
        public void display()
        {
            System.Diagnostics.Debug.WriteLine("Crn: " + this.crn);
            System.Diagnostics.Debug.WriteLine("Course Id :" + this.course_id);
            System.Diagnostics.Debug.WriteLine("Time Day: " + this.timeday);
            System.Diagnostics.Debug.WriteLine("Instructor: " + this.instructor_id);
        }
         public string toString() {
            return "courseID : " + course_id;
        }
        // ==================== Database Elements =====================

        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand;
        public System.Data.OleDb.OleDbConnection OleDbConnection;
        public string cmd;

        // Database Setup
        public void DBSetup()
        {


            // ============ DB Setup Function ==============
            OleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand = new System.Data.OleDb.OleDbCommand();
            OleDbConnection = new System.Data.OleDb.OleDbConnection();

            // ============== OleDb Adapter =================

            OleDbDataAdapter.SelectCommand = OleDbSelectCommand;
            OleDbDataAdapter.InsertCommand = OleDbInsertCommand;
            OleDbDataAdapter.UpdateCommand = OleDbUpdateCommand;
            OleDbDataAdapter.DeleteCommand = OleDbDeleteCommand;

            // Connection String
            OleDbConnection.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +
           "ocking Mode=1;Data Source=C:\\Users\\pach3\\Downloads\\RegistrationDB.mdb;J" +
           "et OLEDB:Engine Type=5;Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:System datab" +
           "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
           "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
           "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
           "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
        }
        public void SelectDB(int cRn)
        {
            crn = cRn;
            DBSetup();
            cmd = "SELECT  * FROM Sections WHERE crn = " + cRn + "";
            OleDbDataAdapter.SelectCommand.CommandText = cmd;
            OleDbDataAdapter.SelectCommand.Connection = OleDbConnection;
            System.Diagnostics.Debug.WriteLine(cmd);

            try
            {
                //Open the connection
                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr = OleDbDataAdapter.SelectCommand.ExecuteReader();

                //Reading the data
                dr.Read();
                crn = cRn;
                CourseId = (string)dr.GetValue(1);
                TimeDay = (string)dr.GetValue(2);
                RoomNo = (string)dr.GetValue(3);
                Instructor = dr.GetInt32(4);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            finally
            {
                OleDbConnection.Close();
            }

        }

    }

}
