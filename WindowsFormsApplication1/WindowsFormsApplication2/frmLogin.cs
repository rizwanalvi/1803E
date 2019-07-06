using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jeskoent;
namespace WindowsFormsApplication2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALLogin lg = new DALLogin();
            if (lg.LoginUser(new Login { UserName = textBox1.Text, UserPass = textBox2.Text })) {
                Form1.MainPanel.Enabled = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User/Pass");
            }

                    
           

        }
    }
}
