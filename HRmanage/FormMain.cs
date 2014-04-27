using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRmanage
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsmiQueryEmp_Click(object sender, EventArgs e)
        {
            FormQueryEmp form = new FormQueryEmp();
            form.MdiParent = this;
            form.Show();


        }

        private void tsmiNewAdd_Click(object sender, EventArgs e)
        {
            FormAdd formadd = new FormAdd();
            formadd.MdiParent = this;
            formadd.Show();
        }

        private void tmsWagePay_Click(object sender, EventArgs e)
        {
            WagePay wage = new WagePay();
            wage.Show();
        }

        private void tsmiAmin_Click(object sender, EventArgs e)
        {
            FormAdminManage admin = new FormAdminManage();
            admin.Show();
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmixgmm_Click(object sender, EventArgs e)
        {
            FormRePassword repassword = new FormRePassword();
            repassword.Show();
        }

       
    }
}
