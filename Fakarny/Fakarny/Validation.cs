using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fakarny
{
    public partial class Validation : Form
    {
        public string Password;
        public Validation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            Screen screen = Screen.PrimaryScreen;
            this.Location = new Point(screen.WorkingArea.Width / 2 - 156, screen.WorkingArea.Height / 2 - 172 / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Acc_Button_Click(object sender, EventArgs e)
        {
            Password = textBox1.Text;
            this.Close();
        }
    }
}
