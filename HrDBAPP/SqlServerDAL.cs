using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HrModel;
using System.Data;

namespace HrDBAPP
{
    public class SqlServerDAL
    {
        #region Redataset
        public DataSet Redataset()
        {
            //SqlCommand com = new SqlCommand(connection);

            //com.CommandType = CommandType.StoredProcedure;

            //com.CommandText = "selectdept";
           
            string sqlcom = "Select DeptName from dbo.Dept_info";
            SqlDataAdapter da = new SqlDataAdapter(sqlcom, DBHelper.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "data");
          

            return ds;


        }
        #endregion

        #region 岗位
        //岗位
        //public DataSet ReJob()
        //{
        //    //SqlCommand com = new SqlCommand(connection);

        //    //com.CommandType = CommandType.StoredProcedure;

        //    //com.CommandText = "selectdept";

        //    string sqlcom = "Select DeptName from dbo.Dept_info";
        //    SqlDataAdapter da = new SqlDataAdapter(sqlcom, DBHelper.conn);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, "data");

        //    return ds;


        //}
        #endregion
        public List<Employee_info> Rename(int index)
        {
            #region MyRegion

                DBHelper.conn.Open();
                List<Employee_info> emps = new List<Employee_info>();

                SqlCommand com = new SqlCommand();
                com.Connection = DBHelper.conn;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "us_selectworker";

                SqlParameter depname = com.Parameters.Add("dep", SqlDbType.Int);
                depname.Direction = ParameterDirection.Input;
                depname.Value = index;

                SqlDataReader dr = com.ExecuteReader();
                //SqlDataAdapter da = new SqlDataAdapter();
                //DataSet ds = new DataSet();
                while (dr.Read())
                {
                    Employee_info emp = new Employee_info();

                    emp.EmployeeId = int.Parse(dr["EmployeeId"].ToString());
                    emp.EmployeeName = dr["EmployeeName"].ToString();
                    //emp.Gender = bool.Parse((dr["Gender"].ToString()));
                    //emp.HireDate = Convert.ToDateTime(dr["HireDate"].ToString());
                    //emp.PositionId = int.Parse(dr["PositionId"].ToString());
                    //emp.SalLevelId = int.Parse(dr["SalLevelId"].ToString());
                    //emp.TelephoneNo = dr["TelephoneNo"].ToString();
                    //emp.Email = dr["Email"].ToString();
                    //emp.DeptId = int.Parse(dr["DeptId"].ToString());
                    //emp.EducationId = int.Parse(dr["EducationId"].ToString());
                    //emp.Desc = dr["Desc"].ToString();

                    emps.Add(emp);

                }
                dr.Close();
            DBHelper.conn.Close();
            return emps;

                
               
            
             


            #endregion

            //string sql = "select EmployeeName from dbo.Employee_info where DeptId=" + index;

            //SqlDataAdapter da = new SqlDataAdapter(sql,DBHelper.conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds,"name");

            //return ds;

        }

    }
}
       

       



    

