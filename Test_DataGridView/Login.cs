using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Test_DataGridView
{
    public partial class Login : Form
    {

        //private bool isConn = false;

        public Login()
        {
            InitializeComponent();
        }

        string connAFengDate = ConfigurationManager.ConnectionStrings["str"].ConnectionString;


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connAFengDate))
            {
                string sql = "select passWord from TestAccount where userName='" + textName.Text + "'";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        //isConn = true;
                    }
                    catch {
                        labelConn.Text = "连接错误,是否开启数据库?";
                        return;
                    }

                    //finally
                    //{
                    //    if (isConn)
                    //        MessageBox.Show("已经连接");
                    //    else
                    //        MessageBox.Show("连接失败");
                    //}
                  

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            string pwd = sdr.GetString(0).Trim();
                            if (pwd == textPass.Text)
                            {
                                MessageBox.Show("登录成功");
                                Form2 form2 = new Form2();
                                form2.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("密码或者用户名字错误!");
                                textPass.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户名字不存在!");
                            textName.Text = "";
                        }

                    }
                }
            }

            


        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textPass.Focus();
            }
        }

        private void textPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }










    }
}
