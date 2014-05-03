using System;
using System.Data;
using System.Data.SqlClient;

public class DBComm
{

    public static string DbConnectionString
    {
        get
        {   
            //Data Source=192.168.80.188;Initial Catalog=CmblEDI;User ID=sa;Password=cmmlbms
            //return "Data Source=192.168.80.188;Initial Catalog=CmblEDI;Persist Security Info=True;User ID=sa;Password=cmmlbms";
            return "Data Source=AILON-THINK\\SQLEXPRESS;Initial Catalog=PostBacHR;Integrated Security=True";
           
        //    return string.Format("Data Source={0};Initial Catalog=CmblEDI_Test;Persist Security Info=True;User ID=sa;Password=sa", DAL.XmlHelper.Read(System.IO.Path.GetDirectoryName(
        //System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Config.xml",
        //            "/appSettings/setting[@name='ServerAddress']", "value"));
        }
    }

    private SqlConnection connection;

    public DBComm()
    {
        this.connection = CreateConnection(DbConnectionString);
    }
    public DBComm(string connectionString)
    {
        this.connection = CreateConnection(connectionString);
    }
    public static SqlConnection CreateConnection()
    {
        SqlConnection conn = new SqlConnection(DbConnectionString);
        return conn;
    }
    public static SqlConnection CreateConnection(string connectionString)
    {
        SqlConnection conn = new SqlConnection(DbConnectionString);
        return conn;
    }

    public SqlCommand GetStoredProcCommand(string storedProcedure)
    {
        SqlCommand dbCommand = connection.CreateCommand();
        dbCommand.CommandText = storedProcedure;
        dbCommand.CommandType = CommandType.StoredProcedure;
        return dbCommand;
    }
    public SqlCommand GetSqlStringCommand(string sqlQuery)
    {
        SqlCommand dbCommand = connection.CreateCommand();
        dbCommand.CommandText = sqlQuery;
        dbCommand.CommandType = CommandType.Text;
        return dbCommand;
    }

    #region 增加参数
    public void AddParameterCollection(SqlCommand cmd, SqlParameterCollection dbParameterCollection)
    {
        foreach (SqlParameter dbParameter in dbParameterCollection)
        {
            cmd.Parameters.Add(dbParameter);
        }
    }
    public void AddOutParameter(SqlCommand cmd, string parameterName, DbType dbType, int size)
    {
        SqlParameter dbParameter = cmd.CreateParameter();
        dbParameter.DbType = dbType;
        dbParameter.ParameterName = parameterName;
        dbParameter.Size = size;
        dbParameter.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(dbParameter);
    }
    public void AddInParameter(SqlCommand cmd, string parameterName, DbType dbType, object value)
    {
        SqlParameter dbParameter = cmd.CreateParameter();
        dbParameter.DbType = dbType;
        dbParameter.ParameterName = parameterName;
        dbParameter.Value = value;
        dbParameter.Direction = ParameterDirection.Input;
        cmd.Parameters.Add(dbParameter);
    }
    public void AddReturnParameter(SqlCommand cmd, string parameterName, DbType dbType)
    {
        SqlParameter dbParameter = cmd.CreateParameter();
        dbParameter.DbType = dbType;
        dbParameter.ParameterName = parameterName;
        dbParameter.Direction = ParameterDirection.ReturnValue;
        cmd.Parameters.Add(dbParameter);
    }
    public SqlParameter GetParameter(SqlCommand cmd, string parameterName)
    {
        return cmd.Parameters[parameterName];
    }

    #endregion

    #region 执行
    public DataSet ExecuteDataSet(SqlCommand cmd)
    {

        SqlDataAdapter dbDataAdapter = new SqlDataAdapter(cmd);
        dbDataAdapter.SelectCommand = cmd;
        DataSet ds = new DataSet();
        dbDataAdapter.Fill(ds);
        return ds;
    }

    public DataTable ExecuteDataTable(SqlCommand cmd)
    {
        SqlDataAdapter dbDataAdapter = new SqlDataAdapter(cmd);
        dbDataAdapter.SelectCommand = cmd;
        DataTable dataTable = new DataTable();
        dbDataAdapter.Fill(dataTable);
        return dataTable;
    }

    public SqlDataReader ExecuteReader(SqlCommand cmd)
    {
        if (cmd.Connection.State != ConnectionState.Open)
        {
            cmd.Connection.Open();
        }
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        return reader;
    }
    public int ExecuteNonQuery(SqlCommand cmd)
    {
        if (cmd.Connection.State != ConnectionState.Open)
        {
            cmd.Connection.Open();
        }
        int ret = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        return ret;
    }

    public object ExecuteScalar(SqlCommand cmd)
    {
        if (cmd.Connection.State != ConnectionState.Open)
        {
            cmd.Connection.Open();
        }
        object ret = cmd.ExecuteScalar();
        cmd.Connection.Close();
        return ret;
    }
    #endregion


}

#region 事务
public class Trans : IDisposable
{
    private SqlConnection conn;
    private SqlTransaction dbTrans;
    public SqlConnection DbConnection
    {
        get { return this.conn; }
    }
    public SqlTransaction DbTrans
    {
        get { return this.dbTrans; }
    }

    public Trans()
    {
        conn = DBComm.CreateConnection();
        conn.Open();
        dbTrans = conn.BeginTransaction();
    }
    public Trans(string connectionString)
    {
        conn = DBComm.CreateConnection(connectionString);
        conn.Open();
        dbTrans = conn.BeginTransaction();
    }
    public void Commit()
    {
        dbTrans.Commit();
        this.Colse();
    }

    public void RollBack()
    {
        dbTrans.Rollback();
        this.Colse();
    }

    public void Dispose()
    {
        this.Colse();
    }

    public void Colse()
    {
        if (conn.State == System.Data.ConnectionState.Open)
        {
            conn.Close();
        }
    }
}
#endregion