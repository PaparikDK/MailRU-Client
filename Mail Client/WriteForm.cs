using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mail_Client
{
    public partial class WriteForm : Form
    {
        private string _login, _password;

        public WriteForm()
        {
            InitializeComponent();
        }

        public WriteForm(string login, string password)
        {
            InitializeComponent();
            _login = login;
            _password = password;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (mailBox1.Text == "" || mailBox2.Text == "")
            {
                MessageBox.Show("Полям темы и получателя должны быть заполнены!", "Ошибка",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Mail_Send() == true)
                {
                    MessageBox.Show("Письмо успешно отправлено!", "Отправка",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private bool Mail_Send()
        {
            try
            {
                using (var client = new SmtpClient("smtp.mail.ru", 25))
                {
                    client.Credentials = new NetworkCredential(_login, _password);
                    client.EnableSsl = true; // Включите SSL, если требуется
                    client.Timeout = 5000;

                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(_login);
                    mailMessage.To.Add(mailBox1.Text);
                    mailMessage.Subject = mailBox2.Text;
                    mailMessage.Body = mailTextBox.Text;

                    if (fileLabel.Text != ". . .")
                        mailMessage.Attachments.Add(new Attachment(fileLabel.Text.ToString()));

                    client.Send(mailMessage);

                    return true;
                }
            }
            catch (SmtpFailedRecipientException)
            {
                MessageBox.Show("Письмо не отправлено! Такого почтового адреса получателя не существует либо он недоступен.", "Ошибка",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Письмо не отправлено! Такого почтового адреса получателя не существует либо он недоступен.", "Ошибка",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Письмо не отправлено! Произошла непредвиденная ошибка: " + ex, "Ошибка",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void btnAddAtch_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            fileLabel.Text = openFileDialog.FileName;
        }
    }
}
