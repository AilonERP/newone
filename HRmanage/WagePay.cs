using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using HrModel;
using HrBssAPP;
using HrDBAPP;

namespace HRmanage
{
    public partial class WagePay : Form
    {
        public WagePay()
        {
            InitializeComponent();
        }
        #region 部门加载
        private void WagePay_Load(object sender, EventArgs e)
        {
            dgvPay.AutoGenerateColumns = false;
            DictionaryDAL dic = new DictionaryDAL();
            List<Dictionary_info> list = dic.GetDicName();
            list.Insert(0, new Dictionary_info(0, "--请选择--", "", 1));

            cmbDept.DisplayMember = "DeptName";
            cmbDept.ValueMember = "DeptId";
            cmbDept.DataSource = list;
            
        }
        #endregion

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbname.Items.Clear();
          int index=cmbDept.SelectedIndex;
          SqlServerDAL sql = new SqlServerDAL();
          //SqlDataReader dt= sql.Rename(index);
          List<Employee_info> list = sql.Rename(index);

          lbname.DataSource = list;
          lbname.DisplayMember = "EmployeeName";
          lbname.ValueMember = "EmployeeId";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
           // int id = cmbDept.SelectedIndex;
           // WagePayDBAPP wagepay = new WagePayDBAPP();
           //int pay= wagepay.Payleve(id);
           // List<WagePayModel> wage = wagepay.Pay(pay);
            

           
           //dataGridView1.DataSource = wage;

            int empid =int.Parse( lbname.SelectedValue.ToString());
            int deduct = int.Parse( txtque.Text.Trim());
            //string moth = dtpicker.Value.ToShortDateString();

            WagePayBLL wage = new WagePayBLL();
           List<Salary_infoModel>pay= wage.GetPay(empid, dtpicker.Value,deduct);

           dgvPay.DataSource = pay;







        }




        
    }
}
