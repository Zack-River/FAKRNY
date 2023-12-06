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
            Add_Account add = new Add_Account();
            addUserControl(add);
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Tabs_Panel.Controls.Clear();
            Tabs_Panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Add_Acc_Button_Click(object sender, EventArgs e)
        {
            Add_Account add_Account = new Add_Account();
            addUserControl(add_Account);
        }

        private void View_Contents_Button_Click(object sender, EventArgs e)
        {
            Edit_Account edit_Account = new Edit_Account();
            addUserControl(edit_Account);
        }
    }
}
