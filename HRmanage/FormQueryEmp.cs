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
    public partial class FormQueryEmp : Form
    {
        public FormQueryEmp()
        {
            InitializeComponent();
        }
          private void FormQueryEmp_Load(object sender, EventArgs e)
        {   dgvEmp.AutoGenerateColumns = false;
            DictionaryDAL dic = new DictionaryDAL();
            List<Dictionary_info> list = dic.GetDicName();
            list.Insert(0, new Dictionary_info(0,"--请选择--","",1)); 
            
            cmbDept.DisplayMember = "DictName";
            cmbDept.ValueMember = "DictId";
            cmbDept.DataSource = list;


            List<Dictionary_info> list1 = dic.GetPost();
            list1.Insert(0, new Dictionary_info(0, "--请选择--", "", 1));
           
            cmbLoc.DisplayMember = "DictName";
            cmbLoc.ValueMember = "DictId";
            cmbLoc.DataSource = list1;

           

        }
      
        private void btnQuery_Click(object sender, EventArgs e)
        {

            string name = txtName.Text.Trim();//姓名
            //string Dept = cmbDept.SelectedValue.ToString();//部门

            //string loc = cmbLoc.SelectedValue.ToString();//岗位

            Employee_infoBLL employee = new Employee_infoBLL();

            if (string.IsNullOrEmpty(txtName.Text.Trim()) )
            {


              dgvEmp.DataSource= employee.GetEployeeinfo();
            
            }



          
           
        }
       


      
    }
}
