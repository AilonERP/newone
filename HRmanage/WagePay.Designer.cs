namespace HRmanage
{
    partial class WagePay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.txtque = new System.Windows.Forms.TextBox();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.月份 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总和 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工资 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.奖金 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.医疗保险 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住房公积金 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.扣除 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.个人所得税 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.养老 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbDep2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 477);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbDept);
            this.tabPage1.Controls.Add(this.txtque);
            this.tabPage1.Controls.Add(this.dtpicker);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvPay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "单个发放";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(43, 29);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(121, 20);
            this.cmbDept.TabIndex = 10;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // txtque
            // 
            this.txtque.Location = new System.Drawing.Point(507, 103);
            this.txtque.Name = "txtque";
            this.txtque.Size = new System.Drawing.Size(200, 21);
            this.txtque.TabIndex = 9;
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(507, 23);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(200, 21);
            this.dtpicker.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "缺勤天数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "月份：";
            // 
            // lbname
            // 
            this.lbname.FormattingEnabled = true;
            this.lbname.ItemHeight = 12;
            this.lbname.Location = new System.Drawing.Point(304, 27);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(120, 136);
            this.lbname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "员工：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(8, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(142, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "导出";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "部门：";
            // 
            // dgvPay
            // 
            this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选择,
            this.月份,
            this.员工,
            this.总和,
            this.工资,
            this.奖金,
            this.医疗保险,
            this.住房公积金,
            this.扣除,
            this.个人所得税,
            this.养老});
            this.dgvPay.Location = new System.Drawing.Point(6, 191);
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.RowTemplate.Height = 23;
            this.dgvPay.Size = new System.Drawing.Size(742, 206);
            this.dgvPay.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbMonth);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbDep2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "批量发放";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // 选择
            // 
            this.选择.HeaderText = "选择";
            this.选择.Name = "选择";
            this.选择.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.选择.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 月份
            // 
            this.月份.DataPropertyName = "YearMonth";
            this.月份.HeaderText = "月份";
            this.月份.Name = "月份";
            // 
            // 员工
            // 
            this.员工.DataPropertyName = "EmployeeName";
            this.员工.HeaderText = "员工";
            this.员工.Name = "员工";
            // 
            // 总和
            // 
            this.总和.DataPropertyName = "Total";
            this.总和.HeaderText = "总和";
            this.总和.Name = "总和";
            // 
            // 工资
            // 
            this.工资.DataPropertyName = "Salary";
            this.工资.HeaderText = "工资";
            this.工资.Name = "工资";
            // 
            // 奖金
            // 
            this.奖金.DataPropertyName = "Bouns";
            this.奖金.HeaderText = "奖金";
            this.奖金.Name = "奖金";
            // 
            // 医疗保险
            // 
            this.医疗保险.DataPropertyName = "Medicare";
            this.医疗保险.HeaderText = "医疗保险";
            this.医疗保险.Name = "医疗保险";
            // 
            // 住房公积金
            // 
            this.住房公积金.DataPropertyName = "AccumulationFund";
            this.住房公积金.HeaderText = "住房公积金";
            this.住房公积金.Name = "住房公积金";
            // 
            // 扣除
            // 
            this.扣除.DataPropertyName = "Deduct";
            this.扣除.HeaderText = "扣除";
            this.扣除.Name = "扣除";
            // 
            // 个人所得税
            // 
            this.个人所得税.DataPropertyName = "Tax";
            this.个人所得税.HeaderText = "个人所得税";
            this.个人所得税.Name = "个人所得税";
            // 
            // 养老
            // 
            this.养老.DataPropertyName = "Endowment";
            this.养老.HeaderText = "养老";
            this.养老.Name = "养老";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(742, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbDep2
            // 
            this.cbDep2.FormattingEnabled = true;
            this.cbDep2.Location = new System.Drawing.Point(73, 41);
            this.cbDep2.Name = "cbDep2";
            this.cbDep2.Size = new System.Drawing.Size(121, 20);
            this.cbDep2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "部门：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "月份：";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(435, 41);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 20);
            this.cbMonth.TabIndex = 4;
            // 
            // WagePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "WagePay";
            this.Text = "WagePay";
            this.Load += new System.EventHandler(this.WagePay_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtque;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月份;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总和;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工资;
        private System.Windows.Forms.DataGridViewTextBoxColumn 奖金;
        private System.Windows.Forms.DataGridViewTextBoxColumn 医疗保险;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住房公积金;
        private System.Windows.Forms.DataGridViewTextBoxColumn 扣除;
        private System.Windows.Forms.DataGridViewTextBoxColumn 个人所得税;
        private System.Windows.Forms.DataGridViewTextBoxColumn 养老;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDep2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}