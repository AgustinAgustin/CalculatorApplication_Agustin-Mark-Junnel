namespace CalculatorApplication
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
            TxtBoxInput1 = new TextBox();
            TxtBoxInput2 = new TextBox();
            CBOperator = new ComboBox();
            LBLDisplayTotal = new Label();
            btnEqual = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ButtonReset = new Button();
            SuspendLayout();
            // 
            // TxtBoxInput1
            // 
            TxtBoxInput1.BackColor = SystemColors.ButtonFace;
            TxtBoxInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBoxInput1.Location = new Point(286, 42);
            TxtBoxInput1.Name = "TxtBoxInput1";
            TxtBoxInput1.Size = new Size(150, 39);
            TxtBoxInput1.TabIndex = 0;
            // 
            // TxtBoxInput2
            // 
            TxtBoxInput2.BackColor = SystemColors.ButtonFace;
            TxtBoxInput2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBoxInput2.Location = new Point(286, 199);
            TxtBoxInput2.Name = "TxtBoxInput2";
            TxtBoxInput2.Size = new Size(150, 39);
            TxtBoxInput2.TabIndex = 1;
            // 
            // CBOperator
            // 
            CBOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBOperator.FormattingEnabled = true;
            CBOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            CBOperator.Location = new Point(319, 121);
            CBOperator.Name = "CBOperator";
            CBOperator.Size = new Size(87, 36);
            CBOperator.TabIndex = 2;
            // 
            // LBLDisplayTotal
            // 
            LBLDisplayTotal.AutoSize = true;
            LBLDisplayTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLDisplayTotal.Location = new Point(277, 285);
            LBLDisplayTotal.Name = "LBLDisplayTotal";
            LBLDisplayTotal.Size = new Size(174, 32);
            LBLDisplayTotal.TabIndex = 3;
            LBLDisplayTotal.Text = "________________";
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.Azure;
            btnEqual.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(157, 353);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(215, 34);
            btnEqual.TabIndex = 4;
            btnEqual.Text = "<Calculate>";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 49);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 5;
            label1.Text = "Enter First number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 206);
            label2.Name = "label2";
            label2.Size = new Size(251, 32);
            label2.TabIndex = 6;
            label2.Text = "Enter Second number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(184, 285);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 7;
            label3.Text = "Answer:";
            // 
            // ButtonReset
            // 
            ButtonReset.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonReset.Location = new Point(184, 406);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(157, 34);
            ButtonReset.TabIndex = 8;
            ButtonReset.Text = "<Reset all>";
            ButtonReset.UseVisualStyleBackColor = true;
            ButtonReset.Click += ButtonReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(522, 525);
            Controls.Add(ButtonReset);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEqual);
            Controls.Add(LBLDisplayTotal);
            Controls.Add(CBOperator);
            Controls.Add(TxtBoxInput2);
            Controls.Add(TxtBoxInput1);
            Name = "Form1";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBoxInput1;
        private TextBox TxtBoxInput2;
        private ComboBox CBOperator;
        private Label LBLDisplayTotal;
        private Button btnEqual;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ButtonReset;
    }
}