namespace Login_and_Registration_System
{
    partial class Home
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
            Login_button = new Button();
            SignUp_button = new Button();
            SuspendLayout();
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_label.ImageAlign = ContentAlignment.MiddleRight;
            login_label.Location = new Point(117, 71);
            login_label.Name = "login_label";
            login_label.Size = new Size(163, 45);
            login_label.TabIndex = 2;
            login_label.Text = "Welcome";
            login_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login_button
            // 
            Login_button.Location = new Point(132, 179);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(123, 34);
            Login_button.TabIndex = 3;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = true;
            Login_button.Click += Login_button_Click;
            // 
            // SignUp_button
            // 
            SignUp_button.Location = new Point(132, 260);
            SignUp_button.Name = "SignUp_button";
            SignUp_button.Size = new Size(123, 34);
            SignUp_button.TabIndex = 4;
            SignUp_button.Text = "Sign Up";
            SignUp_button.UseVisualStyleBackColor = true;
            SignUp_button.Click += SignUp_button_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 401);
            Controls.Add(SignUp_button);
            Controls.Add(Login_button);
            Controls.Add(login_label);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login_label;
        private Button Login_button;
        private Button SignUp_button;
    }
}