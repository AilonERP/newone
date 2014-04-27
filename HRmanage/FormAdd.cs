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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            Employee_info emp = new Employee_info();
            emp.EmployeeName = txtName.Text.Trim();
            emp.TelephoneNo=txtTelpone.Text.Trim();
            emp.Email=txtEmail.Text.Trim();
            emp.EducationId = Convert.ToInt32( (cmbEducation.SelectedValue));
            //emp.EmployeeId = int.Parse(txtID.Text.Trim());
            emp.SalLevelId = cmbPay.Text.Trim()==""? 0: int.Parse(cmbPay.Text.Trim());
            emp.DeptId = Convert.ToInt32(cmbDep.SelectedValue);
            emp.PositionId = Convert.ToInt32(cmbZwei.SelectedValue);
           
            if (rdbMan.Checked)
            {
                emp.Gender = true;
            }
            else
                emp.Gender = false;

           emp.HireDate = dateTimePicker1.Value;
           emp.Desc = txtInformation.Text;
            AddEmployee emp1 = new AddEmployee();

            emp1.AddEmloy(emp);
            MessageBox.Show("数据插入成功");
            


        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            DictionaryBLL dic = new DictionaryBLL();
            //学历
          List<Dictionary_info> list=  dic.GetEdu();
          list.Insert(0, new Dictionary_info(0, "--请选择--", "", 1));
          cmbEducation.DisplayMember = "DictName";
          cmbEducation.ValueMember = "DictId";
          cmbEducation.DataSource = list;
            //部门
         List<Dictionary_info> list1=  dic.GetDicName();
         list1.Insert(0, new Dictionary_info(0, "--请选择--", "", 1));
          cmbDep.DisplayMember = "DictName";
          cmbDep.ValueMember = "DictId";
          cmbDep.DataSource = list1;

            //职位
          List<Dictionary_info> post = dic.GetPost();
          post.Insert(0, new Dictionary_info(0, "--请选择--", "", 1));
          cmbZwei.DisplayMember = "DictName";
          cmbZwei.ValueMember = "DictId";
          cmbZwei.DataSource = post;
        }

        private void btnCecliecnt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
