using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Login_and_Registration_System
{
    public partial class SignUp : Form
    {
        Home mainForm;
        Controller controllerObj;
        public SignUp(Home welcome)
        {
            InitializeComponent();
            mainForm = welcome;
            controllerObj = new Controller();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (Username_textbox.Text == "" || Email_textbox.Text == "" || Phone_no_textbox.Text == "" || Password_textbox.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                if (controllerObj.CheckIfUsernameExists(Username_textbox.Text))
                {
                    MessageBox.Show("Username is already taken. Please choose another username.");
                }
                else
                {
                    int check = controllerObj.InsertUser(Username_textbox.Text, Email_textbox.Text, Phone_no_textbox.Text, Password_textbox.Text);
                    if (check == 0)
                    {
                        MessageBox.Show("Insertion Failed");
                    }
                    else
                    {
                        Login L = new Login(mainForm);
                        MessageBox.Show("You have successfully created a new account, please login.");
                        L.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
