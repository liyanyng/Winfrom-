namespace customMessage
{
    partial class Test
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.btnWarn = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(147, 82);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(156, 63);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "正常提示";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(407, 82);
            this.btnSuccess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(156, 63);
            this.btnSuccess.TabIndex = 1;
            this.btnSuccess.Text = "成功提示";
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // btnWarn
            // 
            this.btnWarn.Location = new System.Drawing.Point(147, 226);
            this.btnWarn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWarn.Name = "btnWarn";
            this.btnWarn.Size = new System.Drawing.Size(156, 63);
            this.btnWarn.TabIndex = 2;
            this.btnWarn.Text = "警告提示";
            this.btnWarn.UseVisualStyleBackColor = true;
            this.btnWarn.Click += new System.EventHandler(this.btnWarn_Click);
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(407, 226);
            this.btnError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(156, 63);
            this.btnError.TabIndex = 3;
            this.btnError.Text = "错误提示";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 382);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnWarn);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.btnInfo);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试窗体弹框演示";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.Button btnWarn;
        private System.Windows.Forms.Button btnError;
    }
}