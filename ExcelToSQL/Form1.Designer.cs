namespace ExcelToSQL
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsl_msg = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_folder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_upload = new System.Windows.Forms.ToolStripButton();
            this.tsb_setting = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_ServerName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tb_DBName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tb_UserName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tb_Pw = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tb_TableName = new System.Windows.Forms.ToolStripTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_data, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.25641F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.74359F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1131, 412);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_data.Location = new System.Drawing.Point(3, 82);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowTemplate.Height = 24;
            this.dgv_data.Size = new System.Drawing.Size(1125, 306);
            this.dgv_data.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_msg,
            this.toolStripProgressBar1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 391);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1131, 21);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsl_msg
            // 
            this.tsl_msg.Name = "tsl_msg";
            this.tsl_msg.Size = new System.Drawing.Size(94, 18);
            this.tsl_msg.Text = "toolStripLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 18);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_folder,
            this.toolStripSeparator1,
            this.tsb_upload,
            this.tsb_setting,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tb_ServerName,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.tb_DBName,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.tb_UserName,
            this.toolStripSeparator5,
            this.toolStripLabel4,
            this.tb_Pw,
            this.toolStripSeparator6,
            this.toolStripLabel5,
            this.tb_TableName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1131, 79);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_folder
            // 
            this.tsb_folder.AutoSize = false;
            this.tsb_folder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_folder.Image = ((System.Drawing.Image)(resources.GetObject("tsb_folder.Image")));
            this.tsb_folder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_folder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_folder.Name = "tsb_folder";
            this.tsb_folder.Size = new System.Drawing.Size(54, 54);
            this.tsb_folder.Text = "toolStripButton1";
            this.tsb_folder.Click += new System.EventHandler(this.tsb_folder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 79);
            // 
            // tsb_upload
            // 
            this.tsb_upload.AutoSize = false;
            this.tsb_upload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_upload.Enabled = false;
            this.tsb_upload.Image = ((System.Drawing.Image)(resources.GetObject("tsb_upload.Image")));
            this.tsb_upload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_upload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_upload.Name = "tsb_upload";
            this.tsb_upload.Size = new System.Drawing.Size(54, 54);
            this.tsb_upload.Text = "toolStripButton2";
            this.tsb_upload.Click += new System.EventHandler(this.tsb_upload_Click);
            // 
            // tsb_setting
            // 
            this.tsb_setting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_setting.AutoSize = false;
            this.tsb_setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_setting.Image = ((System.Drawing.Image)(resources.GetObject("tsb_setting.Image")));
            this.tsb_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_setting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_setting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_setting.Name = "tsb_setting";
            this.tsb_setting.Size = new System.Drawing.Size(54, 54);
            this.tsb_setting.Text = "toolStripButton3";
            this.tsb_setting.Visible = false;
            this.tsb_setting.Click += new System.EventHandler(this.tsb_setting_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 79);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 76);
            this.toolStripLabel1.Text = "IP or Name";
            // 
            // tb_ServerName
            // 
            this.tb_ServerName.AutoSize = false;
            this.tb_ServerName.Name = "tb_ServerName";
            this.tb_ServerName.Size = new System.Drawing.Size(100, 35);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 79);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(61, 76);
            this.toolStripLabel2.Text = "DB Name";
            // 
            // tb_DBName
            // 
            this.tb_DBName.AutoSize = false;
            this.tb_DBName.Name = "tb_DBName";
            this.tb_DBName.Size = new System.Drawing.Size(100, 35);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 79);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(70, 76);
            this.toolStripLabel3.Text = "User Name";
            // 
            // tb_UserName
            // 
            this.tb_UserName.AutoSize = false;
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(100, 35);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 79);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(60, 76);
            this.toolStripLabel4.Text = "Password";
            // 
            // tb_Pw
            // 
            this.tb_Pw.AutoSize = false;
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.Size = new System.Drawing.Size(100, 35);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 79);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(77, 76);
            this.toolStripLabel5.Text = "Table Name";
            // 
            // tb_TableName
            // 
            this.tb_TableName.Name = "tb_TableName";
            this.tb_TableName.Size = new System.Drawing.Size(100, 79);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1131, 412);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Excel2SQL";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_folder;
        private System.Windows.Forms.ToolStripButton tsb_upload;
        private System.Windows.Forms.ToolStripButton tsb_setting;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tsl_msg;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_ServerName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tb_DBName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tb_UserName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox tb_Pw;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox tb_TableName;
    }
}

