using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_7_2024
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected double summ()
        {
            double num1=Convert.ToDouble(TextBox1.Text);
            double num2=Convert.ToDouble(TextBox2.Text);
            return num1 + num2;
        }
        protected double sub()
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            return num1 - num2;
        }

        protected double multi()
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            return num1 * num2;
        }
        protected double div()
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            return num1 /num2;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text=Convert.ToString(summ());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Text = Convert.ToString(sub());
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox3.Text = Convert.ToString(multi());
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox3.Text = Convert.ToString(div());
        }
    }
}