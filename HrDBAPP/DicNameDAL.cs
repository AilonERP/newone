using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HrModel;
using System.Data;
using System.Data.SqlClient;

namespace HrDBAPP
{
    public class DicNameDAL
    {
        //public List<Dictionary_info> GetDicName()
        //{
        //    List<Dictionary_info> edus = new List<Dictionary_info>();

        //    try
        //    {
        //        //打开连接
        //        DBHelper.conn.Open();
        //        //创建命令对象
        //        SqlCommand com = new SqlCommand();
        //        com.Connection = DBHelper.conn;
        //        //命令类型为储存过程
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.CommandText = "us_selectDep";

        //        SqlDataReader dr = com.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            Dictionary_info info = new Dictionary_info();
        //            info.DicName = dr["DictName"].ToString();
        //            info.DictId = int.Parse(dr["DictId"].ToString());
        //            info.DicDesc = dr["DictDesc"].ToString();
        //            info.DictCategoryId = int.Parse(dr["DictCategoryId"].ToString());
        //            edus.Add(info);

        //        }
        //        dr.Close();
        //        return edus;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {

        //        DBHelper.conn.Close();
        //    }



        }
    }
