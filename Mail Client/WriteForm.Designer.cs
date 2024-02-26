namespace Mail_Client
{
    partial class WriteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteForm));
            panel1 = new Panel();
            mailBox2 = new TextBox();
            label1 = new Label();
            mailBox1 = new TextBox();
            label2 = new Label();
            mailTextBox = new TextBox();
            btnSend = new Button();
            notifyIcon = new NotifyIcon(components);
            btnAddAtch = new Button();
            openFileDialog = new OpenFileDialog();
            fileLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(65, 75, 106);
            panel1.Controls.Add(mailBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(mailBox1);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 159);
            panel1.TabIndex = 1;
            // 
            // mailBox2
            // 
            mailBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mailBox2.BackColor = Color.FromArgb(65, 75, 106);
            mailBox2.BorderStyle = BorderStyle.None;
            mailBox2.Font = new Font("Segoe UI", 10.8F);
            mailBox2.ForeColor = Color.White;
            mailBox2.Location = new Point(12, 111);
            mailBox2.Name = "mailBox2";
            mailBox2.PlaceholderText = "Введите тему письма. . .";
            mailBox2.Size = new Size(988, 24);
            mailBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 6;
            label1.Text = "Тема письма: ";
            // 
            // mailBox1
            // 
            mailBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mailBox1.BackColor = Color.FromArgb(65, 75, 106);
            mailBox1.BorderStyle = BorderStyle.None;
            mailBox1.Font = new Font("Segoe UI", 10.8F);
            mailBox1.ForeColor = Color.White;
            mailBox1.Location = new Point(12, 50);
            mailBox1.Name = "mailBox1";
            mailBox1.PlaceholderText = "Введите адрес электронной почты. . .";
            mailBox1.Size = new Size(988, 24);
            mailBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(181, 28);
            label2.TabIndex = 4;
            label2.Text = "Почта получателя:";
            // 
            // mailTextBox
            // 
            mailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mailTextBox.Location = new Point(12, 165);
            mailTextBox.Multiline = true;
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(987, 430);
            mailTextBox.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Location = new Point(825, 603);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(174, 40);
            btnSend.TabIndex = 8;
            btnSend.Text = "Отправить";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.Text = "notifyIcon1";
            notifyIcon.Visible = true;
            // 
            // btnAddAtch
            // 
            btnAddAtch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddAtch.Location = new Point(12, 603);
            btnAddAtch.Name = "btnAddAtch";
            btnAddAtch.Size = new Size(174, 40);
            btnAddAtch.TabIndex = 9;
            btnAddAtch.Text = "Прикрепить файл";
            btnAddAtch.UseVisualStyleBackColor = true;
            btnAddAtch.Click += btnAddAtch_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // fileLabel
            // 
            fileLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fileLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fileLabel.ForeColor = Color.Black;
            fileLabel.Location = new Point(192, 610);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(627, 28);
            fileLabel.TabIndex = 10;
            fileLabel.Text = ". . .";
            fileLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WriteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 653);
            Controls.Add(fileLabel);
            Controls.Add(btnAddAtch);
            Controls.Add(btnSend);
            Controls.Add(mailTextBox);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1030, 700);
            Name = "WriteForm";
            Text = "Отправка письма";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox mailBox2;
        private Label label1;
        private TextBox mailBox1;
        private Label label2;
        private TextBox mailTextBox;
        private Button btnSend;
        private NotifyIcon notifyIcon;
        private Button btnAddAtch;
        private OpenFileDialog openFileDialog;
        private Label fileLabel;
    }
}