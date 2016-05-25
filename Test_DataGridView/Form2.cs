using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Test_DataGridView.DB;


namespace Test_DataGridView
{
    public partial class Form2 : Form
    {

        public object temp;

        string connAFengDate = ConfigurationManager.ConnectionStrings["str"].ConnectionString;



        public Form2()
        {
            InitializeComponent();
        }


        //使用原生方法新增信息
        private void button1_Click(object sender, EventArgs e)
        {
            //string od = "一";
            //string num = "2";
            //string name = "优酷";

            int n = 0;
            string sql = "insert into Table_3(name,sex,age) values (@name,@sex,@age)";

            if (textBoxID.Text.Trim() == "" || textBoxSex.Text == "" || textBoxAge.Text == "")
            {
                MessageBox.Show("信息请填写完整");
                return;
            }

            SqlParameter[] param ={
                                     new SqlParameter("@name",textBoxID.Text),
                                     new SqlParameter("@sex",textBoxSex.Text),
                                     new SqlParameter("@age",int.Parse(textBoxAge.Text)),
                                   
                                 };

            SqlConnection conn = new SqlConnection(connAFengDate);
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            cmd.Parameters.AddRange(param);
            n = cmd.ExecuteNonQuery();
            if (n == 0)
            {
                MessageBox.Show("添加失败!");
                return;
            }
            else if (n > 0)
            {
                MessageBox.Show("添加成功!");
            }
            conn.Close();
            this.Refresh();

            //string[] row = { };
            //this.dataGridView1.Rows.Add(row);
        }



        void saveDate()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                MessageBox.Show(temp.ToString());

            }
            else
            {
                MessageBox.Show("null");

            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        //鼠标选中单元格提取信息
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                temp = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            }
            catch
            {

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //使用EF新增信息
        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new TestEntities())
            {
 
                var t2 = new Table_3
                {
                    name = textBoxID.Text,
                    sex = textBoxSex.Text,
                    age = int.Parse(textBoxAge.Text)
                };

                db.Table_3.Add(t2);
                db.SaveChanges();
            }

        }

        //使用EF删除指定ID的行
        private void button4_Click(object sender, EventArgs e)
        {
            using (var db = new TestEntities())
            {
                var t2 = new Table_3 { ID = int.Parse(textBoxDelID.Text) };
                db.Table_3.Attach(t2);
                db.Table_3.Remove(t2);
                db.SaveChanges();
            }
        }


        //使用EF修改信息
        private void button5_Click(object sender, EventArgs e)
        {
            using (var db = new TestEntities())
            {
                using (var scope = new TransactionScope())
                {
                    var user = new Table_3
                    {
                        ID = int.Parse(textBox1.Text),
                        name = textBoxID.Text,
                        sex = textBoxSex.Text,
                        age = int.Parse(textBoxAge.Text)

                    };

                    db.Table_3.Attach(user);
                    var setEntry = ((IObjectContextAdapter)db).ObjectContext.ObjectStateManager.GetObjectStateEntry(user);
                    setEntry.SetModifiedProperty("name");
                    setEntry.SetModifiedProperty("age");
                    setEntry.SetModifiedProperty("sex");

                    db.SaveChanges();

                    scope.Complete();
                }
            }
        }









    }
    }

