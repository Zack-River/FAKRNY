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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Fakarny.UserControls
{
    public partial class Add_Account : UserControl
    {
        string Program_path;
        bool name=false, id=false, pass=false, phone=false, mail=false;
        
        public Add_Account()
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
            name = true;
        }
      

        private void New_Password_Textbox_Enter(object sender, EventArgs e)
        {
            if (New_Name_Textbox.Text == "")
            {
                New_Password_Textbox.Text = "";
            }
        }
        private void New_Password_Textbox_Leave(object sender, EventArgs e)
        {
            if (New_Password_Textbox.Text == "")
            {
                New_Password_Textbox.ForeColor = Color.FromArgb(149, 149, 149);
                return;
            }
        }
        private void New_Password_Textbox_Changed(object sender, EventArgs e)
        {
            New_Password_Textbox.ForeColor = Color.White;
            pass = true;
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
            mail = true;
        }


        private void textBox2_Changed(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.White;
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
            if (name == id == phone == pass == mail== true)
            {
                string[] new_data = { New_Name_Textbox.Text , New_User_Id_Textbox.Text, textBox2.Text, textBox1.Text, New_Password_Textbox.Text };

                if(Directory.Exists(Program_path + New_Name_Textbox.Text + "\\data"))
                {
                    using (StreamWriter sw = new StreamWriter(Program_path + New_Name_Textbox.Text + "\\data", false))
                    {
                        for (int i = 0; i < new_data.Length; i++)
                        {
                            sw.WriteLine(new_data[i]);
                        }  
                    }
                }
            }
            else
            {
                MessageBox.Show("you've not changed anything!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void setdata(string[] Data)
        {
            string[] data = Data;
            
            New_Name_Textbox.Text = data[0];
            New_User_Id_Textbox.Text= data[1];
            textBox2.Text= data[2];
            textBox1.Text= data[3];
            New_Password_Textbox.Text = data[4];
        }

        private void Add_Account_Load(object sender, EventArgs e)
        {

        }
    }
}
