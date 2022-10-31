using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Configuration;

namespace Web1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
       SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=student_Details;Integrated Security=True");



        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Insert_Click(object sender, EventArgs e)
        {

            try
            {
                sqlConnection.Open();
                string insertquery = "Exec Sp_InsertData '" + StudentName.Text + "','" + Studentage.Text + "','" + emailId.Text + "' , '" + password.Text + "','" + contactnumber.Text + "','" + Department.Text + "'";
                SqlCommand cmd = new SqlCommand(insertquery, sqlConnection);
               
                cmd.ExecuteNonQuery();
                Message.Text = "Data Inserted";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        //----------------Update Data------------------------//
        protected void Update_Click(object sender, EventArgs e)
        {

            try
            {
                sqlConnection.Open();
                string updatequery = "SP_updateData'" + StudentName.Text + "','" + Studentage.Text + "','" + emailId.Text + "' , '" + password.Text + "','" + contactnumber.Text + "','" + Department.Text + "'";
                SqlCommand cmd = new SqlCommand(updatequery, sqlConnection);
                
                cmd.ExecuteNonQuery();
                Message.Text = "Data Updated";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        //---------------- Delete Data---------------------//
        protected void Delete_Click(object sender, EventArgs e)
        {

            try
            {
                string deletequery = "SP_deleteData'" + emailId.Text + "','" + password.Text + "'";
                SqlCommand cmd = new SqlCommand(deletequery, sqlConnection);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                Message.Text = "Delete data";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        //----------------Read Data------------------------
        protected void Read_Click(object sender, EventArgs e)
        {

            try
            {
                string Readquery = " select * from [dbo].[Student_details_View];";
                SqlCommand cmd = new SqlCommand(Readquery, sqlConnection);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Message.Text = "Data Display";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}