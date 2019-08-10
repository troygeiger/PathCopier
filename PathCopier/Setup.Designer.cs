namespace PathCopier
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.btnTopColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBottomColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOutlineColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTopColor
            // 
            this.btnTopColor.BackColor = System.Drawing.Color.Navy;
            this.btnTopColor.Location = new System.Drawing.Point(25, 21);
            this.btnTopColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTopColor.Name = "btnTopColor";
            this.btnTopColor.Size = new System.Drawing.Size(31, 28);
            this.btnTopColor.TabIndex = 0;
            this.btnTopColor.UseVisualStyleBackColor = false;
            this.btnTopColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bottom Color";
            // 
            // btnBottomColor
            // 
            this.btnBottomColor.BackColor = System.Drawing.Color.Blue;
            this.btnBottomColor.Location = new System.Drawing.Point(25, 57);
            this.btnBottomColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBottomColor.Name = "btnBottomColor";
            this.btnBottomColor.Size = new System.Drawing.Size(31, 28);
            this.btnBottomColor.TabIndex = 2;
            this.btnBottomColor.UseVisualStyleBackColor = false;
            this.btnBottomColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Outline Color";
            // 
            // btnOutlineColor
            // 
            this.btnOutlineColor.BackColor = System.Drawing.Color.Blue;
            this.btnOutlineColor.Location = new System.Drawing.Point(25, 92);
            this.btnOutlineColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOutlineColor.Name = "btnOutlineColor";
            this.btnOutlineColor.Size = new System.Drawing.Size(31, 28);
            this.btnOutlineColor.TabIndex = 4;
            this.btnOutlineColor.UseVisualStyleBackColor = false;
            this.btnOutlineColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Text Color";
            // 
            // btnTextColor
            // 
            this.btnTextColor.BackColor = System.Drawing.Color.White;
            this.btnTextColor.Location = new System.Drawing.Point(25, 128);
            this.btnTextColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(31, 28);
            this.btnTextColor.TabIndex = 6;
            this.btnTextColor.UseVisualStyleBackColor = false;
            this.btnTextColor.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(35, 178);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 28);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(156, 178);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 222);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTextColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOutlineColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBottomColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTopColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBottomColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOutlineColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.Button btnClose;
    }
}