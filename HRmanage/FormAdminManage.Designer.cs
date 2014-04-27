namespace HRmanage
{
    partial class FormAdminManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cbDepart = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbemployee = new System.Windows.Forms.ListBox();
            this.btDelect = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvAddAdmin = new System.Windows.Forms.DataGridView();
            this.登录ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所属部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPassWord);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.cbDepart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbemployee);
            this.groupBox1.Location = new System.Drawing.Point(12, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增管理员";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(312, 108);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(100, 21);
            this.txtPassWord.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(312, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 6;
            // 
            // cbDepart
            // 
            this.cbDepart.FormattingEnabled = true;
            this.cbDepart.Location = new System.Drawing.Point(71, 49);
            this.cbDepart.Name = "cbDepart";
            this.cbDepart.Size = new System.Drawing.Size(121, 20);
            this.cbDepart.TabIndex = 5;
            this.cbDepart.SelectedIndexChanged += new System.EventHandler(this.cbDepart_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "员工：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "所有部门：";
            // 
            // lbemployee
            // 
            this.lbemployee.FormattingEnabled = true;
            this.lbemployee.ItemHeight = 12;
            this.lbemployee.Location = new System.Drawing.Point(71, 117);
            this.lbemployee.Name = "lbemployee";
            this.lbemployee.Size = new System.Drawing.Size(120, 88);
            this.lbemployee.TabIndex = 0;
            // 
            // btDelect
            // 
            this.btDelect.Location = new System.Drawing.Point(307, 464);
            this.btDelect.Name = "btDelect";
            this.btDelect.Size = new System.Drawing.Size(75, 23);
            this.btDelect.TabIndex = 9;
            this.btDelect.Text = "删除";
            this.btDelect.UseVisualStyleBackColor = true;
            this.btDelect.Click += new System.EventHandler(this.btDelect_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvAddAdmin
            // 
            this.dgvAddAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.登录ID,
            this.密码,
            this.员工姓名,
            this.所属部门});
            this.dgvAddAdmin.Location = new System.Drawing.Point(12, 12);
            this.dgvAddAdmin.Name = "dgvAddAdmin";
            this.dgvAddAdmin.RowTemplate.Height = 23;
            this.dgvAddAdmin.Size = new System.Drawing.Size(486, 222);
            this.dgvAddAdmin.TabIndex = 11;
            // 
            // 登录ID
            // 
            this.登录ID.DataPropertyName = "LoginId";
            this.登录ID.HeaderText = "登录ID";
            this.登录ID.Name = "登录ID";
            // 
            // 密码
            // 
            this.密码.DataPropertyName = "Password";
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            // 
            // 员工姓名
            // 
            this.员工姓名.DataPropertyName = "EmployeeName";
            this.员工姓名.HeaderText = "员工姓名";
            this.员工姓名.Name = "员工姓名";
            // 
            // 所属部门
            // 
            this.所属部门.DataPropertyName = "DictName";
            this.所属部门.HeaderText = "所属部门";
            this.所属部门.Name = "所属部门";
            // 
            // FormAdminManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 499);
            this.Controls.Add(this.dgvAddAdmin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btDelect);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdminManage";
            this.Text = "管理员";
            this.Load += new System.EventHandler(this.FormAdminManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cbDepart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbemployee;
        private System.Windows.Forms.Button btDelect;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvAddAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登录ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属部门;
    }
}