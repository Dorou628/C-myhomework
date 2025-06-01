namespace WordLearner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblChinese = new Label();
            txtEnglish = new TextBox();
            lblResult = new Label();
            btnNext = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblChinese
            // 
            lblChinese.AutoSize = true;
            lblChinese.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChinese.Location = new Point(180, 70);
            lblChinese.Name = "lblChinese";
            lblChinese.Size = new Size(89, 21);
            lblChinese.TabIndex = 0;
            lblChinese.Text = "[中文词义]";
            // 
            // txtEnglish
            // 
            txtEnglish.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnglish.Location = new Point(180, 130);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(200, 28);
            txtEnglish.TabIndex = 1;
            txtEnglish.KeyPress += txtEnglish_KeyPress;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(180, 180);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(180, 220);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(200, 30);
            btnNext.TabIndex = 3;
            btnNext.Text = "下一个";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 75);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 4;
            label1.Text = "中文词义：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 135);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 5;
            label2.Text = "请输入英文词：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(lblResult);
            Controls.Add(txtEnglish);
            Controls.Add(lblChinese);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "单词学习";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChinese;
        private TextBox txtEnglish;
        private Label lblResult;
        private Button btnNext;
        private Label label1;
        private Label label2;
    }
}