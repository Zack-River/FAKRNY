using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Fakarny
{
    public partial class FakarnyPage : Form
    {
        string Program_path = "1", Key, temp;
        string[] Names_before_Clean, Names;
        public FakarnyPage(string Program_path, string Key)
        {
            this.Program_path = Program_path;
            this.Key = Key;
            InitializeComponent();
            edit_Account1.Program_Path = Program_path;
            edit_Account1.key = Key;
        }
        private void FakarnyPage_Load(object sender, EventArgs e)
        {
            add_Account1.Hide();
            edit_Account1.Show();
            edit_Account1.BringToFront();

            Names_before_Clean = Directory.GetFiles(Program_path, "*.txt");
            Names = new string[Names_before_Clean.Length];
            Encryptor enc = new Encryptor(Key);
            for (int i = 0; i < Names_before_Clean.Length; i++)
            {
                temp = Names_before_Clean[i].Substring(Program_path.Length + 1);
                temp = temp.Remove(temp.Length - 4);
                Names[i] = enc.Path_Safe_Decrypt(temp);
            }
            Show_Name_Combobox.Items.AddRange(Names);
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

        private void edit_Account1_Load(object sender, EventArgs e)
        {

        }

        private void add_Account1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Name_Label_Click(object sender, EventArgs e)
        {

        }
    }
    #region Encryptor
    public class Encryptor
    {
        private byte[] iv = { 196, 105, 10, 83, 65, 63, 165, 46, 109, 166, 141, 17, 94, 109, 146, 235 };
        private byte[] KeyByte;
        private byte[] Encrypted;
        private Aes aes = Aes.Create();

        public Encryptor(string Key)
        {
            for (int i = Key.Length; i < 32; i++)
            {
                Key += '0';
            }
            this.KeyByte = Encoding.UTF8.GetBytes(Key);
            aes.Mode = CipherMode.CBC;
        }

        public Encryptor(string Key, string IV)
        {
            this.iv = Convert.FromBase64String(IV);
            for (int i = Key.Length; i < 32; i++)
            {
                Key += '0';
            }
            this.KeyByte = Encoding.UTF8.GetBytes(Key);
            aes.Mode = CipherMode.CBC;
        }

        public string Encrypt(string plaintext)
        {
            using (ICryptoTransform encryptor = aes.CreateEncryptor(KeyByte, iv))
            {
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
                Encrypted = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
                return Convert.ToBase64String(Encrypted);
            }
        }

        public string Decrypt(string Encrypted)
        {
            byte[] encbytes = Convert.FromBase64String(Encrypted);
            using (ICryptoTransform decryptor = aes.CreateDecryptor(KeyByte, iv))
            {
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encbytes, 0, encbytes.Length);
                string decryptedText = Convert.ToBase64String(decryptedBytes);
                return decryptedText;
            }
        }

        public string Key
        {
            get
            {
                return Convert.ToBase64String(KeyByte);
            }

            set
            {
                for (int i = value.Length; i < 32; i++)
                {
                    value += '0';
                }
                KeyByte = Encoding.UTF8.GetBytes(value);
            }
        }

        public void IVGenerate()
        {
            aes.GenerateIV();
            IV = Convert.ToBase64String(aes.IV);
        }
        public string IV
        {
            get
            {
                return Convert.ToBase64String(iv);
            }

            set
            {
                Array.Copy(Convert.FromBase64String(value), iv, 16);
            }
        }

        public string Path_Safe_Encrypt(string plaintext)
        {
            using (ICryptoTransform encryptor = aes.CreateEncryptor(KeyByte, iv))
            {
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
                Encrypted = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
                string s = Convert.ToBase64String(Encrypted);
                Make_Safe(ref s);
                return s;
            }
        }

        private void Make_Safe(ref string s)
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '/')
                    sb[i] = '_';
            }
            s = sb.ToString();
        }

        private void Make_UnSafe(ref string s)
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '_')
                    sb[i] = '/';
            }
            s = sb.ToString();
        }

        public string Path_Safe_Decrypt(string Encrypted)
        {
            Make_UnSafe(ref Encrypted);
            byte[] encbytes = Convert.FromBase64String(Encrypted);
            using (ICryptoTransform decryptor = aes.CreateDecryptor(KeyByte, iv))
            {
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encbytes, 0, encbytes.Length);
                string decryptedText = Convert.ToBase64String(decryptedBytes);
                return decryptedText;
            }
        }

    }
    #endregion
}
