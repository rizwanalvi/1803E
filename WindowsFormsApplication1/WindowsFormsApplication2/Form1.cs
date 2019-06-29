using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
       public static bool _isProduct = false;
        public static bool _isCustomer = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnClick = (Button) sender;
           
                switch (btnClick.Text)
                {
                    case "Product":
                    if (!_isProduct)
                    {
                        frmProduct fmp = new frmProduct();
                        fmp.Show();
                        fmp.MdiParent = this;
                        _isProduct = true;
                    }
                    else {
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Text == "Product")
                                item.Focus();
                        }
                    }
                    break;
                    case "Customer":
                    if (!_isCustomer)
                    {
                        frmCustomer fmc = new frmCustomer();
                        fmc.Show();
                        fmc.MdiParent = this;
                        _isCustomer = true;
                    }
                    else
                    {
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Text == "Customer")
                                item.Focus();
                        }
                    }
                    break;
                   
                    default:
                        break;
                }
            
        }

   

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "Product")
                    item.Focus();
            }
            // this.MdiChildren.Count().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin();
            frmLog.Show();
            frmLog.MdiParent = this;
        }
    }
}
