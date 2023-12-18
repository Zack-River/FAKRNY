using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fakarny.UserControls
{
    public partial class Edit_Account : UserControl
    {
        string Program_path, site_name, Key;
        Data data;
        bool name = false, id = false, pass = false, phone = false, email = false;

        public Edit_Account()
        {
            InitializeComponent();
        }

        public string Program_Path
        {
            get
            {
                return this.Program_path;
            }
            set
            {
                this.Program_path = value;
            }
        }
        public string key
        {
            get
            {
                return this.Key;
            }
            set
            {
                this.Key = value;
            }
        }
        private void Show_Button_Click(object sender, EventArgs e)
        {
            Move_Panel.Location = new System.Drawing.Point(81, 560);
            panel17.Location = new System.Drawing.Point(37,413);
            panel17.Visible = true;
            show_less_bt.Visible = true;
            Show_Button.Visible = false;

        }

        private void show_less_bt_Click(object sender, EventArgs e)
        {
            Move_Panel.Location = new System.Drawing.Point(81, 409);
            panel17.Location = new System.Drawing.Point(37, 483);
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


        private void New_Recovery_Email_Textbox_Enter(object sender, EventArgs e)
        {
            if (New_Recovery_Email_Textbox.Text == "" || New_Recovery_Email_Textbox.Text == "Recovery Email")
            {
                New_Recovery_Email_Textbox.Text = "";
            }
        }
        private void New_Recovery_Email_Textbox_Leave(object sender, EventArgs e)
        {
            if (New_Recovery_Email_Textbox.Text == "" || New_Recovery_Email_Textbox.Text == "Recovery Email")
            {
                New_Recovery_Email_Textbox.Text = "Recovery Email";
                New_Recovery_Email_Textbox.ForeColor = Color.FromArgb(149, 149, 149);
                return;
            }
        }
        private void New_Recovery_Email_Textbox_Changed(object sender, EventArgs e)
        {
            New_Recovery_Email_Textbox.ForeColor = Color.White;
            email = true;
        }


        private void New_Phone_Textbox_Changed(object sender, EventArgs e)
        {
            New_Phone_Textbox.ForeColor = Color.White;
            if (show_less_bt.Visible)
                phone = true;
        }
        private void New_Phone_Textbox_Enter(object sender, EventArgs e)
        {
            if (New_Phone_Textbox.Text == "" || New_Phone_Textbox.Text == "Phone Number")
            {
                New_Phone_Textbox.Text = "";
            }
        }
        private void New_Phone_Textbox_Leave(object sender, EventArgs e)
        {
            if (New_Phone_Textbox.Text == "" || New_Phone_Textbox.Text == "Phone Number")
            {
                New_Phone_Textbox.Text = "Phone Number";
                New_Phone_Textbox.ForeColor = Color.FromArgb(149, 149, 149);
                return;
            }
        }

        private void Save_Password_Button_Click(object sender, EventArgs e)
        {
            Account_Saved.Hide();
            bool save = true;
            if(New_Name_Textbox.Text == ""|| New_Name_Textbox.Text == "website or app name")
            {
                invalid_name.Show();
                save = false;
            }
            else
                invalid_id.Hide();

            if (New_User_Id_Textbox.Text == "" || New_User_Id_Textbox.Text == "username or email id")
            {
                invalid_id.Show();
                save = false;
            }
            else
                invalid_name.Hide();

            if (New_Password_Textbox.Text == "")
            {
                invalid_pass.Show();
                save = false;
            }
            else
                invalid_pass.Hide();

            if ((New_Phone_Textbox.Text.Length > 15 || New_Phone_Textbox.Text.Length < 10 && New_Phone_Textbox.Text.Length != 0) && New_Phone_Textbox.Visible == true)
            {
                invalid_phone.Show();
                save = false;
            }
            else
            {
                invalid_phone.Hide();
                New_Phone_Textbox.ForeColor = Color.FromArgb(149, 149, 149);
            }
            if (save)
            {
                Encryptor enc = new Encryptor(Key);
                string en = enc.Path_Safe_Encrypt(New_Name_Textbox.Text);
                enc.IVGenerate();
                //string hashen = SignUp.ComputeHash(en);
                //using (StreamWriter sr = File.AppendText(Program_path + "\\Index.txt"))
                //{
                //    sr.WriteLine(en);
                //    sr.WriteLine(hashen);
                //}
                using (StreamWriter sr = File.CreateText(Program_path + "\\" + en + ".txt"))
                {
                    sr.WriteLine(enc.IV);
                    sr.WriteLine(enc.Encrypt(New_User_Id_Textbox.Text));
                    sr.WriteLine(enc.Encrypt(New_Password_Textbox.Text));
                    sr.WriteLine(enc.Encrypt(New_Phone_Textbox.Text));
                    sr.WriteLine(enc.Encrypt(New_Recovery_Email_Textbox.Text));
                }
                New_Phone_Textbox.Text = "Phone Number";
                New_User_Id_Textbox.Text = "username or email id";
                New_Phone_Textbox.Text = "Phone Number";
                Account_Saved.Show();
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

        public Data Data_Set
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

    }

}
