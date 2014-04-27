using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HrDBAPP
{
    public class DBHelper
    {
        public static SqlConnection conn = new SqlConnection("Data Source=AILON-THINK\\SQLEXPRESS;Initial Catalog=PostBacHR;Integrated Security=True");

      
    }
}

