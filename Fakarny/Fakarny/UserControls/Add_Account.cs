using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fakarny.UserControls
{
    public partial class Add_Account : UserControl
    {
        string Program_path, Key;
        Data data;
        bool name = false, id = false, pass = false, phone = false, mail = false;
        bool NameChange = false;
        public Add_Account()
        {
            InitializeComponent();
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
        private void Show_Button_Click(object sender, EventArgs e)
        {
            Move_Panel.Location = new System.Drawing.Point(81, 610);
            panel17.Visible = true;
            show_less_bt.Visible = true;
            Show_Button.Visible = false;
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
            NameChange = true;
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


        private void New_Recovery_Email_Enter(object sender, EventArgs e)
        {
            if (New_Recovery_Email_Textbox.Text == "" || New_Recovery_Email_Textbox.Text == "Recovery Email")
            {
                New_Recovery_Email_Textbox.Text = "";
            }
        }
        private void New_Recovery_Email_Leave(object sender, EventArgs e)
        {
            if (New_Recovery_Email_Textbox.Text == "" || New_Recovery_Email_Textbox.Text == "Recovery Email")
            {

                New_Recovery_Email_Textbox.Text = "Recovery Email";
                New_Recovery_Email_Textbox.ForeColor = Color.FromArgb(149, 149, 149);
                return;

            }
        }
        private void New_Recovery_Email_Changed(object sender, EventArgs e)
        {
            New_Recovery_Email_Textbox.ForeColor = Color.White;
            mail = true;
        }


        private void New_Phone_Textbox_Changed(object sender, EventArgs e)
        {
            New_Phone_Textbox.ForeColor = Color.White;
            phone = true;
        }
        private void New_Phone_Textbox_Enter(object sender, EventArgs e)
        {
            if (New_Phone_Textbox.Text == "" || New_Phone_Textbox.Text == "Phone Number")
            {
                New_Phone_Textbox.Text = "";
            }
        }

        private void show_less_bt_Click_1(object sender, EventArgs e)
        {
            Move_Panel.Location = new System.Drawing.Point(81, 409);
            panel17.Visible = false;
            show_less_bt.Visible = false;
            Show_Button.Visible = true;
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
            Encryptor enc = new Encryptor(Key);
            string en = enc.Path_Safe_Encrypt(New_Name_Textbox.Text);
            enc.IVGenerate();
            if (NameChange)
                File.Delete(Program_Path + "\\" + data.Site_Name + ".txt");
            using (StreamWriter sr = File.CreateText(Program_path + "\\" + en + ".txt"))
            {
                sr.WriteLine(enc.IV);
                sr.WriteLine(enc.Encrypt(New_User_Id_Textbox.Text));
                sr.WriteLine(enc.Encrypt(New_Password_Textbox.Text));
                sr.WriteLine(enc.Encrypt(New_Phone_Textbox.Text));
                sr.WriteLine(enc.Encrypt(New_Recovery_Email_Textbox.Text));
            }
        }

        public void Enter_data()
        {
            NameChange = false;
            New_Name_Textbox.Text = data.Site_Name;
            New_User_Id_Textbox.Text = data.User_Name;
            New_Password_Textbox.Text = data.Password;
            New_Phone_Textbox.Text = data.Phone;
            New_Recovery_Email_Textbox.Text = data.Recovery_Email;
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

        private void Add_Account_Load(object sender, EventArgs e)
        {

        }
    }
}
