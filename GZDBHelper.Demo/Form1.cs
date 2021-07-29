using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZDBHelper.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 数据库服务器
            string server = txt_MSSQL_Server.Text;
            // 用户名
            string user = txt__MSSQL_user.Text;
            // 密码
            string pwd = txt_MSSQL_pwd.Text;
            // 数据库名称
            string dbname = txt_MSSQL_dbName.Text;

            // 生成数据库连接字符串
            var connStr = GZDBHelper.ConnectionStrings.BuildMSSQLConnectionString(server, dbname, user, pwd);

            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                conn.Close();
                MessageBox.Show("连接成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
