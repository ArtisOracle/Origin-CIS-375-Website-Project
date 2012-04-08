﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace StudentAlumniTrackingTool.WebPages
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Assure user is admin
            if (User.Identity.Name.Equals("admin") && (ClientQueryString != null) )
                Console.Write("admin");
            else
                Response.Redirect("Error.aspx");
        }

        protected void DeleteUser(object sender, CommandEventArgs e)
        {
            // SQL query to delete user
            SqlCommand sqlComm = new SqlCommand();
            SqlConnection sqlCon = new SqlConnection();
            string clientQueryStr = ClientQueryString;

            sqlComm = new SqlCommand("");
            // Delete user
            Response.Redirect("Success.aspx");
        }

        protected void SaveUser(object sender, CommandEventArgs e)
        {
            Response.Redirect("../Default.aspx");
        }
    }
}