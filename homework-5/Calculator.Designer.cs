using System.Windows.Forms;

namespace SimpleCalculator
{
    partial class Calculator
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox displayTextBox;
        private Button[] numberButtons;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button divideButton;
        private Button equalsButton;
        private Button clearButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Text = "简单计算器";

            // 创建显示文本框
            displayTextBox = new TextBox();
            displayTextBox.Location = new System.Drawing.Point(12, 12);
            displayTextBox.Size = new System.Drawing.Size(276, 30);
            displayTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            displayTextBox.TextAlign = HorizontalAlignment.Right;
            displayTextBox.ReadOnly = true;
            this.Controls.Add(displayTextBox);

            // 创建数字按钮
            numberButtons = new Button[10];
            int buttonWidth = 60;
            int buttonHeight = 60;
            int startX = 12;
            int startY = 60;
            int padding = 10;

            for (int i = 0; i < 10; i++)
            {
                numberButtons[i] = new Button();
                numberButtons[i].Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                numberButtons[i].Text = i.ToString();
                numberButtons[i].Font = new System.Drawing.Font("Microsoft YaHei", 12F);
                numberButtons[i].Click += new System.EventHandler(this.NumberButton_Click);

                // 计算按钮位置
                int row = (9 - i) / 3;
                int col = (i - 1) % 3;
                if (i == 0)
                {
                    // 0放在最后一行中间
                    numberButtons[i].Location = new System.Drawing.Point(
                        startX + buttonWidth + padding,
                        startY + (3 * (buttonHeight + padding))
                    );
                }
                else
                {
                    numberButtons[i].Location = new System.Drawing.Point(
                        startX + (col * (buttonWidth + padding)),
                        startY + (row * (buttonHeight + padding))
                    );
                }
                this.Controls.Add(numberButtons[i]);
            }

            // 创建运算符按钮
            addButton = new Button();
            subtractButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            equalsButton = new Button();
            clearButton = new Button();

            Button[] operatorButtons = { addButton, subtractButton, multiplyButton, divideButton };
            string[] operatorSymbols = { "+", "-", "*", "/" };

            for (int i = 0; i < operatorButtons.Length; i++)
            {
                operatorButtons[i].Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                operatorButtons[i].Text = operatorSymbols[i];
                operatorButtons[i].Font = new System.Drawing.Font("Microsoft YaHei", 12F);
                operatorButtons[i].Location = new System.Drawing.Point(
                    startX + 3 * (buttonWidth + padding),
                    startY + i * (buttonHeight + padding)
                );
                operatorButtons[i].Click += new System.EventHandler(this.OperatorButton_Click);
                this.Controls.Add(operatorButtons[i]);
            }

            // 创建等号按钮
            equalsButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            equalsButton.Text = "=";
            equalsButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            equalsButton.Location = new System.Drawing.Point(
                startX + 2 * (buttonWidth + padding),
                startY + 3 * (buttonHeight + padding)
            );
            equalsButton.BackColor = System.Drawing.Color.LightBlue; // 让等号按钮更显眼
            equalsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            this.Controls.Add(equalsButton);

            // 创建清空按钮
            clearButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            clearButton.Text = "C";
            clearButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            clearButton.Location = new System.Drawing.Point(
                startX,
                startY + 3 * (buttonHeight + padding)
            );
            clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.Controls.Add(clearButton);
        }
    }
}