using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FAKRNY
{
    public partial class Form1 : Form
    {
        string Program_path = "", File_ext;
        public Form1()
        {
            InitializeComponent();
        }
        private string ComputeHash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                String builder = string.Empty;
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder += bytes[i].ToString("x2");
                }
                return builder;
            }
        }
        private bool CheckViabilty(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (!((s[i] < 58 && s[i] > 47) || (s[i] < 91 && s[i] > 64) || (s[i] < 123 && s[i] > 96) ||
                    s[i] == 45 || s[i] == 95 || s[i] == 32))
                {
                    return false;
                }
            }
            return true;
        }

        private void CreateAccount_Button_Click(object sender, System.EventArgs e)
        {
            if (Sign_Up_UserName_TextBox.Text == "" || Sign_Up_Password_TextBox.Text == "")
            {
                MessageBox.Show("All Fields must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!CheckViabilty(Sign_Up_UserName_TextBox.Text))
            {
                MessageBox.Show("Username should only include numbers, letters, spaces, _ and -", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(Program_path + "\\data"))
            {
                Directory.CreateDirectory(Program_path + "\\data");
            }
            string temp_username = Sign_Up_UserName_TextBox.Text;
            File_ext = Program_path + "\\data\\" + temp_username;
            if (!File.Exists(File_ext + ".txt"))
            {
                Directory.CreateDirectory(File_ext);
                using (StreamWriter sw = File.CreateText(File_ext + ".txt"))
                {
                    sw.WriteLine(ComputeHash(Sign_Up_Password_TextBox.Text));
                }
            }
            else
            {
                MessageBox.Show("This account already exits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Program_path = Directory.GetCurrentDirectory();
            //Program_path = Program_path.Remove(Program_path.IndexOf("bin\\Debug"), 9);
            //MessageBox.Show(Program_path);
        }
    }
}
