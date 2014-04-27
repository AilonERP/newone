using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HrModel;
using System.Data;

namespace HrDBAPP
{
    public class AddEmployee
    {

        //public int AddEmloy(int empid, string name, int depid, int posid, int eduid, int sleveid, string telephone,string email,bool gnder,string date)
        
    public int AddEmloy(Employee_info emp)
    {
            try
            {//打开连接
                DBHelper.conn.Open();
                //创建命令对象
                SqlCommand com = new SqlCommand();
                com.Connection = DBHelper.conn;
                //命令类型为储存过程
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "usp_select3";
                //向储存过程传参数
                //SqlParameter emid = com.Parameters.Add("employeeid", SqlDbType.Int);
                //emid.Direction = ParameterDirection.Input;
                //emid.Value = empid;

                SqlParameter emname = com.Parameters.Add("name", SqlDbType.NVarChar, 20);

                emname.Direction = ParameterDirection.Input;
                emname.Value = emp.EmployeeName;
                //com.Parameters.Add(emname);
                SqlParameter emdepid = com.Parameters.Add("depid", SqlDbType.Int);
                emdepid.Direction = ParameterDirection.Input;
                emdepid.Value = emp.DeptId;
                //com.Parameters.Add(emdepid);

                SqlParameter emposid = com.Parameters.Add("posid", SqlDbType.Int);
                emposid.Direction = ParameterDirection.Input;
                emposid.Value = emp.PositionId;
                ///com.Parameters.Add(emposid);

                SqlParameter emeduid = com.Parameters.Add("eduid", SqlDbType.Int);
                emeduid.Direction = ParameterDirection.Input;
                emeduid.Value = emp.EducationId;
                //com.Parameters.Add(emeduid);

                SqlParameter emsleveid = com.Parameters.Add("sleveid", SqlDbType.Int);
                emsleveid.Direction = ParameterDirection.Input;
                emsleveid.Value = emp.SalLevelId;
                //com.Parameters.Add(emsleveid);

                SqlParameter emtelephone = com.Parameters.Add("telephone", SqlDbType.NVarChar, 20);

                emtelephone.Direction = ParameterDirection.Input;
                emtelephone.Value = emp.TelephoneNo;
                //com.Parameters.Add(emtelephone);
                SqlParameter ememail = com.Parameters.Add("email", SqlDbType.NVarChar, 20);

                ememail.Direction = ParameterDirection.Input;
                ememail.Value = emp.Email;

                SqlParameter gnder = com.Parameters.Add("gnder", SqlDbType.Bit);

                gnder.Direction = ParameterDirection.Input;
                gnder.Value = emp.Gender;

                SqlParameter date1 = com.Parameters.Add("date", SqlDbType.DateTime);

                date1.Direction = ParameterDirection.Input;
                date1.Value = emp.HireDate;

                SqlParameter desc1 = com.Parameters.Add("desc1", SqlDbType.NVarChar,100);

                desc1.Direction = ParameterDirection.Input;
                desc1.Value = emp.Desc;



                //com.Parameters.Add(ememail);

                com.ExecuteNonQuery();

              return 1;

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