using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HrModel;

namespace HrDBAPP
{
    public class AddAdmin
    {

        #region 读取Admin表
        public List<Admin_info> GetAddAdmin()
        {   DBHelper.conn.Open();
            List<Admin_info> list = new List<Admin_info>();

            
            SqlCommand com = new SqlCommand();
            com.Connection = DBHelper.conn;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "us_AddAdmin";


            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                Admin_info admin = new Admin_info();
                admin.LoginId = dr["LoginId"].ToString();
                admin.Password = dr["Password"].ToString();
                admin.EmployeeName = dr["EmployeeName"].ToString();
                admin.DictName = dr["DictName"].ToString();


                list.Add(admin);

            }
            dr.Close();

            DBHelper.conn.Close();
            return list;
         

            

           


        } 
        #endregion


        #region 添加管理员
        public List<Admin_info> GetAddAdmin2(string logid, string password, int dict, int employid)
        {

            DBHelper.conn.Open();
            List<Admin_info> list = new List<Admin_info>();
            SqlCommand com = new SqlCommand();
            com.Connection = DBHelper.conn;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "us_insertAdmin";

            SqlParameter login = com.Parameters.Add("loginid", SqlDbType.VarChar, 50);
            login.Direction = ParameterDirection.Input;
            login.Value = logid;


            SqlParameter pass = com.Parameters.Add("password", SqlDbType.VarChar, 50);
            pass.Direction = ParameterDirection.Input;
            pass.Value = password;

            SqlParameter dic = com.Parameters.Add("dictid", SqlDbType.Int);
            dic.Direction = ParameterDirection.Input;
            dic.Value = dict;

            SqlParameter eid = com.Parameters.Add("employeeid", SqlDbType.Int);
            eid.Direction = ParameterDirection.Input;
            eid.Value = employid;

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                Admin_info admin = new Admin_info();

                admin.LoginId = dr["LoginId"].ToString();
                admin.Password = dr["Password"].ToString();
                admin.DictName = dr["DictName"].ToString();
                admin.EmployeeName = dr["EmployeeName"].ToString();


                list.Add(admin);


            }

            dr.Close();
            DBHelper.conn.Close();

            return list;

        } 
        #endregion


        public List<Admin_info> DeletAdmin(int empid) 
        {
            List<Admin_info> list = new List<Admin_info>();

            DBHelper.conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = DBHelper.conn;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "us_DelectAdmin";

            SqlParameter emid1= com.Parameters.Add("employeeid",SqlDbType.Int);

            emid1.Direction = ParameterDirection.Input;
            emid1.Value = empid;

           SqlDataReader dr= com.ExecuteReader();

            while(dr.Read())
            {
                Admin_info admin = new Admin_info();

                admin.LoginId = dr["LoginId"].ToString();
                admin.Password = dr["Password"].ToString();
                admin.EmployeeName = dr["EmployeeName"].ToString();
                admin.DictName = dr["DictName"].ToString();

                list.Add(admin);
            
            
            }
            dr.Close();
            DBHelper.conn.Close();
            return list;
        
        
        
        
        }

    }
}

