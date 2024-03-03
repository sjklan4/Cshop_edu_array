//using HOD_EOL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class Db
{
    #region DB 데이터 처리
    //Initial Catalog : DB이름을 뜻함 - 지정할 DB이름
    public static readonly string ConnStr = $@"Data Source=localhost;Initial Catalog=printsystem;Persist Security Info=True;User ID=sa;Password=x;TimeOut = 5;Asynchronous Processing=true;";
    //public static readonly string ConnStr = $@"Data Source=192.168.100.95;Initial Catalog=VISION;Persist Security Info=True;User ID=sa;Password=x;TimeOut = 5;Asynchronous Processing=true;";
    //public static readonly string ConnStr = $@"Data Source=localhost;Initial Catalog=FDS_INSPECTOR;Persist Security Info=True;User ID=sa;Password=x;TimeOut = 5;Asynchronous Processing=true;";
    //public static readonly string ConnStr = $@"Data Source=SILEE-ASUS\MSSQLSERVER14;Initial Catalog=FDS_INSPECTOR;Persist Security Info=True;User ID=sa;Password=x;TimeOut = 5;";
    //public static readonly string M_ConnStr = $@"Data Source={MAIN.MAIN_IP};Initial Catalog=S_WheelDB;Persist Security Info=True;User ID=sa;Password=x;TimeOut = 5;Asynchronous Processing=true;";
    // public static readonly string ConnStr = $@"Data Source=DESKTOP-UEKQDPN\SQLEXPRESS;Initial Catalog=LeakVision;Persist Security Info=True;User ID=sa;Password=x;TimeOut = 5;Asynchronous Processing=true;";


    public static bool DbConnectionCheck()
    {
        SqlConnection sqlConn = new SqlConnection(ConnStr);
        bool Ret = false;
        try
        {
            sqlConn.Open();
            Ret = true;
        }
        catch (SqlException se)
        {
            Console.WriteLine($"Db - {se.Message}");
          
        }
        finally
        {
            sqlConn.Close();
           
        }
        return Ret;
    }

    public static string[] GETTABLES()
    {
        List<string> result = new List<string>();
        using (SqlConnection SqlConn = new SqlConnection(ConnStr))
        {
            try
            {
                SqlConn.Open();
                using (SqlCommand comm = new SqlCommand("select * from sys.tables", SqlConn) { CommandType = CommandType.Text })
                {
                    DataTable iDT = new DataTable();
                    if (SqlConn.State == ConnectionState.Open)
                    {
                        new SqlDataAdapter(comm).Fill(iDT);
                        foreach (DataRow row in iDT.Rows)
                        {
                            result.Add((string)row["name"]);
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return null;
            }finally
            {
                SqlConn.Close();
            }
        }
        return result.ToArray();
    }



    



    /// <summary> 파라메터 설정 파라메터명과 값을 함께 따로 전달하는 경우 </summary>
    ///
    public static SqlParameter[] PARAMS(string[] name, string[] value)
    {
        List<SqlParameter> sqlprm = new List<SqlParameter>();
        for (int i = 0; i < name.Length; i++)
        {
            sqlprm.Add(new SqlParameter(name[i], value[i]));
        }
        return sqlprm.ToArray();
    }
    /// <summary> 파라메터 설정 파라메터명과 값을 함께 따로 전달하는 경우 </summary>
    ///
    public static SqlParameter[] PARAMS(string[] name, object[] value)
    {
        List<SqlParameter> sqlprm = new List<SqlParameter>();
        for (int i = 0; i < name.Length; i++)
        {
            sqlprm.Add(new SqlParameter(name[i], value[i]));
        }
        return sqlprm.ToArray();
    }

     

    /// <summary> 파라메터 설정 파라메터명과 값을 함께 따로 전달하는 경우 </summary>
    public static SqlParameter[] PARAMS(Dictionary<string, object> param)
    {
        List<SqlParameter> sqlprm = new List<SqlParameter>();
        foreach (var item in param)
        {
            sqlprm.Add(new SqlParameter(item.Key, item.Value));
        }
        return sqlprm.ToArray();
    }


    /// <summary> 파라메터 설정 파라메터명과 값을 함께 전달할 경우. (이름, 값, 이름, 값, 이름, 값....) </summary>
    public static SqlParameter[] PARAMS(object[] param)
    {
        List<SqlParameter> sqlprm = new List<SqlParameter>();
        for (int i = 0; i < param.Length; i = i + 2)
        {
            sqlprm.Add(new SqlParameter(param[i].ToString(), param[i + 1]));
        }
        return sqlprm.ToArray();
    }


    /// <summary> 프로시저를 호출하여 데이터셋을 반환합니다. </summary>
    public static DataSet RETRIEVES(string ProcName, SqlParameter[] Param = null)
    {
        using (SqlConnection SqlConn = new SqlConnection(ConnStr))
        {
            try
            {
                SqlConn.Open();
                using (SqlCommand comm = new SqlCommand(ProcName, SqlConn) { CommandType = CommandType.StoredProcedure })
                {
                    if (Param != null) comm.Parameters.AddRange(Param);
                    DataSet iDS = new DataSet();
                    if (SqlConn.State == ConnectionState.Open) new SqlDataAdapter(comm).Fill(iDS);
                    return iDS;
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return null;
            }finally
            {
                SqlConn.Close();
            }
        }
    }

    /// <summary> 프로시저를 호출하여 데이터테이블을 반환합니다. </summary>
    public static DataTable RETRIEVE(string ProcName, SqlParameter[] Param = null)
    {
        using (SqlConnection sqlConn = new SqlConnection(ConnStr))
        {
            try
            {
                sqlConn.Open();

                using (SqlCommand comm = new SqlCommand(ProcName, sqlConn) { CommandType = CommandType.StoredProcedure })
                {
                    if (Param != null) comm.Parameters.AddRange(Param);
                    DataTable iTable = new DataTable();
                    if (sqlConn.State == ConnectionState.Open) new SqlDataAdapter(comm).Fill(iTable);
                    return iTable;
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return null;
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }

    /// <summary> 프로시저를 호출하여 데이터테이블을 반환합니다. </summary>
    public static DataTable RETRIEVESQL(string Sql, SqlParameter[] Param = null)
    {
        using (SqlConnection sqlConn = new SqlConnection(ConnStr))
        {
            try
            {
                sqlConn.Open();
                using (SqlCommand comm = new SqlCommand(Sql, sqlConn) { CommandType = CommandType.Text })
                {
                    if (Param != null) comm.Parameters.AddRange(Param);
                    DataTable iTable = new DataTable();
                    if (sqlConn.State == ConnectionState.Open) new SqlDataAdapter(comm).Fill(iTable);
                    return iTable;
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return null;
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }

    public static DataTable M_RETRIEVESQL(string Sql, SqlParameter[] Param = null)
    {
        using (SqlConnection sqlConn = new SqlConnection(M_ConnStr))
        {
            try
            {
                sqlConn.Open();
                using (SqlCommand comm = new SqlCommand(Sql, sqlConn) { CommandType = CommandType.Text })
                {
                    if (Param != null) comm.Parameters.AddRange(Param);
                    DataTable iTable = new DataTable();
                    if (sqlConn.State == ConnectionState.Open) new SqlDataAdapter(comm).Fill(iTable);
                    return iTable;
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return null;
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }

    public static object SCALARSQL(string sql, SqlParameter[] Param = null)
    {
        using (SqlConnection SqlConn = new SqlConnection(ConnStr))
        {
            try
            {

                SqlConn.Open();
                using (SqlCommand comm = new SqlCommand(sql, SqlConn) { CommandType = CommandType.Text })
                {
                    if (Param != null) comm.Parameters.AddRange(Param);
                    return comm.ExecuteScalar();
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return null;
            }
            finally
            {
                SqlConn.Close();
            }
        }
    }

    public static async Task<object> SCALARSQLAsync(string sql, SqlParameter[] Param = null)
    {
        using (SqlConnection SqlConn = new SqlConnection(ConnStr))
        {
            await SqlConn.OpenAsync();
            using (SqlCommand comm = new SqlCommand(sql, SqlConn) { CommandType = CommandType.Text })
            {
                if (Param != null) comm.Parameters.AddRange(Param);
                return await comm.ExecuteScalarAsync();
            }
        }
    }

    public static byte[] ReadFileSQL(string sql, SqlParameter[] Param = null)
    {
        List<byte> rBytes = new List<byte>();
        using (SqlConnection SqlConn = new SqlConnection(ConnStr))
        {
            try
            {
                SqlConn.Open();

                int buffsize = 256;
                byte[] outbyte = new byte[buffsize];
                long retval;
                long startindex = 0;
                using (SqlCommand comm = new SqlCommand(sql, SqlConn) { CommandType = CommandType.Text })
                {
                    if (Param != null) comm.Parameters.AddRange(Param);
                    using (SqlDataReader Reader = comm.ExecuteReader(CommandBehavior.SequentialAccess))
                    {
                        if (Reader.HasRows)
                        {
                            while (Reader.Read())
                            {
                                retval = Reader.GetBytes(1, startindex, outbyte, 0, buffsize);
                                while (retval == buffsize)
                                {
                                    rBytes.AddRange(outbyte);
                                    startindex += buffsize;
                                    retval = Reader.GetBytes(1, startindex, outbyte, 0, buffsize);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return null;
            }
            finally
            {
                SqlConn.Close();
            }
        }
        return rBytes.Count > 0 ? rBytes.ToArray() : null;
    }

    /// <summary> 프로시저를 호출하여 스칼라값을 반환합니다. </summary>
    public static object SCALAR(string ProcName, SqlParameter[] Param = null)
    {
        using (SqlConnection SqlConn = new SqlConnection(ConnStr))
        {
            try
            {
                SqlConn.Open();
                using (SqlCommand comm = new SqlCommand(ProcName, SqlConn) { CommandType = CommandType.StoredProcedure })
                {
                    if (Param != null) comm.Parameters.AddRange(Param);
                    return comm.ExecuteScalar();
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return null;
            }
            finally
            {
                SqlConn.Close();
            }
        }
    }

    /// <summary> 프로시저를 호출하여 영향받는 행의 수를 반환합니다. </summary>
    public static int EXECUTE(string ProcName, SqlParameter[] Param = null)
    {
        using (SqlConnection SqlConn = new SqlConnection(ConnStr))
        {
            try
            {
                SqlConn.Open();
                using (SqlCommand comm = new SqlCommand(ProcName, SqlConn) { CommandType = CommandType.StoredProcedure })
                {
                    if (Param != null) comm.Parameters.AddRange(Param);
                    return (SqlConn.State == ConnectionState.Open) ? comm.ExecuteNonQuery() : 0;
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return 0;
            }
            finally
            {
                SqlConn.Close();
            }
        }
    }

   

    /// <summary> 프로시저를 호출하여 영향받는 행의 수를 반환합니다. </summary>
    public static int EXECUTESQL(string sql, SqlParameter[] Param = null)
    {
        using (SqlConnection SqlConn = new SqlConnection(ConnStr))
        {
            try
            {
                SqlConn.Open();
                using (SqlCommand comm = new SqlCommand(sql, SqlConn) { CommandType = CommandType.Text })
                {
                    if (Param != null) comm.Parameters.AddRange(Param);
                    return (SqlConn.State == ConnectionState.Open) ? comm.ExecuteNonQuery() : 0;
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return 0;
            }
            finally
            {
                SqlConn.Close();
            }
        }
    }

    /// <summary> 프로시저를 호출하여 성공여부를 반환합니다. </summary>
    public static bool EXECUTE2(string ProcName, SqlParameter[] Param = null)
    {
        using (SqlConnection SqlConn = new SqlConnection(ConnStr))
        {
            try
            {

                SqlConn.Open();
                using (SqlCommand comm = new SqlCommand(ProcName, SqlConn) { CommandType = CommandType.StoredProcedure })
                {
                    if (Param != null) comm.Parameters.AddRange(Param);
                    return comm.ExecuteNonQuery() != 0;
                }

            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return false;
            }
            finally
            {
                SqlConn.Close();
            }
        }
    }

    ///// <summary> 쿼리를 실행하여 데이터테이블을 반환합니다. </summary>
    public static DataTable RETRIEVE(string pSql)
    {
        using (SqlConnection sqlConn = new SqlConnection(ConnStr))
        {
            DataTable iTable = new DataTable();
            try
            {
                sqlConn.Open();

                if (sqlConn.State == ConnectionState.Open) new SqlDataAdapter(pSql, sqlConn).Fill(iTable);
                return iTable;
            }
            catch (SqlException se)
            {
                Console.WriteLine($"Db - {se.Message}");
                return null;
            }
            finally
            {
                sqlConn.Close();
            }
        }
            
    }
    #endregion
}

