namespace ISProblem
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstMesajlar = new System.Windows.Forms.ListBox();
            this.btnMesajlariGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gönderilecek Mesajlar";
            // 
            // lstMesajlar
            // 
            this.lstMesajlar.FormattingEnabled = true;
            this.lstMesajlar.Location = new System.Drawing.Point(105, 78);
            this.lstMesajlar.Name = "lstMesajlar";
            this.lstMesajlar.Size = new System.Drawing.Size(160, 212);
            this.lstMesajlar.TabIndex = 1;
            // 
            // btnMesajlariGonder
            // 
            this.btnMesajlariGonder.Location = new System.Drawing.Point(105, 296);
            this.btnMesajlariGonder.Name = "btnMesajlariGonder";
            this.btnMesajlariGonder.Size = new System.Drawing.Size(160, 23);
            this.btnMesajlariGonder.TabIndex = 2;
            this.btnMesajlariGonder.Text = "Mesajları Gönder";
            this.btnMesajlariGonder.UseVisualStyleBackColor = true;
            this.btnMesajlariGonder.Click += new System.EventHandler(this.btnMesajlariGonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMesajlariGonder);
            this.Controls.Add(this.lstMesajlar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMesajlar;
        private System.Windows.Forms.Button btnMesajlariGonder;
    }
}

