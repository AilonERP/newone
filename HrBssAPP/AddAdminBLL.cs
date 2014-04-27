using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HrDBAPP;
using HrModel;

namespace HrBssAPP
{
  public  class AddAdminBLL
    {
      AddAdmin admin = new AddAdmin();
      public List<Admin_info> GetAddAdmin() 
      {

          return admin.GetAddAdmin();
      
      }

      //public List<Employee_info> GetEmployeeName(int emid) 
      //{
      //    return admin.GetEmployeeName(emid);
      
      //}

      public List<Admin_info> AddAdmin1(string logid, string password, int dict, int employid) 
      {

          return admin.GetAddAdmin2(logid,password,dict,employid);
      
      
      }

      public List<Admin_info> DeletAdmin(int empid) 
      {

          return admin.DeletAdmin(empid);
      
      
      }


    }
}
