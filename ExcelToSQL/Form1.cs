using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
namespace ExcelToSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt_ExcelData;
        private void tsb_folder_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel|*.xlsx";
            openFileDialog1.Title = "選擇檔案";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strPath = openFileDialog1.FileName;
                tsl_msg.Text = strPath;
                toolStripProgressBar1.Visible = true;
                dt_ExcelData = ImportExceltoDatatable(strPath);
                dgv_data.DataSource = dt_ExcelData;
                if (dgv_data != null)
                {
                    if (dgv_data.Rows.Count > 0)
                        tsb_upload.Enabled = true;
                }
                toolStripProgressBar1.Visible = false;
            }
        }
        public DataTable ImportExceltoDatatable(string filePath)
        {
            DataTable dt = new DataTable();

            try
            {
                using (XLWorkbook workBook = new XLWorkbook(filePath))
                {
                    IXLWorksheet workSheet = workBook.Worksheet(1);
                    bool firstRow = true;
                    toolStripProgressBar1.Value = 0;
                    toolStripProgressBar1.Maximum = workSheet.Rows().Count() + 1;
                    foreach (IXLRow row in workSheet.Rows())
                    {
                        if (firstRow)
                        {
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Columns.Add(cell.Value.ToString());
                            }
                            firstRow = false;
                        }
                        else
                        {
                            dt.Rows.Add();
                            int i = 0;

                            foreach (IXLCell cell in row.Cells(row.FirstCellUsed().Address.ColumnNumber, row.LastCellUsed().Address.ColumnNumber))
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                i++;
                            }
                        }
                        toolStripProgressBar1.Value++;
                    }
                }
            }
            catch (Exception ex)
            {
                tsl_msg.Text = ex.Message.ToString();
            }
            return dt;
        }
        private void tsb_upload_Click(object sender, EventArgs e)
        {
            List<string> DB_info = new List<string>();
            DB_info.Add(tb_ServerName.Text);
            DB_info.Add(tb_DBName.Text);
            DB_info.Add(tb_UserName.Text);
            DB_info.Add(tb_Pw.Text);
            DB_info.Add(tb_TableName.Text);

            if(DB_info.Contains(""))
                MessageBox.Show("please check DB info");
            else
            {
                List<string> TableName = Get_TABLEName(DB_info);
                if(TableName.Count != 0 && dgv_data.Columns.Count == TableName.Count)
                {
                    string strmsg = "";
                    sqlClass sql = new sqlClass();
                    sql.Sql_conn(DB_info, out strmsg);
                    foreach(DataRow dr in dt_ExcelData.Rows)
                    {
                        sql.UPDATE_Excel_To_SQL_Table(dr, DB_info, TableName, out strmsg);
                        tsl_msg.Text = strmsg;
                    }
                    sql.Sql_Close();
                }
            }
        }

        private List<string> Get_TABLEName(List<string> DB_info)
        {
            string strmsg = "";
            sqlClass sql = new sqlClass();
            sql.Sql_conn(DB_info, out strmsg);
            DataTable dt = sql.SELECT_TABLE(DB_info, out strmsg);
            List<string> columnName = new List<string>();
            foreach (DataColumn name in dt.Columns)
            {
                columnName.Add(name.ColumnName.ToString());
            }
            sql.Sql_Close();
            return columnName;
        }

        private void tsb_setting_Click(object sender, EventArgs e)
        {

        }
    }
}
