namespace Credit_Card_Validator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.EnterLabel = new System.Windows.Forms.Label();
            this.maskedCardNumberIn = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterLabel
            // 
            this.EnterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterLabel.Location = new System.Drawing.Point(39, 61);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(489, 53);
            this.EnterLabel.TabIndex = 0;
            this.EnterLabel.Text = "Enter the Credit Card Number:";
            // 
            // maskedCardNumberIn
            // 
            this.maskedCardNumberIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedCardNumberIn.Location = new System.Drawing.Point(294, 177);
            this.maskedCardNumberIn.Mask = "0000-0000-0000-0000";
            this.maskedCardNumberIn.Name = "maskedCardNumberIn";
            this.maskedCardNumberIn.Size = new System.Drawing.Size(321, 41);
            this.maskedCardNumberIn.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(392, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check\r\nValidity\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedCardNumberIn);
            this.Controls.Add(this.EnterLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Credit Card Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterLabel;
        private System.Windows.Forms.MaskedTextBox maskedCardNumberIn;
        private System.Windows.Forms.Button button1;
    }
}