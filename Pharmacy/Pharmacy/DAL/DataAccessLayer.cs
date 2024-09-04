using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pharmacy.DAL
{
    internal class DataAccessLayer
    {
        SqlConnection sqlconnection ;

        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection("Server = DESKTOP-TCLVJQ7 ; Database = Pharmacy ;Trusted_Connection = True;");
        }
        public void open() 
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        public DataTable SelectData(string stored_procdure , SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procdure;
            cmd.Connection = sqlconnection;

            if(param != null)
            {
                for(int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;  
        }
        public void ExecuteCommand(string stored_procdure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procdure;
            cmd.Connection = sqlconnection;

            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            cmd.ExecuteNonQuery();
        }
    }
}
