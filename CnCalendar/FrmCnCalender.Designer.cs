namespace CnCalendar
{
    partial class FrmCnCalender
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCnCalender));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCnAnimal = new System.Windows.Forms.TextBox();
            this.txtCnDay = new System.Windows.Forms.TextBox();
            this.txtCnMonth = new System.Windows.Forms.TextBox();
            this.txtCnYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCnAnimal);
            this.panel1.Controls.Add(this.txtCnDay);
            this.panel1.Controls.Add(this.txtCnMonth);
            this.panel1.Controls.Add(this.txtCnYear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 167);
            this.panel1.TabIndex = 0;
            // 
            // txtCnAnimal
            // 
            this.txtCnAnimal.Location = new System.Drawing.Point(249, 82);
            this.txtCnAnimal.Name = "txtCnAnimal";
            this.txtCnAnimal.ReadOnly = true;
            this.txtCnAnimal.Size = new System.Drawing.Size(100, 21);
            this.txtCnAnimal.TabIndex = 11;
            // 
            // txtCnDay
            // 
            this.txtCnDay.Location = new System.Drawing.Point(249, 115);
            this.txtCnDay.Name = "txtCnDay";
            this.txtCnDay.ReadOnly = true;
            this.txtCnDay.Size = new System.Drawing.Size(100, 21);
            this.txtCnDay.TabIndex = 10;
            // 
            // txtCnMonth
            // 
            this.txtCnMonth.Location = new System.Drawing.Point(77, 115);
            this.txtCnMonth.Name = "txtCnMonth";
            this.txtCnMonth.ReadOnly = true;
            this.txtCnMonth.Size = new System.Drawing.Size(100, 21);
            this.txtCnMonth.TabIndex = 9;
            // 
            // txtCnYear
            // 
            this.txtCnYear.Location = new System.Drawing.Point(77, 82);
            this.txtCnYear.Name = "txtCnYear";
            this.txtCnYear.ReadOnly = true;
            this.txtCnYear.Size = new System.Drawing.Size(100, 21);
            this.txtCnYear.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "属相：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "农历日子：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "农历月份：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "农历年份：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(232, 25);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 21);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(53, 25);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(161, 21);
            this.txtDate.TabIndex = 2;
            // 
            // FrmCnCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 167);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCnCalender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "中国农历查询";
            this.Load += new System.EventHandler(this.FrmCnCalender_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCnAnimal;
        private System.Windows.Forms.TextBox txtCnDay;
        private System.Windows.Forms.TextBox txtCnMonth;
        private System.Windows.Forms.TextBox txtCnYear;
    }
}

