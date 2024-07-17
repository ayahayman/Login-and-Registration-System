namespace Login_and_Registration_System
{
    partial class Profile
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
            Password = new Label();
            Phone_Number = new Label();
            Email = new Label();
            Username = new Label();
            Sign_Up = new Label();
            password_value = new Label();
            phone_no_value = new Label();
            email_value = new Label();
            username_value = new Label();
            back = new Button();
            SuspendLayout();
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(117, 332);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 12;
            Password.Text = "Password";
            // 
            // Phone_Number
            // 
            Phone_Number.AutoSize = true;
            Phone_Number.Location = new Point(117, 260);
            Phone_Number.Name = "Phone_Number";
            Phone_Number.Size = new Size(132, 25);
            Phone_Number.TabIndex = 11;
            Phone_Number.Text = "Phone Number";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(117, 190);
            Email.Name = "Email";
            Email.Size = new Size(54, 25);
            Email.TabIndex = 10;
            Email.Text = "Email";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(117, 124);
            Username.Name = "Username";
            Username.Size = new Size(91, 25);
            Username.TabIndex = 9;
            Username.Text = "Username";
            // 
            // Sign_Up
            // 
            Sign_Up.AutoSize = true;
            Sign_Up.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sign_Up.ImageAlign = ContentAlignment.MiddleRight;
            Sign_Up.Location = new Point(43, 30);
            Sign_Up.Name = "Sign_Up";
            Sign_Up.Size = new Size(246, 45);
            Sign_Up.TabIndex = 8;
            Sign_Up.Text = "Profile Details:";
            // 
            // password_value
            // 
            password_value.AutoSize = true;
            password_value.Location = new Point(313, 332);
            password_value.Name = "password_value";
            password_value.Size = new Size(89, 25);
            password_value.TabIndex = 16;
            password_value.Text = "password";
            // 
            // phone_no_value
            // 
            phone_no_value.AutoSize = true;
            phone_no_value.Location = new Point(313, 260);
            phone_no_value.Name = "phone_no_value";
            phone_no_value.Size = new Size(89, 25);
            phone_no_value.TabIndex = 15;
            phone_no_value.Text = "phone no";
            // 
            // email_value
            // 
            email_value.AutoSize = true;
            email_value.Location = new Point(313, 190);
            email_value.Name = "email_value";
            email_value.Size = new Size(54, 25);
            email_value.TabIndex = 14;
            email_value.Text = "email";
            // 
            // username_value
            // 
            username_value.AutoSize = true;
            username_value.Location = new Point(313, 124);
            username_value.Name = "username_value";
            username_value.Size = new Size(89, 25);
            username_value.TabIndex = 13;
            username_value.Text = "username";
            // 
            // back
            // 
            back.Location = new Point(497, 403);
            back.Name = "back";
            back.Size = new Size(73, 34);
            back.TabIndex = 17;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 449);
            Controls.Add(back);
            Controls.Add(password_value);
            Controls.Add(phone_no_value);
            Controls.Add(email_value);
            Controls.Add(username_value);
            Controls.Add(Password);
            Controls.Add(Phone_Number);
            Controls.Add(Email);
            Controls.Add(Username);
            Controls.Add(Sign_Up);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Password;
        private Label Phone_Number;
        private Label Email;
        private Label Username;
        private Label Sign_Up;
        private Label password_value;
        private Label phone_no_value;
        private Label email_value;
        private Label username_value;
        private Button back;
    }
}