using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HrDBAPP;
using HrModel;

namespace HrBssAPP
{
   public class Employee_infoBLL
    {
       Employee_infoDAL employee = new Employee_infoDAL();
       public List<Employee_info> GetEmployee(string name, int depid, int locid) 
       {
           return employee.GetEmployee(name, depid, locid);
       
       }

       public List<Employee_info> GetEmployeeall()
       {
           return employee.GetEmployeeall();

       }

       /// <summary>
       /// 查询员工信息
       /// </summary>
       /// <returns></returns>
       public List<Employee_info> GetEployeeinfo() 
       {
           return employee.GetEployeeinfo();
       }

    }
}
