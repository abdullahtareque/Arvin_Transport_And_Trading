using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arvin_Transport_And_Trading
{
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == "Rahat" && txtBoxPassword.Text == "123")
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Provide The Valid Information!!!");
                this.Hide();
                FromLogin frmL = new FromLogin();
                frmL.ShowDialog();
            }
        }
    }
}
