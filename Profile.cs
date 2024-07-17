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
    public partial class Profile : Form
    {
        Home mainForm;
        Controller controllerObj;
        public Profile(string username, string password, Home welcome)
        {
            InitializeComponent();
            controllerObj = new Controller();
            username_value.Text = username;
            email_value.Text = controllerObj.GetEmail(username);
            phone_no_value.Text = controllerObj.GetPhoneNumber(username);
            password_value.Text = password;
            mainForm = welcome;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
