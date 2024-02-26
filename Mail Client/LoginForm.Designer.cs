namespace Mail_Client
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            loginBox = new TextBox();
            mailBox = new ComboBox();
            label3 = new Label();
            passBox = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(65, 75, 106);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(194, 41);
            label1.TabIndex = 1;
            label1.Text = "Вход в почту";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 128);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 2;
            label2.Text = "Логин";
            // 
            // loginBox
            // 
            loginBox.Location = new Point(26, 159);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(273, 27);
            loginBox.TabIndex = 3;
            // 
            // mailBox
            // 
            mailBox.FlatStyle = FlatStyle.System;
            mailBox.FormattingEnabled = true;
            mailBox.Items.AddRange(new object[] { "@mail.ru", "@bk.ru", "@internet.ru" });
            mailBox.Location = new Point(305, 158);
            mailBox.Name = "mailBox";
            mailBox.Size = new Size(151, 28);
            mailBox.TabIndex = 4;
            mailBox.Text = "@mail.ru";
            mailBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(26, 193);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 5;
            label3.Text = "Пароль";
            // 
            // passBox
            // 
            passBox.Location = new Point(26, 224);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(430, 27);
            passBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(26, 281);
            button1.Name = "button1";
            button1.Size = new Size(430, 48);
            button1.TabIndex = 7;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 353);
            Controls.Add(button1);
            Controls.Add(passBox);
            Controls.Add(label3);
            Controls.Add(mailBox);
            Controls.Add(loginBox);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Вход";
            TopMost = true;
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox loginBox;
        private ComboBox mailBox;
        private Label label3;
        private TextBox passBox;
        private Button button1;
    }
}