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
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["con1"].ConnectionString;

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select id,cname from category order by id";
            con.Open();
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
           
            DataTable tb = new DataTable();
            tb.Load(rd);
            con.Close();
            //Label1.Text = "user name";   

            /*
            DataRow r;
            r = tb.NewRow();
            r["id"] = "1";
            r["cname"] = "錠劑";
            tb.Rows.Add(r);

            
            r = tb.NewRow();
            r["id"] = "2";
            r["cname"] = "丸劑";
            tb.Rows.Add(r);

            r = tb.NewRow();
            r["id"] = "3";
            r["cname"] = "單方";
            tb.Rows.Add(r);

            r = tb.NewRow();
            r["id"] = "4";
            r["cname"] = "複方";
            tb.Rows.Add(r);
            */


            ListView1.DataSource = tb;
            ListView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}