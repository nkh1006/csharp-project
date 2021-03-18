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
using System.Xml.Linq;

namespace mssql_connect
{
    public partial class Form1 : Form
    {
        private string _dbConnect;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string dbHost = txt_host.Text;
            string dbName = txt_name.Text;
            string dbId = txt_id.Text;
            string dbPass = txt_pass.Text;

            if (string.IsNullOrWhiteSpace(dbHost))
            {
                MessageBox.Show("서버 아이피를 입력해주세요");
                txt_host.Focus();
            } 
            else if (string.IsNullOrWhiteSpace(dbName))
            {
                MessageBox.Show("데이터베이스 이름을 입력해주세요");
                txt_name.Focus();
            }
            else if (string.IsNullOrWhiteSpace(dbId))
            {
                MessageBox.Show("계정 아이디를 입력해주세요");
                txt_id.Focus();
            }
            else if (string.IsNullOrWhiteSpace(dbPass))
            {
                MessageBox.Show("계정 패스워드를 입력해주세요");
                txt_pass.Focus();
            }
            else
            {
                var dbConnectText = new List<string>
                {
                    string.Concat("Data Source=", dbHost),
                    string.Concat("Initial Catalog=", dbName),
                    string.Concat("User ID=", dbId),
                    string.Concat("Password=", dbPass)
                };

                _dbConnect = string.Join(";", dbConnectText);

                using (var conn = new SqlConnection(_dbConnect))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT GETDATE()";
                        conn.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            this.result.Text = "연결 성공";
                        }
                        else
                        {
                            this.result.Text = "연결 실패";
                        }
                    }
                    catch (Exception)
                    {
                        return;
                    }
                    finally
                    {
                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
    }
}
