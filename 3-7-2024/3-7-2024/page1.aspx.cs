using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace _3_7_2024
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string name= TextBox1.Text;
            Label1.Text = name;
            string email = TextBox2.Text;
            Label2.Text = email;
            string id = TextBox3.Text;
            Label3.Text = id;

            string discreption = TextArea1.Text;
            Label6.Text = discreption;





        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Label4.Text = RadioButton1.Text;
            }
            else {
                Label4.Text = RadioButton2.Text;
            }

           
        }

        protected void CheckBox_checkedChanged(object sender, EventArgs e)
        {
            string selectedValue = " ";
            if (CheckBox1.Checked)
            {
                selectedValue += CheckBox1.Text + "\n";
            }
             if (CheckBox2.Checked)
            {
                selectedValue += CheckBox2.Text + "\n";

            }
            if(CheckBox3.Checked)
            {
                selectedValue +=CheckBox3.Text + "\n";
            }
            Label5.Text = selectedValue;
        }
    }
}