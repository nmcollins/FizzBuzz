namespace FizzBuzz
{
    partial class FizzBuzz
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
            this.txtBxNumbers = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxNumbers
            // 
            this.txtBxNumbers.Location = new System.Drawing.Point(13, 67);
            this.txtBxNumbers.Multiline = true;
            this.txtBxNumbers.Name = "txtBxNumbers";
            this.txtBxNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxNumbers.Size = new System.Drawing.Size(355, 425);
            this.txtBxNumbers.TabIndex = 0;
            this.txtBxNumbers.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 26);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(291, 26);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Display numbers from 1 to 100, show Buzz for multiples of 3, \r\nFizz for multiples" +
    " of 5 and FizzBuzz for multiples of both";
            // 
            // FizzBuzz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 514);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtBxNumbers);
            this.Name = "FizzBuzz";
            this.Text = "FizzBuzz";
            this.Load += new System.EventHandler(this.FizzBuzz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxNumbers;
        private System.Windows.Forms.Label lblDescription;
    }
}

