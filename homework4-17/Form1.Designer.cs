namespace Reserchfetch
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
            search = new Button();
            keyword = new TextBox();
            result1 = new TextBox();
            result2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // search
            // 
            search.Location = new Point(104, 102);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 0;
            search.Text = "搜索";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // keyword
            // 
            keyword.Location = new Point(241, 105);
            keyword.Name = "keyword";
            keyword.Size = new Size(389, 27);
            keyword.TabIndex = 1;
            // 
            // result1
            // 
            result1.Location = new Point(73, 235);
            result1.Multiline = true;
            result1.Name = "result1";
            result1.Size = new Size(308, 178);
            result1.TabIndex = 2;
            // 
            // result2
            // 
            result2.Location = new Point(431, 235);
            result2.Multiline = true;
            result2.Name = "result2";
            result2.Size = new Size(304, 178);
            result2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 194);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "baidu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(558, 194);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "bing";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(result2);
            Controls.Add(result1);
            Controls.Add(keyword);
            Controls.Add(search);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button search;
        private TextBox keyword;
        private TextBox result1;
        private TextBox result2;
        private Label label1;
        private Label label2;
    }
}
