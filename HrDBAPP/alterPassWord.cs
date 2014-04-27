using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HrModel;

namespace HrDBAPP
{
   public  class alterPassWord
   {
       public void AltarPassWord(string oldpassword,string newpassword) 
       {
           DBHelper.conn.Open();
           SqlCommand com = new SqlCommand();
           com.Connection = DBHelper.conn;
           com.CommandType = CommandType.StoredProcedure;
           com.CommandText = "us_alterpassword";

           SqlParameter old= com.Parameters.Add("oldpassword",SqlDbType.VarChar,50);
           old.Direction = ParameterDirection.Input;
           old.Value = oldpassword;


           SqlParameter newpass = com.Parameters.Add("newpassword", SqlDbType.VarChar, 50);
           newpass.Direction = ParameterDirection.Input;
           newpass.Value = newpassword;

           com.ExecuteNonQuery();
       
       }



    }
}
