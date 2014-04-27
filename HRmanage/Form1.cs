using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HrBssAPP;

namespace HRmanage
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string user=txtUserName.Text;
            string password=txtPassWord.Text;

            Login login = new Login();


            //SqlConnection conn = new SqlConnection("Data Source=AILON-THINK\\SQLEXPRESS;Initial Catalog=PostBacHR;Integrated Security=True");
            //conn.Open();
            //string sql = string.Format("select count(*)from dbo.Admin_info where LoginId='{0}' and Password='{1}'",user,password);

            //SqlCommand com = new SqlCommand(sql, conn);
            //int cnt=(int) com.ExecuteScalar();
            bool falg=login.LoginAmin(user,password);

            if ( falg)
            {
                FormMain form = new FormMain();
                form.Show();
                this.Hide();

            }
            else 
            {

                MessageBox.Show("你输入的账号和密码有误！");
                txtUserName.Focus();
            
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }
       
        
    }
}

