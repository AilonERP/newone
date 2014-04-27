namespace HRmanage
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsWagePay = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmixgmm = new System.Windows.Forms.ToolStripMenuItem();
            this.基础数据管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工管理ToolStripMenuItem,
            this.tmsWagePay,
            this.用户管理ToolStripMenuItem,
            this.基础数据管理ToolStripMenuItem,
            this.tsmiClose,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewAdd,
            this.tsmiQueryEmp});
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            // 
            // tsmiNewAdd
            // 
            this.tsmiNewAdd.Name = "tsmiNewAdd";
            this.tsmiNewAdd.Size = new System.Drawing.Size(152, 22);
            this.tsmiNewAdd.Text = "新增员工";
            this.tsmiNewAdd.Click += new System.EventHandler(this.tsmiNewAdd_Click);
            // 
            // tsmiQueryEmp
            // 
            this.tsmiQueryEmp.Name = "tsmiQueryEmp";
            this.tsmiQueryEmp.Size = new System.Drawing.Size(152, 22);
            this.tsmiQueryEmp.Text = "查看员工信息";
            this.tsmiQueryEmp.Click += new System.EventHandler(this.tsmiQueryEmp_Click);
            // 
            // tmsWagePay
            // 
            this.tmsWagePay.Name = "tmsWagePay";
            this.tmsWagePay.Size = new System.Drawing.Size(68, 21);
            this.tmsWagePay.Text = "薪酬管理";
            this.tmsWagePay.Click += new System.EventHandler(this.tmsWagePay_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAmin,
            this.tsmixgmm});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // tsmiAmin
            // 
            this.tsmiAmin.Name = "tsmiAmin";
            this.tsmiAmin.Size = new System.Drawing.Size(124, 22);
            this.tsmiAmin.Text = "用户管理";
            this.tsmiAmin.Click += new System.EventHandler(this.tsmiAmin_Click);
            // 
            // tsmixgmm
            // 
            this.tsmixgmm.Name = "tsmixgmm";
            this.tsmixgmm.Size = new System.Drawing.Size(124, 22);
            this.tsmixgmm.Text = "修改密码";
            this.tsmixgmm.Click += new System.EventHandler(this.tsmixgmm_Click);
            // 
            // 基础数据管理ToolStripMenuItem
            // 
            this.基础数据管理ToolStripMenuItem.Name = "基础数据管理ToolStripMenuItem";
            this.基础数据管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.基础数据管理ToolStripMenuItem.Text = "基础数据管理";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(68, 21);
            this.tsmiClose.Text = "退出系统";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 451);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "HR人事管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsWagePay;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基础数据管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryEmp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAmin;
        private System.Windows.Forms.ToolStripMenuItem tsmixgmm;
    }
}