using Fakarny.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fakarny
{
    public partial class FakarnyPage : Form
    {
        string Program_path, File_ext;
        public FakarnyPage()
        {
            InitializeComponent();
        }
        public FakarnyPage(string Program_path, string File_ext)
        {
            this.Program_path = Program_path;
            this.File_ext = File_ext;
            InitializeComponent();
        }

        private void FakarnyPage_Load(object sender, EventArgs e)
        {
            add_Account1.Hide();
            edit_Account1.Show();
            edit_Account1.BringToFront();
        }

        private void View_Contents_Button_Click(object sender, EventArgs e)
        {
            edit_Account1.Hide();
            add_Account1.Show();
            add_Account1.BringToFront();

            Add_Account ac = new Add_Account();
            ac.setdata(RetriveData(Name_Label.Text));
        }

        private void Add_Acc_Button_Click_1(object sender, EventArgs e)
        {
            add_Account1.Hide();
            edit_Account1.Show();
            edit_Account1.BringToFront();
            Add_Account ac = new Add_Account();
            Edit_Account ea = new Edit_Account();
            string site_name = ea.edit_changed();
            ac.setdata(RetriveData(site_name));
        }

        private void edit_Account1_Load(object sender, EventArgs e)
        {

        }

        private void Name_Label_Click(object sender, EventArgs e)
        {

        }

        public string[] RetriveData(string website_name)
        {
            string site_path = Program_path + website_name;
            string[] data = new string[5];
            using (StreamReader reader = File.OpenText( site_path + "\\" + "details" + ".txt"))
            {
                for (int i = 0; i < 4; i++)
                {
                    data[i] = reader.ReadLine();
                }
            }
            using (StreamReader reader = File.OpenText(site_path + "\\" + "pass" + ".txt"))
            { 
                string pass = reader.ReadLine();
                data[5] = pass;
            }
                return data;
        }
    }
}
