namespace CalculatorApplication_
{
    partial class FrmCalculator
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
            label1 = new Label();
            txtBoxInput1 = new TextBox();
            label2 = new Label();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            label3 = new Label();
            lblDisplayTotal = new Label();
            bttnEqual = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(81, 65);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter first number:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Location = new Point(245, 65);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(232, 23);
            txtBoxInput1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(59, 154);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 2;
            label2.Text = "Enter second number:";
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Location = new Point(245, 156);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(232, 23);
            txtBoxInput2.TabIndex = 3;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(245, 111);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(121, 27);
            cbOperator.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(155, 199);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 5;
            label3.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayTotal.ForeColor = SystemColors.ButtonHighlight;
            lblDisplayTotal.Location = new Point(245, 199);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(185, 21);
            lblDisplayTotal.TabIndex = 6;
            lblDisplayTotal.Text = "_________________________";
            // 
            // bttnEqual
            // 
            bttnEqual.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnEqual.Location = new Point(284, 282);
            bttnEqual.Name = "bttnEqual";
            bttnEqual.Size = new Size(113, 36);
            bttnEqual.TabIndex = 7;
            bttnEqual.Text = "CALCULATE";
            bttnEqual.UseVisualStyleBackColor = true;
            bttnEqual.Click += bttnEqual_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(635, 461);
            Controls.Add(bttnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label3);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(label2);
            Controls.Add(txtBoxInput1);
            Controls.Add(label1);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxInput1;
        private Label label2;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Label label3;
        private Label lblDisplayTotal;
        private Button bttnEqual;
    }
}
