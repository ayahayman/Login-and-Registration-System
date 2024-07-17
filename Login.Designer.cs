namespace Login_and_Registration_System
{
    partial class Login
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
            login_label = new Label();
            Username_textbox = new TextBox();
            Username = new Label();
            Password_textbox = new TextBox();
            Password = new Label();
            Login_button = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_label.ImageAlign = ContentAlignment.MiddleRight;
            login_label.Location = new Point(21, 19);
            login_label.Name = "login_label";
            login_label.Size = new Size(374, 45);
            login_label.TabIndex = 1;
            login_label.Text = "Login to your Account:";
            // 
            // Username_textbox
            // 
            Username_textbox.Location = new Point(244, 111);
            Username_textbox.Name = "Username_textbox";
            Username_textbox.Size = new Size(268, 31);
            Username_textbox.TabIndex = 4;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(85, 111);
            Username.Name = "Username";
            Username.Size = new Size(91, 25);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // Password_textbox
            // 
            Password_textbox.Location = new Point(244, 196);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.Size = new Size(268, 31);
            Password_textbox.TabIndex = 10;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(85, 196);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 9;
            Password.Text = "Password";
            // 
            // Login_button
            // 
            Login_button.Location = new Point(205, 295);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(152, 40);
            Login_button.TabIndex = 11;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = true;
            Login_button.Click += Login_button_Click;
            // 
            // back
            // 
            back.Location = new Point(497, 338);
            back.Name = "back";
            back.Size = new Size(73, 34);
            back.TabIndex = 12;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 384);
            Controls.Add(back);
            Controls.Add(Login_button);
            Controls.Add(Password_textbox);
            Controls.Add(Password);
            Controls.Add(Username_textbox);
            Controls.Add(Username);
            Controls.Add(login_label);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login_label;
        private TextBox Username_textbox;
        private Label Username;
        private TextBox Password_textbox;
        private Label Password;
        private Button Login_button;
        private Button back;
    }
}