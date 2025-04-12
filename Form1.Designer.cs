namespace _6_Sefer_ile_Kelime_Ezberleme_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.NamePanel = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.Teal;
            this.NamePanel.Controls.Add(this.NameLabel);
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(478, 58);
            this.NamePanel.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(309, 38);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Login And Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(51, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(51, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password: ";
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUsernameTextBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginUsernameTextBox.Location = new System.Drawing.Point(183, 223);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(210, 31);
            this.loginUsernameTextBox.TabIndex = 2;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginPasswordTextBox.Location = new System.Drawing.Point(183, 289);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.Size = new System.Drawing.Size(210, 31);
            this.loginPasswordTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.ForeColor = System.Drawing.Color.Teal;
            this.loginButton.Location = new System.Drawing.Point(56, 343);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(104, 42);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerButton.ForeColor = System.Drawing.Color.Teal;
            this.registerButton.Location = new System.Drawing.Point(67, 650);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(110, 42);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerPasswordTextBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerPasswordTextBox.Location = new System.Drawing.Point(194, 596);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(210, 31);
            this.registerPasswordTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(-6, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(25, 5, 5, 0);
            this.label2.Size = new System.Drawing.Size(166, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Register";
            // 
            // registerUsernameTextBox
            // 
            this.registerUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerUsernameTextBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerUsernameTextBox.Location = new System.Drawing.Point(194, 530);
            this.registerUsernameTextBox.Name = "registerUsernameTextBox";
            this.registerUsernameTextBox.Size = new System.Drawing.Size(210, 31);
            this.registerUsernameTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(62, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(62, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Username: ";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(-6, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(25, 5, 5, 0);
            this.label7.Size = new System.Drawing.Size(166, 52);
            this.label7.TabIndex = 11;
            this.label7.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(478, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.registerPasswordTextBox);
            this.Controls.Add(this.registerUsernameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginUsernameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6 Sefer ile Kelime Ezberleme Sistemi";
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox registerPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registerUsernameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

