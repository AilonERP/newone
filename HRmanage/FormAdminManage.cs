using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HrModel;
using HrBssAPP;
using HrDBAPP;



namespace HRmanage
{
    public partial class FormAdminManage : Form
    {
        public FormAdminManage()
        {
            InitializeComponent();
        }

        private void FormAdminManage_Load(object sender, EventArgs e)
        {
            DictionaryDAL dic = new DictionaryDAL();
            List<Dictionary_info> dep = dic.GetDicName();
            dep.Insert(0, new Dictionary_info(0, "--请选择--", "", 1));
            cbDepart.DisplayMember = "DictName";
            cbDepart.ValueMember = "DictId";
            cbDepart.DataSource = dep;



            dgvAddAdmin.AutoGenerateColumns = false;

            AddAdminBLL admin = new AddAdminBLL();

            List<Admin_info> list = admin.GetAddAdmin();
            
            dgvAddAdmin.DataSource = list;
            

                
            


        }

        private void cbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbDepart.SelectedIndex;
            SqlServerDAL sql = new SqlServerDAL();
            
            List<Employee_info> list = sql.Rename(index);

            
            lbemployee.DisplayMember = "EmployeeName";
            lbemployee.ValueMember = "EmployeeId";
            lbemployee.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int dictid =int.Parse( cbDepart.SelectedValue.ToString());

            int emid =int.Parse( lbemployee.SelectedValue.ToString());

            string user = txtUserName.Text.Trim();
            string password = txtPassWord.Text.Trim();

            AddAdminBLL addAdmin = new AddAdminBLL();

            addAdmin.AddAdmin1(user, password, dictid, emid);

            dgvAddAdmin.AutoGenerateColumns = false;

            AddAdminBLL admin = new AddAdminBLL();

            List<Admin_info> list = admin.GetAddAdmin();

            dgvAddAdmin.DataSource = list;
            
            MessageBox.Show("管理员添加成功！");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelect_Click(object sender, EventArgs e)
        {
            AddAdminBLL adminbll = new AddAdminBLL();

            int empid =int.Parse(lbemployee.SelectedValue.ToString());
           List<Admin_info> del= adminbll.DeletAdmin(empid);

           dgvAddAdmin.DataSource = del;


           dgvAddAdmin.AutoGenerateColumns = false;

           AddAdminBLL admin = new AddAdminBLL();

           List<Admin_info> list = admin.GetAddAdmin();

           dgvAddAdmin.DataSource = list;




        }

        
    }
}
