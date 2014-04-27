using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HrDBAPP;
using HrModel;

namespace HrBssAPP
{
   public  class WagePayBLL
    {
       WagePayDBAPP pay = new WagePayDBAPP();
       public List<Salary_infoModel> GetPay(int employeeid, DateTime yearmonth, int deduct) 
       {
           return pay.GetPay(employeeid,yearmonth,deduct);
       
       
       }


    }
}
