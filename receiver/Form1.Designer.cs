
namespace receiver
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
            this.text = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(55, 27);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(596, 92);
            this.text.TabIndex = 1;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(55, 135);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.ReadOnly = true;
            this.text2.Size = new System.Drawing.Size(596, 98);
            this.text2.TabIndex = 2;
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(55, 394);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(596, 22);
            this.text4.TabIndex = 3;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(55, 248);
            this.text3.Multiline = true;
            this.text3.Name = "text3";
            this.text3.ReadOnly = true;
            this.text3.Size = new System.Drawing.Size(596, 109);
            this.text3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.TextBox text3;
    }
}

