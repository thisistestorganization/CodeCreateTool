namespace CodeCreateTool
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
            this.lvtableList = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGenPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenPath = new System.Windows.Forms.Button();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.btnlinkDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconnStr = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtConsoleOutput = new System.Windows.Forms.TextBox();
            this.fbdGenPath = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvtableList
            // 
            this.lvtableList.CheckBoxes = true;
            this.lvtableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvtableList.Location = new System.Drawing.Point(0, 0);
            this.lvtableList.Name = "lvtableList";
            this.lvtableList.Size = new System.Drawing.Size(168, 341);
            this.lvtableList.TabIndex = 0;
            this.lvtableList.UseCompatibleStateImageBehavior = false;
            this.lvtableList.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGenPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGenPath);
            this.panel1.Controls.Add(this.btnCreateCode);
            this.panel1.Controls.Add(this.btnlinkDB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtconnStr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 136);
            this.panel1.TabIndex = 2;
            // 
            // txtGenPath
            // 
            this.txtGenPath.Location = new System.Drawing.Point(168, 47);
            this.txtGenPath.Name = "txtGenPath";
            this.txtGenPath.Size = new System.Drawing.Size(511, 21);
            this.txtGenPath.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "代码生成路径:";
            // 
            // btnGenPath
            // 
            this.btnGenPath.Location = new System.Drawing.Point(685, 43);
            this.btnGenPath.Name = "btnGenPath";
            this.btnGenPath.Size = new System.Drawing.Size(87, 26);
            this.btnGenPath.TabIndex = 4;
            this.btnGenPath.Text = "生成路径";
            this.btnGenPath.UseVisualStyleBackColor = true;
            this.btnGenPath.Click += new System.EventHandler(this.btnGenPath_Click);
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Location = new System.Drawing.Point(685, 75);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(87, 26);
            this.btnCreateCode.TabIndex = 3;
            this.btnCreateCode.Text = "生成代码";
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // btnlinkDB
            // 
            this.btnlinkDB.Location = new System.Drawing.Point(685, 8);
            this.btnlinkDB.Name = "btnlinkDB";
            this.btnlinkDB.Size = new System.Drawing.Size(87, 26);
            this.btnlinkDB.TabIndex = 2;
            this.btnlinkDB.Text = "连接数据库";
            this.btnlinkDB.UseVisualStyleBackColor = true;
            this.btnlinkDB.Click += new System.EventHandler(this.btnlinkDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "连接字符串:";
            // 
            // txtconnStr
            // 
            this.txtconnStr.Location = new System.Drawing.Point(168, 12);
            this.txtconnStr.Name = "txtconnStr";
            this.txtconnStr.Size = new System.Drawing.Size(511, 21);
            this.txtconnStr.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvtableList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 341);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtConsoleOutput);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(168, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 341);
            this.panel3.TabIndex = 3;
            // 
            // txtConsoleOutput
            // 
            this.txtConsoleOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsoleOutput.Location = new System.Drawing.Point(0, 0);
            this.txtConsoleOutput.Multiline = true;
            this.txtConsoleOutput.Name = "txtConsoleOutput";
            this.txtConsoleOutput.Size = new System.Drawing.Size(754, 341);
            this.txtConsoleOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvtableList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCreateCode;
        private System.Windows.Forms.Button btnlinkDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconnStr;
        private System.Windows.Forms.TextBox txtConsoleOutput;
        private System.Windows.Forms.TextBox txtGenPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenPath;
        private System.Windows.Forms.FolderBrowserDialog fbdGenPath;
    }
}

