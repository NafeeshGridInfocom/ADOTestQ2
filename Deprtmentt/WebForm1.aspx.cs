using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ba_layer;
using be_layer;

namespace Deprtmentt
{

    public partial class WebForm1 : System.Web.UI.Page
    {

        ta t = new ta();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)//Insert
        {
            bal b = new bal();
            {
                t.id = Convert.ToInt32(TextBox1.Text);
                t.name = TextBox2.Text;
                b.Insertta(t);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)//Update
        {
            bal b = new bal();
            {
                t.id = Convert.ToInt32(TextBox1.Text);
                t.name = TextBox2.Text;
                b.Update_ta(t);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)//Delete
        {
            bal b = new bal();
            {
                t.id = Convert.ToInt32(TextBox1.Text);
                b.Delete_ta(t);
                Label1.Text = "Record deleted";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)//Search
        {
            bal b = new bal();
            {
                t.name = TextBox2.Text;
                b.Search_ta(t);
                Label1.Text = "Record found";
            }
          
        }
    }
}
