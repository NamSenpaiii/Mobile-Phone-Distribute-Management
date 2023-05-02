using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Model
{
    public class Connection
    {
        private static SqlConnection cn;
        public static void connect()
        {
            string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            cn = new SqlConnection(strConn);
            cn.Open();

        }

        public static void actionQuery(string sql, SqlParameter[] parameters)
        {
            try
            {
                connect();
                using (SqlTransaction transaction = cn.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Some Error Occured", e);
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable selectQuery(string sql, SqlParameter[] parameters)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddRange(parameters);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                return dt;
            }catch(Exception e)
            {
                throw new Exception("Some Error Occured",e);
            }
            finally
            {
                cn.Close();
            }
        }

        public static SqlConnection getConnection()
        {
            return cn;
        }
    }
}
