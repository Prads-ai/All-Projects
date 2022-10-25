/********************************
 C# Programming II - Lab 5
 Title: Course Class
 Date: October 3 , 2022
 Author: Pradsley D'haiti
 I wrote these code myself
******************************/
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeRegistrationSystem
{
    public class Student : Person
    {
        public int id;
        public double gpa;

        public Schedule schedule = new Schedule();

        // =========== Overloading Constructors =============
        public Student() : base()
        {
            id = 0;
            gpa = 0;
        }
        // ================ Constructor with arguments ==================
        public Student(int id, string _firstname, string _lastname, Address _address, string _email, double gpa)
            : base(_firstname, _lastname, _address, _email)
        {

            this.id = id;
            this.gpa = gpa;
        }

        // Getters and Setters
        public int Id { set { id = value; } get { return id; } }
        public double Gpa { set { gpa = value; } get { return gpa; } }

        // ===== Display Method ===================
        public void display()
        {

            System.Diagnostics.Debug.WriteLine("Student id :" + id);
            base.display();
            System.Diagnostics.Debug.WriteLine("GPA : " + gpa);
            schedule.Display();

            //Little note : Console.Writel  ine was displaying anything to the console, so i've used the command System.Diagnostics.Debug.WriteLine instead.
        }

        public override string ToString()
        {

            return "ID : "+ this.id +" FIRSTNAME: "+ Firstname+ " LASTNAME: "+ Lastname+ " GPA: " + this.gpa;
        }

        // ================= Database elements ==================

        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand;
        public System.Data.OleDb.OleDbConnection OleDbConnection;   
        public string cmd;

        public void DBSetup() {
            
            // Database Setup
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

        public void InsertDB() {
             DBSetup();
            cmd = "INSERT INTO Students values( "+ Id +"," +
                "'"+Firstname+"'," +
                "'"+Lastname+"'," +
                "'"+Address.Street+"'," +
                "'"+Address.City+"'," +
                "'"+Address.State+"'," +
                ""+Address.Zip+"," +
                "'"+Email+"'," +
                ""+Gpa+")";
            OleDbDataAdapter.InsertCommand.CommandText = cmd;
            OleDbDataAdapter.InsertCommand.Connection = OleDbConnection;
            System.Diagnostics.Debug.WriteLine(cmd);
            try
            {

                OleDbConnection.Open();

                int n = OleDbDataAdapter.InsertCommand.ExecuteNonQuery();

                if (n == 1)

                    Console.WriteLine("Data Inserted");

                else

                    Console.WriteLine("An error occured");
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                //close the connection

                OleDbConnection.Close();
            }

        }

        public void SelectDB(int studentID) { 

            id = studentID;

            DBSetup();
            cmd = "SELECT * FROM Students WHERE ID = " + studentID + "";
            OleDbDataAdapter.SelectCommand.CommandText = cmd;
            OleDbDataAdapter.SelectCommand.Connection = OleDbConnection;
            System.Diagnostics.Debug.WriteLine(cmd);

            try
            {
                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr = OleDbDataAdapter.SelectCommand.ExecuteReader();

                // Reading Data
                dr.Read();
                id = studentID;

                Firstname = (string)dr.GetValue(1);
                Lastname = (string)dr.GetValue(2);
                string street = (string)dr.GetValue(3);
                string city = (string)dr.GetValue(4);
                string state = (string)dr.GetValue(5);
                int zip = dr.GetInt32(6);
                Address address = new Address(street, city, state, zip);
                base.Address = address;
                Email = (string)dr.GetValue(7);
                Gpa = dr.GetFloat(8);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            finally {
                OleDbConnection.Close();
            }
            getSchedule();
        
        }// End SelectDB

        // Get Schedule Method
        public void getSchedule()
        {

            cmd = "SELECT crn FROM StudentSchedule WHERE StudentID = "+ id +"";
            int crn;
            OleDbDataAdapter.SelectCommand.CommandText = cmd;
            OleDbDataAdapter.SelectCommand.Connection = OleDbConnection;
            System.Diagnostics.Debug.WriteLine(cmd);

            try
            {
                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr = OleDbDataAdapter.SelectCommand.ExecuteReader();
                Section s1;
                while (dr.Read())
                {
                    
                    s1 = new Section();
                    crn = dr.GetInt32(0);
                    s1.SelectDB(crn);
                    schedule.add(s1);
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            finally {
                OleDbConnection.Close();
            }
           
        }

    }
}
