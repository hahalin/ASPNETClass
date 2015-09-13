using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WebFormPrj
{
    public partial class category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                lbCategory.Text = "產品大類編號:"+id;

                string constr = ConfigurationManager.ConnectionStrings["con1"].ConnectionString;

                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select id ,cname  from product where cid="+id;
                con.Open();
                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                DataTable tb = new DataTable();
                tb.Load(rd);
                con.Close();

                GridView1.DataSource = tb;
                GridView1.DataBind();

                
            }
                
        }
    }
}