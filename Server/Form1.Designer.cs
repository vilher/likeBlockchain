
namespace Server
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
            this.answer = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.text3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(72, 197);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(508, 117);
            this.answer.TabIndex = 0;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(72, 104);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(508, 66);
            this.text.TabIndex = 1;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(72, 384);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(155, 37);
            this.send.TabIndex = 2;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(72, 338);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(508, 22);
            this.text3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.send);
            this.Controls.Add(this.text);
            this.Controls.Add(this.answer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox text3;
    }
}

