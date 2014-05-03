using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HrModel;


namespace HrDBAPP
{
    /// <summary>
    /// 修改密码
    /// </summary>
   public  class alterPassWord
   {
       DBComm db = new DBComm();
       public void AltarPassWord(string oldpassword,string newpassword) 
       {
           SqlCommand cmd = db.GetStoredProcCommand("us_alterpassword");
           db.AddInParameter(cmd,"oldpassword",DbType.AnsiString,oldpassword);
           db.AddInParameter(cmd, "newpassword",DbType.AnsiString,newpassword);

           Trans trans = new Trans();

           db.ExecuteNonQuery(cmd);

           trans.Commit();
           
          
       }



    }
}
