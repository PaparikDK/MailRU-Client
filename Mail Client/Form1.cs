using OpenPop.Pop3;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace Mail_Client
{
    public partial class MainForm : Form
    {
        private string _login, _password;

        private List<OpenPop.Mime.Message> allMessages;
        private int _messageCount = 0;

        private Thread mailThread;

        WebBrowser webBrowser = new WebBrowser();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();

            if (form.getLoginStatus() == true)
            {
                _login = form.getLogin();
                _password = form.getPass();
                Show();

                listView.Items.Clear();

                mailThread = new Thread(Mail_LoadList);
                mailThread.IsBackground = true;
                mailThread.Start();
            }

            webBrowser.Dock = DockStyle.Fill;
            mailPanel.Controls.Add(webBrowser);
        }

        private void Mail_LoadList()
        {
            using (OpenPop.Pop3.Pop3Client client = new Pop3Client())
            {
                // Подключение к серверу
                client.Connect("pop.rambler.ru", 995, true);

                // Аутентификация (проверка логина и пароля)
                client.Authenticate(_login, _password, AuthenticationMethod.UsernameAndPassword);

                statusLabel1.Text = "Получение писем. . .";
                if (client.Connected)
                {
                    _messageCount = client.GetMessageCount();

                    allMessages = new List<OpenPop.Mime.Message>(_messageCount);
                    listView.Invoke(new Action(() =>
                    {
                        listView.Items.Clear();
                    }));

                    for (int i = _messageCount; i > 0; i--)
                    {
                        OpenPop.Mime.Message message = client.GetMessage(i);
                        allMessages.Add(client.GetMessage(i));

                        string subject = message.Headers.Subject;
                        string from = message.Headers.From.ToString();
                        listView.Invoke(new Action(() =>
                        {
                            listView.Items.Add(new ListViewItem(new[] { from, subject }));
                        }));
                    }
                }
            }

            listView.Invoke(new Action(() =>
            {
                labelM1.Enabled = label7.Enabled = label8.Enabled = true;
            }));

            statusLabel1.Text = "Письма загружены.";
        }

        private void Mail_LoadListSended()
        {
            using (OpenPop.Pop3.Pop3Client client = new Pop3Client())
            {
                // Подключение к серверу
                client.Connect("pop.mail.ru", 995, true);

                // Аутентификация (проверка логина и пароля)
                client.Authenticate(_login, _password, AuthenticationMethod.UsernameAndPassword);

                statusLabel1.Text = "Получение писем. . .";
                if (client.Connected)
                {
                    _messageCount = client.GetMessageCount();

                    allMessages = new List<OpenPop.Mime.Message>(_messageCount);
                    listView.Invoke(new Action(() =>
                    {
                        listView.Items.Clear();
                    }));
                    for (int i = _messageCount; i > 0; i--)
                    {
                        OpenPop.Mime.Message message = client.GetMessage(i);

                        if (message.Headers.From.ToString().Equals(_login))
                        {
                            allMessages.Add(client.GetMessage(i));

                            string subject = message.Headers.Subject;
                            string from = message.Headers.From.ToString();
                            listView.Invoke(new Action(() =>
                            {
                                listView.Items.Add(new ListViewItem(new[] { from, subject }));
                            }));
                        }
                    }
                }
            }

            listView.Invoke(new Action(() =>
            {
                labelM1.Enabled = label7.Enabled = label8.Enabled = true;
            }));

            statusLabel1.Text = "Письма загружены.";
        }
        private void Mail_LoadListGetted()
        {
            using (OpenPop.Pop3.Pop3Client client = new Pop3Client())
            {
                // Подключение к серверу
                client.Connect("pop.mail.ru", 995, true);

                // Аутентификация (проверка логина и пароля)
                client.Authenticate(_login, _password, AuthenticationMethod.UsernameAndPassword);

                statusLabel1.Text = "Получение писем. . .";
                if (client.Connected)
                {
                    _messageCount = client.GetMessageCount();

                    allMessages = new List<OpenPop.Mime.Message>(_messageCount);
                    listView.Invoke(new Action(() =>
                    {
                        listView.Items.Clear();
                    }));
                    for (int i = _messageCount; i > 0; i--)
                    {
                        OpenPop.Mime.Message message = client.GetMessage(i);

                        if (!message.Headers.From.ToString().Equals(_login))
                        {
                            allMessages.Add(client.GetMessage(i));

                            string subject = message.Headers.Subject;
                            string from = message.Headers.From.ToString();
                            listView.Invoke(new Action(() =>
                            {
                                listView.Items.Add(new ListViewItem(new[] { from, subject }));
                            }));
                        }
                    }
                }
            }

            listView.Invoke(new Action(() =>
            {
                labelM1.Enabled = label7.Enabled = label8.Enabled = true;
            }));

            statusLabel1.Text = "Письма загружены.";
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                labelMailFrom.Text = "От: " + allMessages[listView.SelectedIndices[0]].Headers.From.ToString();

                if (allMessages[listView.SelectedIndices[0]].Headers.Subject != null)
                    labelMailSubject.Text = "Тема: " + allMessages[listView.SelectedIndices[0]].Headers.Subject.ToString();
                else
                    labelMailSubject.Text = "Тема: . . .";

                if (allMessages[listView.SelectedIndices[0]].FindAllAttachments().Count > 0)
                {
                    labelMailAtch.Text = allMessages[listView.SelectedIndices[0]].FindAllAttachments().Count.ToString() + " файлов";
                    btnSaveAtch.Enabled = true;
                }
                else
                {
                    labelMailAtch.Text = "0 файлов";
                    btnSaveAtch.Enabled = false;
                }

                if (allMessages[listView.SelectedIndices[0]].FindFirstHtmlVersion() != null)
                    webBrowser.DocumentText = allMessages[listView.SelectedIndices[0]].FindFirstHtmlVersion().GetBodyAsText();
                else
                    webBrowser.DocumentText = allMessages[listView.SelectedIndices[0]].FindFirstPlainTextVersion().GetBodyAsText();
            }
        }

        private void labelM1_Click(object sender, EventArgs e)
        {
            mailThread = new Thread(Mail_LoadList);
            mailThread.IsBackground = true;
            mailThread.Start();

            labelM1.Font = new Font(labelM1.Font, FontStyle.Underline);
            label7.Font = label8.Font = new Font(labelM1.Font, FontStyle.Regular);
            labelM1.Enabled = label7.Enabled = label8.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            mailThread = new Thread(Mail_LoadListSended);
            mailThread.IsBackground = true;
            mailThread.Start();

            label7.Font = new Font(labelM1.Font, FontStyle.Underline);
            labelM1.Font = label8.Font = new Font(labelM1.Font, FontStyle.Regular);
            labelM1.Enabled = label7.Enabled = label8.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            mailThread = new Thread(Mail_LoadListGetted);
            mailThread.IsBackground = true;
            mailThread.Start();

            label8.Font = new Font(labelM1.Font, FontStyle.Underline);
            label7.Font = labelM1.Font = new Font(labelM1.Font, FontStyle.Regular);
            labelM1.Enabled = label7.Enabled = label8.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WriteForm form = new WriteForm(_login, _password);
            form.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();

            if (form.getLoginStatus() == true)
            {
                _login = form.getLogin();
                _password = form.getPass();
                Show();

                listView.Items.Clear();
                mailThread = new Thread(Mail_LoadList);
                mailThread.IsBackground = true;
                mailThread.Start();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var attachments = allMessages[listView.SelectedIndices[0]].FindAllAttachments();
            var attachmentdirectory = folderBrowserDialog.SelectedPath + "\\";

            Directory.CreateDirectory(attachmentdirectory);

            foreach (var att in attachments)
            {
                string filename = string.Format(@"{0}{1}_{2}{3}", attachmentdirectory, Path.GetFileNameWithoutExtension(att.FileName), DateTime.Now.ToString("MMddyyyyhhmmss"), Path.GetExtension(att.FileName));
                att.Save(new FileInfo(filename));
            }

            notifyIcon.BalloonTipTitle = "Загрузка файлов";
            notifyIcon.BalloonTipText = "Успешно загружено файлов: " + attachments.Count().ToString() + "\nФайлы загружены в дирректорию: " + folderBrowserDialog.SelectedPath + "\\";
            notifyIcon.ShowBalloonTip(16);
        }
    }
}
