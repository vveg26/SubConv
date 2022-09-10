namespace SubConv
{
    partial class SubConv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubConv));
            this.richTextBoxUrl = new System.Windows.Forms.RichTextBox();
            this.buttonConv = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxUpload = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gisttoken配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用前必读ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxUrl
            // 
            this.richTextBoxUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxUrl.Location = new System.Drawing.Point(28, 74);
            this.richTextBoxUrl.Name = "richTextBoxUrl";
            this.richTextBoxUrl.Size = new System.Drawing.Size(631, 152);
            this.richTextBoxUrl.TabIndex = 0;
            this.richTextBoxUrl.Text = "";
            this.richTextBoxUrl.Enter += new System.EventHandler(this.richTextBoxUrl_Enter);
            this.richTextBoxUrl.Leave += new System.EventHandler(this.richTextBoxUrl_Leave);
            // 
            // buttonConv
            // 
            this.buttonConv.Location = new System.Drawing.Point(436, 355);
            this.buttonConv.Name = "buttonConv";
            this.buttonConv.Size = new System.Drawing.Size(221, 35);
            this.buttonConv.TabIndex = 1;
            this.buttonConv.Text = "转换";
            this.buttonConv.UseVisualStyleBackColor = true;
            this.buttonConv.Click += new System.EventHandler(this.buttonConv_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "clash",
            "base64"});
            this.comboBoxType.Location = new System.Drawing.Point(104, 322);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(149, 23);
            this.comboBoxType.TabIndex = 2;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(104, 372);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(149, 25);
            this.textBoxFilename.TabIndex = 3;
            this.textBoxFilename.Text = "subconv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "订阅链接";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "转换类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "配置文件名";
            // 
            // checkBoxUpload
            // 
            this.checkBoxUpload.AutoSize = true;
            this.checkBoxUpload.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxUpload.Location = new System.Drawing.Point(436, 323);
            this.checkBoxUpload.Name = "checkBoxUpload";
            this.checkBoxUpload.Size = new System.Drawing.Size(161, 19);
            this.checkBoxUpload.TabIndex = 8;
            this.checkBoxUpload.Text = "将文件上传至gist";
            this.checkBoxUpload.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gisttoken配置ToolStripMenuItem,
            this.使用前必读ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gisttoken配置ToolStripMenuItem
            // 
            this.gisttoken配置ToolStripMenuItem.Name = "gisttoken配置ToolStripMenuItem";
            this.gisttoken配置ToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.gisttoken配置ToolStripMenuItem.Text = "gist配置";
            this.gisttoken配置ToolStripMenuItem.Click += new System.EventHandler(this.gisttoken配置ToolStripMenuItem_Click);
            // 
            // 使用前必读ToolStripMenuItem
            // 
            this.使用前必读ToolStripMenuItem.Name = "使用前必读ToolStripMenuItem";
            this.使用前必读ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.使用前必读ToolStripMenuItem.Text = "使用前必读";
            this.使用前必读ToolStripMenuItem.Click += new System.EventHandler(this.使用前必读ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 25);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "订阅";
            // 
            // SubConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 416);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxUpload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonConv);
            this.Controls.Add(this.richTextBoxUrl);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubConv";
            this.Text = "订阅转换";
            this.Load += new System.EventHandler(this.SubConv_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxUrl;
        private System.Windows.Forms.Button buttonConv;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxUpload;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gisttoken配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用前必读ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

