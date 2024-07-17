using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Registration_System
{
    public partial class Login : Form
    {
        Home mainForm;
        Controller controllerObj;
        public Login(Home welcome)
        {
            InitializeComponent();
            mainForm = welcome;
            controllerObj = new Controller();
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (Username_textbox.Text == "")
            {
                MessageBox.Show("Username Field is empty. Please input a valid username.");
            }
            else if (controllerObj.CheckIfUsernameExists(Username_textbox.Text))
            {
                if (Password_textbox.Text == "")
                {
                    MessageBox.Show("Password Field is empty. Please input a valid password.");
                }
                else if (controllerObj.CheckIfPasswordExists(Username_textbox.Text, Password_textbox.Text))
                {
                    Profile P = new Profile(Username_textbox.Text, Password_textbox.Text, mainForm);
                    //MessageBox.Show("Login is successful");
                    P.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password is incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Username does not exist. Please enter a valid username.");
            }
        }
    }
}
