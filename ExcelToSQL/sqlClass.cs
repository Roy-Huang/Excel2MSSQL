using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToSQL
{
    class sqlClass
    {
        string StrSqlConn = "";
        SqlConnection SqlConn;
        public bool Sql_conn(List<string> DB_info, out string strmsg)
        {

            StrSqlConn = string.Format(@"
            Data Source={0};Initial Catalog={1};User ID={2};Password={3}",
            DB_info[0],
            DB_info[1],
            DB_info[2],
            DB_info[3]);

            SqlConn = new SqlConnection(StrSqlConn);
            try
            {
                SqlConn.Open();
                strmsg = "已連線";
                return true;
            }
            catch (SqlException ex)
            { strmsg = ex.Message.ToString(); }
            catch (Exception ex)
            { strmsg = ex.Message.ToString(); }
            return false;
        }
        public void Sql_Close()
        {
            if (SqlConn == null) return;
            if (SqlConn.State == ConnectionState.Open)
            {
                SqlConn.Close();
            }
        }
        public bool UPDATE_Excel_To_SQL_Table(DataRow dr, List<string> DB_info, List<string> Name, out string strmsg)
        {
            try
            {
                strmsg = "";
                if (SqlConn == null || SqlConn.State == ConnectionState.Closed) Sql_conn(DB_info, out strmsg);
                if (SqlConn.State == ConnectionState.Open)
                {
                    string str_Name = string.Empty;
                    String Str_Name = String.Empty;
                    for (int k = 0; k < Name.Count; k++)
                    {
                        str_Name += Name[k] + ",";
                        Str_Name += "@" + Name[k] + ",";
                    }
                    str_Name = str_Name.Remove(str_Name.Length - 1, 1);
                    Str_Name = Str_Name.Remove(Str_Name.Length - 1, 1);
                    String Str_Command = @"INSERT INTO " + DB_info[4] + "(" + str_Name + ")" + "VALUES(" + Str_Name + ");";
                    DataSet ds = new DataSet();
                    SqlCommand command = new SqlCommand(Str_Command, SqlConn);
                    command.CommandType = CommandType.Text;
                    for(int i = 0; i < Name.Count; i++)
                    {
                        command.Parameters.Add("@" + Name[i], SqlDbType.VarChar);
                        command.Parameters["@" + Name[i]].Value = dr.ItemArray[i].ToString();
                    }
                    SqlDataAdapter sdmDataAdpter = new SqlDataAdapter(command);
                    sdmDataAdpter.Fill(ds, "Table");
                    strmsg = "上傳完成";
                    return true;
                }
            }
            catch (Exception ex)
            { strmsg = ex.Message.ToString(); }
            return false;
        }
        public DataTable SELECT_TABLE(List<string> DB_info, out string strmsg)
        {
            try
            {
                strmsg = "";
                if (SqlConn == null || SqlConn.State == ConnectionState.Closed) Sql_conn(DB_info, out strmsg);
                if (SqlConn.State == ConnectionState.Open)
                {
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    SqlCommand command = new SqlCommand(@"SELECT * FROM " + DB_info[4], SqlConn);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    sda.Fill(ds, "Table");
                    dt = ds.Tables["Table"];
                    return dt;
                }
            }catch(Exception ex)
            {
                strmsg = ex.Message.ToString();
            }
            return null;
        }

    }
}
