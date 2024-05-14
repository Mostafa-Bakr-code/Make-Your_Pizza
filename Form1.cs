using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_your_Pizza
{
    public partial class loginscreen : Form
    {
        public loginscreen()
        {
            InitializeComponent();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {

            string storedUsername = txtlogin.Tag?.ToString();
            string storedPassword = txtpassword.Tag?.ToString();
            Form frm1 = new MainScreen();

            if (txtlogin.Text == storedUsername && txtpassword.Text == storedPassword)
            {
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }

        }

    }
}
