namespace customMessage
{
    partial class FYMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FYMessage));
            this.labTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labText = new System.Windows.Forms.Label();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnQuXiao = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.ForeColor = System.Drawing.Color.Black;
            this.labTitle.Location = new System.Drawing.Point(118, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(74, 21);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "系统提示";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labText);
            this.panel2.Controls.Add(this.pbxIcon);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 97);
            this.panel2.TabIndex = 1;
            // 
            // labText
            // 
            this.labText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labText.Location = new System.Drawing.Point(114, 24);
            this.labText.Name = "labText";
            this.labText.Size = new System.Drawing.Size(170, 52);
            this.labText.TabIndex = 1;
            this.labText.Text = "登录成功";
            this.labText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbxIcon.Image")));
            this.pbxIcon.Location = new System.Drawing.Point(43, 24);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(50, 50);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "错误.png");
            this.imgList.Images.SetKeyName(1, "警告.png");
            this.imgList.Images.SetKeyName(2, "正确.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.btnQuXiao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 49);
            this.panel1.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(114, 11);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(76, 31);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确  定";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnQuXiao
            // 
            this.btnQuXiao.BackColor = System.Drawing.Color.White;
            this.btnQuXiao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuXiao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuXiao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuXiao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuXiao.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuXiao.ForeColor = System.Drawing.Color.Black;
            this.btnQuXiao.Location = new System.Drawing.Point(219, 11);
            this.btnQuXiao.Name = "btnQuXiao";
            this.btnQuXiao.Size = new System.Drawing.Size(76, 31);
            this.btnQuXiao.TabIndex = 3;
            this.btnQuXiao.Text = "取  消";
            this.btnQuXiao.UseVisualStyleBackColor = false;
            this.btnQuXiao.Visible = false;
            this.btnQuXiao.Click += new System.EventHandler(this.btnQuXiao_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FYMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(307, 185);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FYMessage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Label labText;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnQuXiao;
        private System.Windows.Forms.Button btnConfirm;
    }
}

