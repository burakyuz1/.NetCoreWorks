namespace DIProblem
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
            this.btnBildirimGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBildirimGonder
            // 
            this.btnBildirimGonder.Location = new System.Drawing.Point(115, 62);
            this.btnBildirimGonder.Name = "btnBildirimGonder";
            this.btnBildirimGonder.Size = new System.Drawing.Size(163, 23);
            this.btnBildirimGonder.TabIndex = 0;
            this.btnBildirimGonder.Text = "Bildirim Gönder";
            this.btnBildirimGonder.UseVisualStyleBackColor = true;
            this.btnBildirimGonder.Click += new System.EventHandler(this.btnBildirimGonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBildirimGonder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBildirimGonder;
    }
}

