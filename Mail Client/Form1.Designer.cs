namespace Mail_Client
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "test@mail.ru", "Это новое тестовое письмо!" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem2 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "test2@mail.ru", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204)), new ListViewItem.ListViewSubItem(null, "Нового письма нет", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204)) }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menu = new Panel();
            label8 = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            labelM1 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            mailPanel = new Panel();
            statusStrip1 = new StatusStrip();
            statusLabel1 = new ToolStripStatusLabel();
            notifyIcon = new NotifyIcon(components);
            labelMailFrom = new Label();
            labelMailSubject = new Label();
            btnSaveAtch = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            labelMailAtch = new Label();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menu.BackColor = Color.FromArgb(65, 75, 106);
            menu.Controls.Add(label8);
            menu.Controls.Add(label7);
            menu.Controls.Add(pictureBox5);
            menu.Controls.Add(labelM1);
            menu.Controls.Add(pictureBox4);
            menu.Controls.Add(label5);
            menu.Controls.Add(pictureBox3);
            menu.Controls.Add(label4);
            menu.Controls.Add(pictureBox1);
            menu.Controls.Add(label1);
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(250, 753);
            menu.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Enabled = false;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(57, 139);
            label8.Name = "label8";
            label8.Size = new Size(128, 28);
            label8.TabIndex = 13;
            label8.Text = "Полученные";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(57, 101);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 12;
            label7.Text = "Самому себе";
            label7.Click += label7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.email_32;
            pictureBox5.Location = new Point(19, 61);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // labelM1
            // 
            labelM1.AutoSize = true;
            labelM1.Cursor = Cursors.Hand;
            labelM1.Enabled = false;
            labelM1.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            labelM1.ForeColor = Color.WhiteSmoke;
            labelM1.Location = new Point(57, 62);
            labelM1.Name = "labelM1";
            labelM1.Size = new Size(100, 28);
            labelM1.TabIndex = 10;
            labelM1.Text = "Вся почта";
            labelM1.Click += labelM1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.getted_mail_32;
            pictureBox4.Location = new Point(19, 137);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(187, 25);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 7;
            label5.Text = "Выйти";
            label5.Click += label5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Image = Properties.Resources.pencil_32;
            pictureBox3.Location = new Point(19, 686);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(57, 687);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 5;
            label4.Text = "Новое письмо";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.send_32;
            pictureBox1.Location = new Point(19, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 41);
            label1.TabIndex = 0;
            label1.Text = "Ящики";
            // 
            // listView
            // 
            listView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listView.BorderStyle = BorderStyle.None;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView.Location = new Point(250, 0);
            listView.Name = "listView";
            listView.Size = new Size(368, 730);
            listView.TabIndex = 9;
            listView.TileSize = new Size(346, 60);
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Tile;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Контакт";
            columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Письмо";
            columnHeader2.Width = 220;
            // 
            // mailPanel
            // 
            mailPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mailPanel.BackColor = Color.White;
            mailPanel.Location = new Point(619, 99);
            mailPanel.Name = "mailPanel";
            mailPanel.Size = new Size(563, 631);
            mailPanel.TabIndex = 10;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(65, 75, 106);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel1 });
            statusStrip1.Location = new Point(0, 727);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1182, 26);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            statusLabel1.ForeColor = Color.WhiteSmoke;
            statusLabel1.Name = "statusLabel1";
            statusLabel1.Size = new Size(151, 20);
            statusLabel1.Text = "toolStripStatusLabel1";
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = "Запущен почтовый клиент.";
            notifyIcon.BalloonTipTitle = "Почтовый клиент";
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Почтовый клиент";
            notifyIcon.Visible = true;
            // 
            // labelMailFrom
            // 
            labelMailFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMailFrom.BackColor = Color.Transparent;
            labelMailFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMailFrom.ForeColor = Color.DimGray;
            labelMailFrom.Location = new Point(624, 9);
            labelMailFrom.Name = "labelMailFrom";
            labelMailFrom.Size = new Size(546, 28);
            labelMailFrom.TabIndex = 12;
            labelMailFrom.Text = "Тема:";
            // 
            // labelMailSubject
            // 
            labelMailSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMailSubject.BackColor = Color.Transparent;
            labelMailSubject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMailSubject.ForeColor = Color.DimGray;
            labelMailSubject.Location = new Point(624, 41);
            labelMailSubject.Name = "labelMailSubject";
            labelMailSubject.Size = new Size(546, 20);
            labelMailSubject.TabIndex = 13;
            labelMailSubject.Text = "От: ";
            // 
            // btnSaveAtch
            // 
            btnSaveAtch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveAtch.Enabled = false;
            btnSaveAtch.Location = new Point(1016, 65);
            btnSaveAtch.Name = "btnSaveAtch";
            btnSaveAtch.Size = new Size(154, 29);
            btnSaveAtch.TabIndex = 14;
            btnSaveAtch.Text = "Скачать вложения";
            btnSaveAtch.UseVisualStyleBackColor = true;
            btnSaveAtch.Click += btnSave_Click;
            // 
            // labelMailAtch
            // 
            labelMailAtch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMailAtch.BackColor = Color.Transparent;
            labelMailAtch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMailAtch.ForeColor = Color.DimGray;
            labelMailAtch.Location = new Point(624, 70);
            labelMailAtch.Name = "labelMailAtch";
            labelMailAtch.Size = new Size(386, 20);
            labelMailAtch.TabIndex = 15;
            labelMailAtch.Text = "0 файлов";
            labelMailAtch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 753);
            Controls.Add(labelMailAtch);
            Controls.Add(btnSaveAtch);
            Controls.Add(labelMailSubject);
            Controls.Add(labelMailFrom);
            Controls.Add(statusStrip1);
            Controls.Add(mailPanel);
            Controls.Add(listView);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Почтовый клиент";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel menu;
        private PictureBox pictureBox1;
        private Label labelMailFrom;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel mailPanel;
        private PictureBox pictureBox4;
        private Label label6;
        private PictureBox pictureBox5;
        private Label labelM1;
        private Label label8;
        private Label label7;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel1;
        private NotifyIcon notifyIcon;
        private Label labelMailSubject;
        private Button btnSaveAtch;
        private FolderBrowserDialog folderBrowserDialog;
        private Label labelMailAtch;
    }
}
