namespace Week7pjt
{
    partial class TempConverter
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
            this.btnCalculator = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(544, 618);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(350, 134);
            this.btnCalculator.TabIndex = 0;
            this.btnCalculator.Text = "Calculate";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(675, 431);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 38);
            this.txtInput.TabIndex = 1;
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Location = new System.Drawing.Point(682, 531);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(0, 32);
            this.lbloutput.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(579, 349);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(342, 32);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Enter Tempture in Celsuis";
            // 
            // TempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 855);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCalculator);
            this.Name = "TempConverter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lbl1;
    }
}

