using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace discussionform.ConnectionDB
{
    public class DFConnection
    {

            string sqlConnectionStr = "Data Source=LAPTOP-M9MKNCAD\\SQLEXPRESS ;Initial Catalog=DiscussionForm;Integrated Security=True";
            public string InsertUsers(DFModel DFObj)
            {
                SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
                SqlCommand sqlCommandObj = new SqlCommand("insert into Tutorial values(" + DFObj.id + ",'" +DFObj.Name + "','" + DFObj.Emailid + "'," + DFObj.Mobile + ")", sqlConnectionObj);
                sqlConnectionObj.Open();
                sqlCommandObj.ExecuteNonQuery();
                sqlConnectionObj.Close();
                return "Tutorial details saved successfully";
            }
            public void UpdateUsers(DFModel DFObj)
            {

            }
            public void DeleteUsersById(int DFid)
            {

            }
            public string SelectUsers()
            {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Users", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
            public void EditUsersById(int DFid)
            {

            }
        

    }
}