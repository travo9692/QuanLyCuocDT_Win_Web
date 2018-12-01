using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace QL_cuoc_dt
{
    public partial class QLY_CUOC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
           // Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;
            QLCuocDTEntities db = new QLCuocDTEntities();
            var sdt = TextBox1.Text;
            

            var  ngaybd = TextBox2.Text;
            
            var ngaykt = TextBox3.Text;

           
            var rs_sp = db.hienthi(sdt, Convert.ToDateTime(ngaybd), Convert.ToDateTime(ngaykt));
            GridView2.DataSource = rs_sp.ToList();
            GridView2.DataBind();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = (Calendar1.SelectedDate.ToShortDateString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = (Calendar2.SelectedDate.ToShortDateString());
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           // Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = true;
            QLCuocDTEntities db = new QLCuocDTEntities();
            var sdt = TextBox1.Text;
            var ngaybd = TextBox2.Text;

            var ngaykt = TextBox3.Text;

            var rs_cuoc = db.tinhcuoc(sdt, Convert.ToDateTime(ngaybd), Convert.ToDateTime(ngaykt));
            GridView3.DataSource = rs_cuoc.ToList();
            GridView3.DataBind();


        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}