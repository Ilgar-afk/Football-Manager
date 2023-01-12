
namespace Football_Manager
{
    partial class RegisterForm
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.RegisterLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.White;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Impact", 14.25F);
            this.buttonRegister.ForeColor = System.Drawing.Color.Black;
            this.buttonRegister.Location = new System.Drawing.Point(285, 225);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(204, 45);
            this.buttonRegister.TabIndex = 17;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Impact", 12.25F);
            this.passField.Location = new System.Drawing.Point(572, 153);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.PasswordChar = '*';
            this.passField.Size = new System.Drawing.Size(180, 37);
            this.passField.TabIndex = 16;
            this.passField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Impact", 12.25F);
            this.loginField.Location = new System.Drawing.Point(147, 154);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(180, 36);
            this.loginField.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(437, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(756, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(44, 57);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Impact", 12.25F);
            this.userNameField.Location = new System.Drawing.Point(147, 99);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(180, 40);
            this.userNameField.TabIndex = 18;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // userSurnameField
            // 
            this.userSurnameField.Font = new System.Drawing.Font("Impact", 12.25F);
            this.userSurnameField.Location = new System.Drawing.Point(572, 99);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(180, 40);
            this.userSurnameField.TabIndex = 19;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // RegisterLable
            // 
            this.RegisterLable.AutoSize = true;
            this.RegisterLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.RegisterLable.ForeColor = System.Drawing.Color.Black;
            this.RegisterLable.Location = new System.Drawing.Point(319, 419);
            this.RegisterLable.Name = "RegisterLable";
            this.RegisterLable.Size = new System.Drawing.Size(145, 22);
            this.RegisterLable.TabIndex = 20;
            this.RegisterLable.Text = "Авторизоваться";
            this.RegisterLable.Click += new System.EventHandler(this.RegisterLable_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterLable);
            this.Controls.Add(this.userSurnameField);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.Label RegisterLable;
    }
}