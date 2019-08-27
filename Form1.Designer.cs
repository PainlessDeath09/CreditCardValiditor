namespace Credit_Card_Validator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AppTitle = new System.Windows.Forms.Label();
            this.AppDescription = new System.Windows.Forms.LinkLabel();
            this.Continue = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AppTitle
            // 
            this.AppTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AppTitle.Location = new System.Drawing.Point(4, 48);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(886, 51);
            this.AppTitle.TabIndex = 0;
            this.AppTitle.Text = "Credit Card Validator";
            this.AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppTitle.UseMnemonic = false;
            this.AppTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // AppDescription
            // 
            this.AppDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppDescription.LinkArea = new System.Windows.Forms.LinkArea(49, 25);
            this.AppDescription.Location = new System.Drawing.Point(12, 173);
            this.AppDescription.Name = "AppDescription";
            this.AppDescription.Size = new System.Drawing.Size(878, 158);
            this.AppDescription.TabIndex = 1;
            this.AppDescription.TabStop = true;
            this.AppDescription.Text = "A simple credit card number validator that makes use of the Luhn algorithm to che" +
    "ck the possible validity of a credit card by checking the card number input \r\n\r\n" +
    "\r\n";
            this.AppDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppDescription.UseCompatibleTextRendering = true;
            this.AppDescription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AppDescription_LinkClicked);
            // 
            // Continue
            // 
            this.Continue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(383, 312);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(131, 46);
            this.Continue.TabIndex = 2;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(3, 11);
            this.linkLabel1.Location = new System.Drawing.Point(400, 454);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "By Akhil Kumar";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 522);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.AppDescription);
            this.Controls.Add(this.AppTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Credit Card Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.LinkLabel AppDescription;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

