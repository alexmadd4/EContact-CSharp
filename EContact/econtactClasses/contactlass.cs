using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EContact.econtactClasses
{
    internal class contactClass
    {
        //Getters and Setters 

        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        //Select the data from database.
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Write the sql query.
                string sql = "SELECT * FROM tbl_contact";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dt;

        }

        //Insert the data from the application to the database.

        public bool Insert(contactClass c) 
        {
            //Create a default return type and set to false.

            bool isSuccess = false;

            //Connect database.
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a sql query to insert data.

                string sql = "INSERT INTO tbl_contact (FirstName,LastName,ContactNo,Address,Gender) VALUES (@FirstName,@LastName,@ContactNo,@Address,@Gender)";
                //Create sql command using sql and conn.
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create parametres to add the data.
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                //Connection opens here.
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If query runs successfully then value of the rows will be > 0 ,else will be 0.

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();             
            }
            return isSuccess;

        }
        //Method to update the data in database remotely from the application.

        public bool Update(contactClass c)
        {
            //Create a default return type set to false.
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql updates the data in the database.

                string sql = "UPDATE tbl_contact SET FirstName=@FirstName,LastName=@LastName,ContactNo=@ContactNo,Address=@Address,Gender=@Gender WHERE ContactID=@ContactID";

                //Sql command to insert query.

                SqlCommand cmd = new SqlCommand(sql,conn);

                //Create parametres to add values.
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                //Open database connection.
                conn.Open() ;
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;  
                }
            }
            catch
            {

            }
            finally { conn.Close(); }  


            return isSuccess;
        }

        //Method to delete data from the database.

        public bool Delete(contactClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection (myconnstrng);
            try
            {
                //Delets data from the SQL database.

                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";

                //Creates a SQL command.

                SqlCommand cmd = new SqlCommand (sql,conn);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


    }
}
