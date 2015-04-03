using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CourseWorkApplication
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if ((bool)workersTableAdapter.CheckLogin(loginTextBox.Text) || loginTextBox.Text == "" || loginTextBox.Text.Length > 20)
                MessageBox.Show("Такий логін вже існує, або не вірно введено дані");
            else if (passTextBox.Text == "" || (passTextBox.Text.Length < 5 && passTextBox.Text.Length > 16))
                MessageBox.Show("Пароль має бути не менше 5 і не більше 16 символів!");
            else 
            {
                string hash = Hash.GetMd5Hash(passTextBox.Text);
                workersTableAdapter.InsertQuery(loginTextBox.Text, Hash.GetMd5Hash(passTextBox.Text), postComboBox.Text);
                this.Close();
            }
        }
    }

    public static class Hash
    {
        public static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public static bool VerifyMd5Hash(string input, string hash)
        {
            MD5 md5Hash = MD5.Create();
            // Hash the input.
            string hashOfInput = GetMd5Hash(input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
