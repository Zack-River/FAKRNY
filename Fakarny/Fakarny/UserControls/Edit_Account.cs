using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Fakarny.UserControls
{
    public partial class Edit_Account : UserControl
    {
        string Program_path, site_name;
        bool name=false, id=false, pass=false, phone=false, email=false;
        
        public Edit_Account()
        {
            InitializeComponent();
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            Move_Panel.Location = new System.Drawing.Point(81, 610);
            panel17.Visible = true;
            show_less_bt.Visible = true;
            Show_Button.Visible = false;

        }

        private void show_less_bt_Click(object sender, EventArgs e)
        {
            Move_Panel.Location = new System.Drawing.Point(81, 409);
            panel17.Visible = false;
            show_less_bt.Visible = false;
            Show_Button.Visible = true;
        }



        private void New_Name_Textbox_Enter(object sender, EventArgs e)
        {
            if (New_Name_Textbox.Text == "" || New_Name_Textbox.Text == "website or app name")
            {
                New_Name_Textbox.Text = "";
            }
        }
        private void New_Name_Textbox_Leave(object sender, EventArgs e)
        {
            if (New_Name_Textbox.Text == "" || New_Name_Textbox.Text == "website or app name")
            {
                New_Name_Textbox.Text = "website or app name";
                New_Name_Textbox.ForeColor = Color.FromArgb(149, 149, 149);
                return;
            }
        }
        private void New_Name_Textbox_Changed(object sender, EventArgs e)
        {
            New_Name_Textbox.ForeColor = Color.White;
            site_name = New_Name_Textbox.Text;
            name = true;
        }

       

        private void New_User_Id_Textbox_Enter(object sender, EventArgs e)
        {
            if (New_User_Id_Textbox.Text == "" || New_User_Id_Textbox.Text == "username or email id")
            {
                New_User_Id_Textbox.Text = "";
            }
        }
        private void New_User_Id_Textbox_Changed(object sender, EventArgs e)
        {
            New_User_Id_Textbox.ForeColor = Color.White;
            id = true;
        }
        private void New_User_Id_Textbox_Leave(object sender, EventArgs e)
        {
            if (New_User_Id_Textbox.Text == "" || New_User_Id_Textbox.Text == "username or email id")
            {
                New_User_Id_Textbox.Text = "username or email id";
                New_User_Id_Textbox.ForeColor = Color.FromArgb(149, 149, 149);
                return;
            }
        }


        private void New_Password_Textbox_Enter(object sender, EventArgs e)
        {
            if (New_Password_Textbox.Text == "")
            {
                New_Password_Textbox.Text = "";
            }
        }
        private void New_Password_Textbox_Leave(object sender, EventArgs e)
        {
            if (New_Password_Textbox.Text == "")
            {

                New_Password_Textbox.Text = "";
                New_Password_Textbox.ForeColor = Color.FromArgb(149, 149, 149);
                return;

            }
        }
        private void New_Password_Textbox_Changed(object sender, EventArgs e)
        {
            New_Password_Textbox.ForeColor = Color.White;
            pass = true;

        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Recovery Email")
            {
                textBox1.Text = "";
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Recovery Email")
            {
                textBox1.Text = "Recovery Email";
                textBox1.ForeColor = Color.FromArgb(149, 149, 149);
                return;
            }
        }
        private void textBox1_Changed(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
            email = true;
        }


        private void textBox2_Changed(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.White;
            if (show_less_bt.Visible)
                phone = true;
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == "Phone Number")
            {
                textBox2.Text = "";
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == "Phone Number")
            {
                textBox2.Text = "Phone Number";
                textBox2.ForeColor = Color.FromArgb(149, 149, 149);
                return;
            }
        }

        private void Save_Password_Button_Click(object sender, EventArgs e)
        {

            if (validation())
            {
                string site_name = Program_path + New_Name_Textbox.Text + "\\data";
                string pass = site_name + "\\important";
                Directory.CreateDirectory(pass);
                Directory.CreateDirectory(site_name);
                using (StreamWriter sw = File.CreateText(pass + "\\" + "pass" + ".txt"))
                {
                    sw.Write(New_Password_Textbox.Text);
                }
                using (StreamWriter sw = File.CreateText(site_name + "\\" + "details" + ".txt"))
                {
                    sw.WriteLine(New_Name_Textbox.Text);
                    sw.WriteLine(New_User_Id_Textbox.Text);
                    sw.WriteLine(textBox2.Text);
                    sw.WriteLine(textBox1.Text);
                }
            }

            else
            {
                validation();
            }
        }

        public bool validation()
        {
            if (name)
            {
                invalid_name.Visible = false;
            }
            else
            {
                invalid_name.Visible = true;
            }
            if (id)
            {
                invalid_id.Visible = false;
            }
            else
            {
                invalid_id.Visible = true;
            }
            if (pass)
            {
                invalid_pass.Visible = false;
            }
            else
            {
                invalid_pass.Visible = true;
            }
            if (email)
            {
                invalid_mail.Visible = false;
            }
            else
            {
                invalid_mail.Visible = true;
            }
            if (phone)
            {
                invalid_phone.Visible = false;
            }
            else
            {
                invalid_phone.Visible = true;
            }
            return name && pass && id;

        }

        public string edit_changed()
        {
            return site_name;
        }

        private void Edit_Account_Load(object sender, EventArgs e)
        {

        }

        
    }

}
