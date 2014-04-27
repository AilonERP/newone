using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HrDBAPP;

namespace HRmanage
{
    public partial class FormRePassword : Form
    {
        
        public FormRePassword()
        {
            InitializeComponent();
        }

        private void btalter_Click(object sender, EventArgs e)
        {

            string user = txtUserName.Text.Trim();
            string oldpassword = txtoldpassword.Text.Trim();
            string newpassword = txtnewpassword.Text.Trim();
            string aginpassword = txtaginpassword.Text.Trim();
            Admain ad = new Admain();
            
     

            bool re = ad.Login(user, this.txtoldpassword.Text.Trim());
            if(newpassword!=aginpassword)
            {
                MessageBox.Show("你2次输入的密码不相同！");
            
            
            }
            else if(re)
          {
              alterPassWord pass = new alterPassWord();
              pass.AltarPassWord(oldpassword, newpassword);
              MessageBox.Show("修改密码成功！");


          }
          


        }
    }
}
