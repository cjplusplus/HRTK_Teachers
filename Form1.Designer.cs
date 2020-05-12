namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.eyeActive = new System.Windows.Forms.PictureBox();
            this.eyeNoneActive = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eyeActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeNoneActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(199)))), ((int)(((byte)(61)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(278, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вітаю! Введіть логін і пароль!";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Arial Narrow", 14.75F, System.Drawing.FontStyle.Bold);
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxLogin.Location = new System.Drawing.Point(282, 290);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(207, 23);
            this.textBoxLogin.TabIndex = 4;
            this.textBoxLogin.Text = "Логін";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 14.75F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPassword.Location = new System.Drawing.Point(282, 360);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(207, 23);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "Пароль";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // eyeActive
            // 
            this.eyeActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.eyeActive.Image = global::WindowsFormsApp1.Properties.Resources.HidePasswordActive;
            this.eyeActive.Location = new System.Drawing.Point(495, 362);
            this.eyeActive.Name = "eyeActive";
            this.eyeActive.Size = new System.Drawing.Size(33, 23);
            this.eyeActive.TabIndex = 7;
            this.eyeActive.TabStop = false;
            this.eyeActive.Visible = false;
            this.eyeActive.Click += new System.EventHandler(this.eyeActive_Click_1);
            // 
            // eyeNoneActive
            // 
            this.eyeNoneActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.eyeNoneActive.Image = global::WindowsFormsApp1.Properties.Resources.HidePassword;
            this.eyeNoneActive.Location = new System.Drawing.Point(495, 362);
            this.eyeNoneActive.Name = "eyeNoneActive";
            this.eyeNoneActive.Size = new System.Drawing.Size(33, 23);
            this.eyeNoneActive.TabIndex = 6;
            this.eyeNoneActive.TabStop = false;
            this.eyeNoneActive.Click += new System.EventHandler(this.eyeNoneActive_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.RectangleAuth;
            this.pictureBox3.Location = new System.Drawing.Point(253, 335);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(291, 66);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.RectangleAuth;
            this.pictureBox2.Location = new System.Drawing.Point(253, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 65);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Author_Png;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.ButtonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEnter.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonEnter.ForeColor = System.Drawing.Color.LightGray;
            this.ButtonEnter.Location = new System.Drawing.Point(344, 407);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(108, 31);
            this.ButtonEnter.TabIndex = 8;
            this.ButtonEnter.Text = "Увійти";
            this.ButtonEnter.UseVisualStyleBackColor = false;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(199)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.eyeNoneActive);
            this.Controls.Add(this.eyeActive);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.eyeActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeNoneActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox eyeNoneActive;
        private System.Windows.Forms.PictureBox eyeActive;
        private System.Windows.Forms.Button ButtonEnter;
    }
}

