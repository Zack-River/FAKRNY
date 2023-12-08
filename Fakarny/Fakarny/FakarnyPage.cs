using Fakarny.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakarny
{
    public partial class FakarnyPage : Form
    {
        public FakarnyPage()
        {
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
        }

        private void Add_Acc_Button_Click_1(object sender, EventArgs e)
        {
            add_Account1.Hide();
            edit_Account1.Show();
            edit_Account1.BringToFront();
        }
    }
}
