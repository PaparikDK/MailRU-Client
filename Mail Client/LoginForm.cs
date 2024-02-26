using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.JavaScript;
using OpenPop.Pop3;

namespace Mail_Client
{
    public partial class LoginForm : Form
    {
        private bool _logined = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        public string getLogin() { return loginBox.Text + mailBox.Text; }
        public string getPass() { return passBox.Text; }
        public bool getLoginStatus() { return _logined; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Pop3Client _client = new Pop3Client())
            {
                try
                {
                    _client.Connect("pop3.rambler.ru", 995, true);
                    _client.Authenticate(loginBox.Text + mailBox.Text, passBox.Text, AuthenticationMethod.UsernameAndPassword);

                    if (_client.Connected == true)
                    {
                        _logined = true;
                        Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("При попытке входа произошла ошибка. Проверьте правильность ввода логина и пароля!", "Ошибка",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
