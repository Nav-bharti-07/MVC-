using MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC.Repository
{
    public class CustomerRepository
    {
        public string CreateCustomer(string name , string email , long phone , string address)
        {
            string cstr = "Data Source=LAPTOP-NI63EFIF;database=MVC;Integrated Security=SSPI";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(cstr);
                SqlCommand cmd = new SqlCommand("SP_Create_Customer_Details", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Customer_Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Customer_Address", address);

                sqlConnection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}