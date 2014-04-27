using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HrModel;

namespace HrDBAPP
{
    public class Employee_infoDAL
    {
        public List<Employee_info> GetEmployee(string name, int depid, int locid)
        {
            List<Employee_info> emps = new List<Employee_info>();
            try
            {//打开连接
                DBHelper.conn.Open();
                //创建命令对象
                SqlCommand com = new SqlCommand();
                com.Connection = DBHelper.conn;
                //命令类型为储存过程
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "usp_emp";
                //向储存过程传参数
                SqlParameter paraUser = com.Parameters.Add("empName", SqlDbType.NVarChar, 20);
                paraUser.Direction = ParameterDirection.Input;
                paraUser.Value = name;

                SqlParameter paraPassword = com.Parameters.Add("dept", SqlDbType.NVarChar, 20);

                paraPassword.Direction = ParameterDirection.Input;
                paraPassword.Value = depid;

                SqlParameter ret = com.Parameters.Add("loc", SqlDbType.Int);
                ret.Direction = ParameterDirection.Input;
                ret.Value = locid;
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    Employee_info emp = new Employee_info();

                    emp.EmployeeId = int.Parse(dr["EmployeeId"].ToString());
                    emp.EmployeeName = dr["EmployeeName"].ToString();
                    emp.Gender = bool.Parse((dr["Gender"].ToString()));
                    emp.HireDate = Convert.ToDateTime(dr["HireDate"].ToString());
                    emp.PositionId = int.Parse(dr["PositionId"].ToString());
                    emp.SalLevelId = int.Parse(dr["SalLevelId"].ToString());
                    emp.TelephoneNo = dr["TelephoneNo"].ToString();
                    emp.Email = dr["Email"].ToString();
                    emp.DeptId = int.Parse(dr["DeptId"].ToString());
                    emp.EducationId = int.Parse(dr["EducationId"].ToString());
                    emp.Desc = dr["Desc"].ToString();

                    emps.Add(emp);
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
            return emps;
        }


        public List<Employee_info> GetEmployeeall()
        {
            List<Employee_info> emps = new List<Employee_info>();
            try
            {//打开连接
                DBHelper.conn.Open();
                //创建命令对象
                SqlCommand com = new SqlCommand();
                com.Connection = DBHelper.conn;
                //命令类型为储存过程
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "us_selectall";
                #region Direction
                ////向储存过程传参数
                //SqlParameter paraUser = com.Parameters.Add("empName", SqlDbType.NVarChar, 20);
                //paraUser.Direction = ParameterDirection.Input;
                //paraUser.Value = name;

                //SqlParameter paraPassword = com.Parameters.Add("dept", SqlDbType.NVarChar, 20);

                //paraPassword.Direction = ParameterDirection.Input;
                //paraPassword.Value = depid;

                //SqlParameter ret = com.Parameters.Add("loc", SqlDbType.Int);
                //ret.Direction = ParameterDirection.Input;
                //ret.Value = locid;
                #endregion

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    Employee_info emp = new Employee_info();
                    try
                    {
                        emp.EmployeeId = int.Parse(dr["EmployeeId"].ToString());
                        emp.EmployeeName = dr["EmployeeName"].ToString();
                        emp.Gender = bool.Parse((dr["Gender"].ToString()));

                        emp.HireDate = Convert.ToDateTime(dr["HireDate"].ToString());

                        emp.PositionId = int.Parse(dr["PositionId"].ToString());
                        emp.SalLevelId = int.Parse(dr["SalLevelId"].ToString());
                        emp.TelephoneNo = dr["TelephoneNo"].ToString();
                        emp.Email = dr["Email"].ToString();
                        emp.DeptId = int.Parse(dr["DeptId"].ToString());
                        emp.EducationId = int.Parse(dr["EducationId"].ToString());
                        emp.Desc = dr["Desc"].ToString();
                    }
                    catch { }
                    emps.Add(emp);
                }

                dr.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                DBHelper.conn.Close();
            }
            return emps;
        }


        /// <summary>
        /// 查询员工信息
        /// </summary>
        /// <returns></returns>
        public List<Employee_info> GetEployeeinfo()
        {

           

                List<Employee_info> list = new List<Employee_info>();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"select *from dbo.Employee_info ");
                DBHelper.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DBHelper.conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SQL.ToString();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    Employee_info emp = new Employee_info();
                    emp.EmployeeId = int.Parse(dr["EmployeeId"].ToString());
                    emp.EmployeeName = dr["EmployeeName"].ToString();
                    emp.Gender = bool.Parse((dr["Gender"].ToString()));

                    emp.HireDate = Convert.ToDateTime(dr["HireDate"].ToString());

                    emp.PositionId = int.Parse(dr["PositionId"].ToString());
                    emp.SalLevelId = int.Parse(dr["SalLevelId"].ToString());
                    emp.TelephoneNo = dr["TelephoneNo"].ToString();
                    emp.Email = dr["Email"].ToString();
                    emp.DeptId = int.Parse(dr["DeptId"].ToString());
                    emp.EducationId = int.Parse(dr["EducationId"].ToString());
                    emp.Desc = dr["Desc"].ToString();

                    list.Add(emp);

                }
                return list;
                

            
           



        }

    }
}
