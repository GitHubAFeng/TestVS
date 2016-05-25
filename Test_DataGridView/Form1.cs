using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_DataGridView
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“testDataSet1.Table_2”中。您可以根据需要移动或删除它。
            this.table_2TableAdapter.Fill(this.testDataSet1.Table_2);
            // TODO:  这行代码将数据加载到表“testDataSet.Table_1”中。您可以根据需要移动或删除它。
            this.table_1TableAdapter.Fill(this.testDataSet.Table_1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
