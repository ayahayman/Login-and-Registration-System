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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            Login L = new Login(this);
            L.Show();
            this.Hide();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            SignUp S = new SignUp(this);
            S.Show();
            this.Hide();
        }
    }
}
