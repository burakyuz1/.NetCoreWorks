namespace LSSolution
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
            this.btnUcur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstKuslar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUcur
            // 
            this.btnUcur.Location = new System.Drawing.Point(198, 264);
            this.btnUcur.Name = "btnUcur";
            this.btnUcur.Size = new System.Drawing.Size(75, 23);
            this.btnUcur.TabIndex = 5;
            this.btnUcur.Text = "Kuşları Uçur";
            this.btnUcur.UseVisualStyleBackColor = true;
            this.btnUcur.Click += new System.EventHandler(this.btnUcur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kuşlar:";
            // 
            // lstKuslar
            // 
            this.lstKuslar.FormattingEnabled = true;
            this.lstKuslar.Location = new System.Drawing.Point(78, 59);
            this.lstKuslar.Name = "lstKuslar";
            this.lstKuslar.Size = new System.Drawing.Size(195, 199);
            this.lstKuslar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUcur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKuslar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUcur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstKuslar;
    }
}

