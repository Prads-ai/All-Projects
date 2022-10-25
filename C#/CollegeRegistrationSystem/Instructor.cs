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
using System.Text;
using System.Threading.Tasks;

namespace CollegeRegistrationSystem
{
    public class Instructor : Person
    {
        private int id;
        private string office;

        // ============ Overloading constructor ==========
        public Instructor() : base()
        {
            id = 0;
            office = "";
        }
        // ============== Constructor with arguments =================
        public Instructor(int id, string _firstname, string _lastname, Address address, string office, string email)
            : base(_firstname, _lastname, address, email)
        {

            this.id = id;
            this.office = office;

        }
        // =============== Behaviors ====================
        //Getters and Setters

        public int Id { get; set; }
        public string Office { get; set; }

        //display method

        public void display() {
            System.Diagnostics.Debug.WriteLine("id : " + id);
            base.display();
            System.Diagnostics.Debug.WriteLine("Office" + office);
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
        public void DBSetup() {


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

        public void SelectDB(int ID) {
            id = ID;
            DBSetup();
            cmd = "SELECT  * FROM Instructors WHERE Id = " + ID + "";
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
                id = ID;
                Firstname = (string)dr.GetValue(1);
                Lastname = (string)dr.GetValue(2);
                string street = (string)dr.GetValue(3);
                string city = (string)dr.GetValue(4);
                string state = (string)dr.GetValue(5);
                int zip = dr.GetInt32(6);
                Address a1 = new Address(street, city, state, zip);
                base.Address = a1;
                office = (string)dr.GetValue(7);
                Email = (string)dr.GetValue(8);

                //Address add = new Address(street,city,state,zip);


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            finally {
                OleDbConnection.Close();
            }
            
        }
        public void insertDB() //Insert Method

        {

            // +++++++++++++++++++++++++++ INSERT +++++++++++++++++++++++++++++++

            DBSetup();
         
            cmd = "INSERT into Instructors values(" +

            "" + id + "," +
            
            "'" + Firstname + "', " +

            "'" + Lastname + "', " +
            
            "'" + Address.Street + "', " +
            
            "'" + Address.City + "', " +

            "'" + Address.State + "', " +

            "'" + Address.Zip + "', " +

            "'" + office + "', " +

            "'" + Email + "')";

           

            OleDbDataAdapter.InsertCommand.CommandText = cmd;
            OleDbDataAdapter.InsertCommand.Connection = OleDbConnection;

            System.Diagnostics.Debug.WriteLine(cmd);

            try

            {

                OleDbConnection.Open();

                int n = OleDbDataAdapter.InsertCommand.ExecuteNonQuery();

                if (n == 1)

                    System.Diagnostics.Debug.WriteLine("Data Inserted");

                else

                    System.Diagnostics.Debug.WriteLine("An error occured");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex);

            }

            finally

            {

                OleDbConnection.Close();

            }

        } //end InsertDB()

        public void updateDB() //Update Method

        {

            //++++++++++++++++++++++++++ UPDATE +++++++++++++++++++++++++

            cmd = "Update Instructors set Firstname = '" + Firstname +

            "', Lastname = '" + Lastname +
            "', Street = '" + Address.Street +
            "', City = '" + Address.City +
            "', State = '" + Address.State +
            "', Zip = '" + Address.Zip +
            "', Email = '" + Email +

            "', Office = '" + office +

            "' where ID = '" + id + "'";

            OleDbDataAdapter.UpdateCommand.CommandText = cmd;

            OleDbDataAdapter.UpdateCommand.Connection = OleDbConnection;

            Console.WriteLine(cmd);

            try

            {

                OleDbConnection.Open();

                int n = OleDbDataAdapter.UpdateCommand.ExecuteNonQuery();

                if (n == 1)

                    Console.WriteLine("Data Updated");

                else

                    Console.WriteLine("An error occured");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex);

            }

            finally

            {

                OleDbConnection.Close();

            }

        } //end UpdateDB()

        public void deleteDB() //Delete Method

        {

            //++++++++++++++++++++++++++ DELETE +++++++++++++++++++++++++

            cmd = "DELETE FROM instructors where id = '" + id + "'";

            OleDbDataAdapter.DeleteCommand.CommandText = cmd;

            OleDbDataAdapter.DeleteCommand.Connection = OleDbConnection;

            Console.WriteLine(cmd);

            try

            {

                OleDbConnection.Open();

                int n = OleDbDataAdapter.DeleteCommand.ExecuteNonQuery();

                if (n == 1)

                    Console.WriteLine("Successfully Deleted");

                else

                    Console.WriteLine("An Error has occured");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex);

            }

            finally

            {

                OleDbConnection.Close();

            }

        } //end DelectDB()


    }
}
