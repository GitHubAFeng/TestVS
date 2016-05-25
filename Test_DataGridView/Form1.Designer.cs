namespace Test_DataGridView
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.条码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名规格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金额DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new Test_DataGridView.TestDataSet1();
            this.testDataSet = new Test_DataGridView.TestDataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter = new Test_DataGridView.TestDataSetTableAdapters.Table_1TableAdapter();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_2TableAdapter = new Test_DataGridView.TestDataSet1TableAdapters.Table_2TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序DataGridViewTextBoxColumn,
            this.货号DataGridViewTextBoxColumn,
            this.条码DataGridViewTextBoxColumn,
            this.品名规格DataGridViewTextBoxColumn,
            this.数量DataGridViewTextBoxColumn,
            this.单价DataGridViewTextBoxColumn,
            this.金额DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(744, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 序DataGridViewTextBoxColumn
            // 
            this.序DataGridViewTextBoxColumn.DataPropertyName = "序";
            this.序DataGridViewTextBoxColumn.HeaderText = "序";
            this.序DataGridViewTextBoxColumn.Name = "序DataGridViewTextBoxColumn";
            // 
            // 货号DataGridViewTextBoxColumn
            // 
            this.货号DataGridViewTextBoxColumn.DataPropertyName = "货号";
            this.货号DataGridViewTextBoxColumn.HeaderText = "货号";
            this.货号DataGridViewTextBoxColumn.Name = "货号DataGridViewTextBoxColumn";
            // 
            // 条码DataGridViewTextBoxColumn
            // 
            this.条码DataGridViewTextBoxColumn.DataPropertyName = "条码";
            this.条码DataGridViewTextBoxColumn.HeaderText = "条码";
            this.条码DataGridViewTextBoxColumn.Name = "条码DataGridViewTextBoxColumn";
            // 
            // 品名规格DataGridViewTextBoxColumn
            // 
            this.品名规格DataGridViewTextBoxColumn.DataPropertyName = "品名规格";
            this.品名规格DataGridViewTextBoxColumn.HeaderText = "品名规格";
            this.品名规格DataGridViewTextBoxColumn.Name = "品名规格DataGridViewTextBoxColumn";
            // 
            // 数量DataGridViewTextBoxColumn
            // 
            this.数量DataGridViewTextBoxColumn.DataPropertyName = "数量";
            this.数量DataGridViewTextBoxColumn.HeaderText = "数量";
            this.数量DataGridViewTextBoxColumn.Name = "数量DataGridViewTextBoxColumn";
            // 
            // 单价DataGridViewTextBoxColumn
            // 
            this.单价DataGridViewTextBoxColumn.DataPropertyName = "单价";
            this.单价DataGridViewTextBoxColumn.HeaderText = "单价";
            this.单价DataGridViewTextBoxColumn.Name = "单价DataGridViewTextBoxColumn";
            // 
            // 金额DataGridViewTextBoxColumn
            // 
            this.金额DataGridViewTextBoxColumn.DataPropertyName = "金额";
            this.金额DataGridViewTextBoxColumn.HeaderText = "金额";
            this.金额DataGridViewTextBoxColumn.Name = "金额DataGridViewTextBoxColumn";
            // 
            // table2BindingSource
            // 
            this.table2BindingSource.DataMember = "Table_2";
            this.table2BindingSource.DataSource = this.testDataSet1;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "TestDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.testDataSet;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // table_2TableAdapter
            // 
            this.table_2TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private TestDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private TestDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource table2BindingSource;
        private TestDataSet1TableAdapters.Table_2TableAdapter table_2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 条码DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名规格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金额DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

