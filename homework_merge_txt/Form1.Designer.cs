namespace WinFormsApp_mergetxt
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
            choose_fst_txt = new Button();
            choose_snd_txt = new Button();
            path1 = new TextBox();
            textBox2 = new TextBox();
            merge = new Button();
            SuspendLayout();
            // 
            // choose_fst_txt
            // 
            choose_fst_txt.Location = new Point(30, 73);
            choose_fst_txt.Name = "choose_fst_txt";
            choose_fst_txt.Size = new Size(150, 29);
            choose_fst_txt.TabIndex = 0;
            choose_fst_txt.Text = "Fst_txt";
            choose_fst_txt.UseVisualStyleBackColor = true;
            choose_fst_txt.Click += choose_fst_txt_Click;
            // 
            // choose_snd_txt
            // 
            choose_snd_txt.Location = new Point(30, 146);
            choose_snd_txt.Name = "choose_snd_txt";
            choose_snd_txt.Size = new Size(150, 29);
            choose_snd_txt.TabIndex = 1;
            choose_snd_txt.Text = "Snd_txt";
            choose_snd_txt.UseVisualStyleBackColor = true;
            choose_snd_txt.Click += choose_snd_txt_Click;
            // 
            // path1
            // 
            path1.Location = new Point(254, 75);
            path1.Name = "path1";
            path1.Size = new Size(392, 27);
            path1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(392, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // merge
            // 
            merge.Location = new Point(30, 324);
            merge.Name = "merge";
            merge.Size = new Size(150, 29);
            merge.TabIndex = 4;
            merge.Text = "merge";
            merge.UseVisualStyleBackColor = true;
            merge.Click += merge_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(merge);
            Controls.Add(textBox2);
            Controls.Add(path1);
            Controls.Add(choose_snd_txt);
            Controls.Add(choose_fst_txt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button choose_fst_txt;
        private Button choose_snd_txt;
        private TextBox path1;
        private TextBox textBox2;
        private Button merge;
    }
}
