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
    public class Course
    {
        // =============================== Properties ====================================
        private string course_id;
        private string courseName;
        private string courseDescription;
        private int credithour;

        // ============================== Constructors ===================================

        public Course()
        {
            course_id = "";
            courseName = "";
            courseDescription = "";
            credithour = 0;
        }
        public Course(string course_id, string courseName, string courseDescription, int credithour)
        {
            this.course_id = course_id;
            this.courseName = courseName;
            this.courseDescription = courseDescription;
            this.credithour = credithour;
        }

        // ========================= Getters and Setters =============================================
        public string CourseId { get { return course_id; } set { course_id = value; } }
        public string CourseName { get { return courseName; } set { courseName = value; } }

        public int Credithour { get { return credithour; } set { credithour = value; } }

        public string CourseDescription { get { return courseDescription; } set { courseDescription = value; } }

        // ================================ Display Method ==========================================

        public void display()
        {
            System.Diagnostics.Debug.WriteLine("Course Id : " + this.course_id);
            System.Diagnostics.Debug.WriteLine("Course Name : " + this.courseName);
            System.Diagnostics.Debug.WriteLine("Description : " + this.courseDescription);
            System.Diagnostics.Debug.WriteLine("Credit Hour : " + this.credithour);

            //Quick note : Console.Writeline was displaying anything to the console, so i've used the command System.Diagnostics.Debug.WriteLine instead.

        }

        // ========================= Database Setup =================================================
        //  Database elements
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand;
        public System.Data.OleDb.OleDbConnection OleDbConnection;
        public string cmd;

        private void DBSetup()
        {
            // ============ DB Setup Function ==============
            OleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand = new System.Data.OleDb.OleDbCommand();
            OleDbConnection = new System.Data.OleDb.OleDbConnection();

            // ========= OleDb Adapter =======
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

        // SelectDb Method
        public void SelectDB(string courseID) {
            
            course_id = courseID;
            
            DBSetup();
            cmd = "SELECT  * FROM courses WHERE courseID = '"+ courseID +"'";
            OleDbDataAdapter.SelectCommand.CommandText = cmd;
            OleDbDataAdapter.SelectCommand.Connection = OleDbConnection;
            System.Diagnostics.Debug.WriteLine(cmd);

            try
            {
                // Open the connection
                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr = OleDbDataAdapter.SelectCommand.ExecuteReader();

                //Reading the data
                dr.Read();
                courseName = dr.GetValue(1) + "";
                courseDescription = dr.GetValue(2) + "";
                Credithour = dr.GetInt32(3);
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

            cmd = "INSERT into Courses values('" + course_id + "', " +
                "'" +courseName + "', " +
                "'" +courseDescription + "', " +
                "'" + credithour + "')";


OleDbDataAdapter.InsertCommand.CommandText = cmd;

            OleDbDataAdapter.InsertCommand.Connection = OleDbConnection;

            Console.WriteLine(cmd);

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

            cmd = "Update Courses set CourseName = '" + courseName +

            "', CourseDescription = '" + courseDescription +
            "', credithour = '" + credithour +

            "' where CourseId = '" + course_id + "'";

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

            cmd = "DELETE FROM Course where CourseID = '" + course_id + "'";

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
