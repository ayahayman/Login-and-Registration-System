namespace Login_and_Registration_System
{
    partial class SignUp
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
            Sign_Up = new Label();
            Username = new Label();
            Username_textbox = new TextBox();
            Email_textbox = new TextBox();
            Email = new Label();
            Phone_no_textbox = new TextBox();
            Phone_Number = new Label();
            Password_textbox = new TextBox();
            Password = new Label();
            sign = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // Sign_Up
            // 
            Sign_Up.AutoSize = true;
            Sign_Up.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sign_Up.ImageAlign = ContentAlignment.MiddleRight;
            Sign_Up.Location = new Point(22, 9);
            Sign_Up.Name = "Sign_Up";
            Sign_Up.Size = new Size(487, 45);
            Sign_Up.TabIndex = 0;
            Sign_Up.Text = "Sign up your Account Details: ";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(113, 103);
            Username.Name = "Username";
            Username.Size = new Size(91, 25);
            Username.TabIndex = 1;
            Username.Text = "Username";
            // 
            // Username_textbox
            // 
            Username_textbox.Location = new Point(272, 103);
            Username_textbox.Name = "Username_textbox";
            Username_textbox.Size = new Size(268, 31);
            Username_textbox.TabIndex = 2;
            // 
            // Email_textbox
            // 
            Email_textbox.Location = new Point(272, 169);
            Email_textbox.Name = "Email_textbox";
            Email_textbox.Size = new Size(268, 31);
            Email_textbox.TabIndex = 4;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(113, 169);
            Email.Name = "Email";
            Email.Size = new Size(54, 25);
            Email.TabIndex = 3;
            Email.Text = "Email";
            // 
            // Phone_no_textbox
            // 
            Phone_no_textbox.Location = new Point(272, 239);
            Phone_no_textbox.Name = "Phone_no_textbox";
            Phone_no_textbox.Size = new Size(268, 31);
            Phone_no_textbox.TabIndex = 6;
            // 
            // Phone_Number
            // 
            Phone_Number.AutoSize = true;
            Phone_Number.Location = new Point(113, 239);
            Phone_Number.Name = "Phone_Number";
            Phone_Number.Size = new Size(132, 25);
            Phone_Number.TabIndex = 5;
            Phone_Number.Text = "Phone Number";
            // 
            // Password_textbox
            // 
            Password_textbox.Location = new Point(272, 311);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.Size = new Size(268, 31);
            Password_textbox.TabIndex = 8;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(113, 311);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 7;
            Password.Text = "Password";
            // 
            // sign
            // 
            sign.Location = new Point(272, 392);
            sign.Name = "sign";
            sign.Size = new Size(137, 37);
            sign.TabIndex = 9;
            sign.Text = "Sign Up";
            sign.UseVisualStyleBackColor = true;
            sign.Click += sign_Click;
            // 
            // back
            // 
            back.Location = new Point(607, 429);
            back.Name = "back";
            back.Size = new Size(73, 34);
            back.TabIndex = 10;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 475);
            Controls.Add(back);
            Controls.Add(sign);
            Controls.Add(Password_textbox);
            Controls.Add(Password);
            Controls.Add(Phone_no_textbox);
            Controls.Add(Phone_Number);
            Controls.Add(Email_textbox);
            Controls.Add(Email);
            Controls.Add(Username_textbox);
            Controls.Add(Username);
            Controls.Add(Sign_Up);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Sign_Up;
        private Label Username;
        private TextBox Username_textbox;
        private TextBox Email_textbox;
        private Label Email;
        private TextBox Phone_no_textbox;
        private Label Phone_Number;
        private TextBox Password_textbox;
        private Label Password;
        private Button sign;
        private Button back;
    }
}