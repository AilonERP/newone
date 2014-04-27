using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HrDBAPP
{
   public  class Admain
    {
        public bool Login(string user, string password)
        {

          

            try
            {//打开连接
                DBHelper.conn.Open();
                //创建命令对象
                SqlCommand com = new SqlCommand();
                com.Connection =DBHelper.conn;
                //命令类型为储存过程
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "usp_login";
                //向储存过程传参数
                SqlParameter paraUser = com.Parameters.Add("username", SqlDbType.NVarChar, 20);
                paraUser.Direction = ParameterDirection.Input;
                paraUser.Value = user;

                SqlParameter paraPassword = com.Parameters.Add("password", SqlDbType.NVarChar, 20);

                paraPassword.Direction = ParameterDirection.Input;
                paraPassword.Value = password;

                SqlParameter ret = com.Parameters.Add("cnt", SqlDbType.Int);
                ret.Direction = ParameterDirection.ReturnValue;
                com.ExecuteNonQuery();
                if ((int)ret.Value == 1)
                {

                    return true;


                }
                else
                {
                    return false;

                }





            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

               DBHelper.conn.Close();
            }

        }


    }
}
