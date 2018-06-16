namespace CourseSchedulingProject
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
            this.CourseDataPath_Textbox = new System.Windows.Forms.TextBox();
            this.PickButton = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CourseDataPath_Textbox
            // 
            this.CourseDataPath_Textbox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CourseDataPath_Textbox.Location = new System.Drawing.Point(31, 62);
            this.CourseDataPath_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.CourseDataPath_Textbox.Name = "CourseDataPath_Textbox";
            this.CourseDataPath_Textbox.Size = new System.Drawing.Size(812, 30);
            this.CourseDataPath_Textbox.TabIndex = 0;
            // 
            // PickButton
            // 
            this.PickButton.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PickButton.Location = new System.Drawing.Point(877, 62);
            this.PickButton.Margin = new System.Windows.Forms.Padding(4);
            this.PickButton.Name = "PickButton";
            this.PickButton.Size = new System.Drawing.Size(100, 30);
            this.PickButton.TabIndex = 1;
            this.PickButton.Text = "Pick";
            this.PickButton.UseVisualStyleBackColor = true;
            this.PickButton.Click += new System.EventHandler(this.PickButton_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start_Button.Location = new System.Drawing.Point(877, 125);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(100, 46);
            this.Start_Button.TabIndex = 2;
            this.Start_Button.Text = "開始排課";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Buttin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "請匯入課程資訊:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.PickButton);
            this.Controls.Add(this.CourseDataPath_Textbox);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "自動排課專題";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CourseDataPath_Textbox;
        private System.Windows.Forms.Button PickButton;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label label1;
    }
}

