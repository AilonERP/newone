using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HrModel;
using HrDBAPP;
using System.Data.SqlClient;
using System.Data;

namespace HrDBAPP
{
   public class WagePayDBAPP
    {
        //#region 工资计算
        //public List<WagePayModel> Pay(double basepay)
        //{
        //    List<WagePayModel> wage = new List<WagePayModel>();
        //    //住房公积金
        //    double housingfund = basepay * 0.12;
        //    // 医疗保险
        //    double medicalPrize = basepay * 0.02 + 3;
        //    //养老
        //    double personPrize = basepay * 0.08;
        //    //全月应纳税所得额(=工资－住房公积金－养老－医疗保险－考勤扣除－2000 )
        //    double sumTax = basepay - personPrize - medicalPrize - housingfund - 2000;
        //    //税率

        //    double tax = 0;
        //    double sukou = 0;
        //    if (sumTax < 500)
        //    {
        //        tax = 0;
        //    }
        //    else if (sumTax > 500 && sumTax <= 2000)
        //    {

        //        tax = 0.1;
        //        sukou = 25;
        //    }
        //    else if (sumTax > 2000 && sumTax < 5000)
        //    {
        //        tax = 0.15;
        //        sukou = 125;

        //    }
        //    else if (sumTax > 5000 && sumTax < 20000)
        //    {
        //        tax = 0.2;
        //        sukou = 375;

        //    }


        //    //个人所得税=全月应纳税所得额*税率－速算扣除数 
        //    double tax1 = sumTax * tax - sukou;


        //    //实发工资=全月总收入－住房公积金－养老－医疗保险－考勤扣除－个人所得税

        //    double shiPay = basepay - housingfund - personPrize - medicalPrize - tax1;
        //    WagePayModel wagepay = new WagePayModel();
        //    wagepay.Housingfund = housingfund;
        //    wagepay.MedicalPrize = medicalPrize;
        //    wagepay.PersonPrize = personPrize;
        //    wagepay.Pay = basepay;
        //    wagepay.Sum = shiPay;

        //    wage.Add(wagepay);
        //    return wage;




        //}
        
        //#endregion

       public List<Salary_infoModel> GetPay(int employeeid, DateTime yearmonth,int deduct) 
       {
           List<Salary_infoModel> list = new List<Salary_infoModel>();
           DBHelper.conn.Open();
           //创建命令对象
           SqlCommand com = new SqlCommand();
           com.Connection = DBHelper.conn;
           //命令类型为储存过程
           com.CommandType = CommandType.StoredProcedure;
           com.CommandText = "us_wagepay2";

           SqlParameter empid = com.Parameters.Add("employeeid", SqlDbType.Int);
           empid.Direction = ParameterDirection.Input;
           empid.Value = employeeid;

           SqlParameter date = com.Parameters.Add("yearmonth", SqlDbType.DateTime);
           date.Direction = ParameterDirection.Input;
           date.Value = yearmonth;
           SqlParameter duct= com.Parameters.Add("deductcount", SqlDbType.Int);
           duct.Direction = ParameterDirection.Input;
           duct.Value = deduct;

           SqlDataReader da= com.ExecuteReader();

           while(da.Read())
           {

               Salary_infoModel wage = new Salary_infoModel();
               wage.SalaryId = int.Parse(da["SalaryId"].ToString());
               wage.YearMonth =DateTime.Parse( da["YearMonth"].ToString());
               wage.Salary = decimal.Parse(da["Salary"].ToString());
               wage.Bouns = decimal.Parse(da["Bouns"].ToString());
               wage.Medicare = decimal.Parse(da["Medicare"].ToString());
               wage.Endowment = decimal.Parse(da["Endowment"].ToString());
               wage.AccumulationFund = decimal.Parse(da["AccumulationFund"].ToString());
               wage.Total = decimal.Parse(da["Total"].ToString());
               wage.EmployeeId = int.Parse(da["EmployeeId"].ToString());
               wage.Rest = decimal.Parse(da["Rest"].ToString());
               wage.Deduct = decimal.Parse(da["Deduct"].ToString());               
               wage.EmployeeName = da["EmployeeName"].ToString();
               //全月应纳税所得额(=工资－住房公积金－养老－医疗保险－考勤扣除－2000 )
                   decimal sumTax = wage.Salary - wage.AccumulationFund - wage.Endowment - wage.Deduct - 2000;
                   //税率

                   double tax = 0;
                   decimal sukou = 0;
                   if (sumTax < 500)
                   {
                       tax = 0;
                   }
                   else if (sumTax > 500 && sumTax <= 2000)
                   {

                       tax = 0.1;
                       sukou = 25;
                   }
                   else if (sumTax > 2000 && sumTax < 5000)
                   {
                       tax = 0.15;
                       sukou = 125;

                   }
                   else if (sumTax > 5000 && sumTax < 20000)
                   {
                       tax = 0.2;
                       sukou = 375;

                   }


                   //个人所得税=全月应纳税所得额*税率－速算扣除数 
                   decimal tax1 = wage.Salary * decimal.Parse(tax.ToString()) - sukou;
                   wage.Tax = tax1;


               list.Add(wage);


           }
           da.Close();
           DBHelper.conn.Close();

           return list;
       
       
       }
      





  




    }
}
