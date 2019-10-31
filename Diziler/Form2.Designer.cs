namespace Diziler
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
            this.btnSoneleman = new System.Windows.Forms.Button();
            this.btnRastgeleEleman = new System.Windows.Forms.Button();
            this.btnElemanEkle = new System.Windows.Forms.Button();
            this.lbox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSoneleman
            // 
            this.btnSoneleman.Location = new System.Drawing.Point(13, 13);
            this.btnSoneleman.Name = "btnSoneleman";
            this.btnSoneleman.Size = new System.Drawing.Size(243, 45);
            this.btnSoneleman.TabIndex = 0;
            this.btnSoneleman.Text = "Son Elemanı Göster";
            this.btnSoneleman.UseVisualStyleBackColor = true;
            this.btnSoneleman.Click += new System.EventHandler(this.BtnSoneleman_Click);
            // 
            // btnRastgeleEleman
            // 
            this.btnRastgeleEleman.Location = new System.Drawing.Point(12, 64);
            this.btnRastgeleEleman.Name = "btnRastgeleEleman";
            this.btnRastgeleEleman.Size = new System.Drawing.Size(244, 45);
            this.btnRastgeleEleman.TabIndex = 0;
            this.btnRastgeleEleman.Text = "Rastgele Eleman Göster";
            this.btnRastgeleEleman.UseVisualStyleBackColor = true;
            this.btnRastgeleEleman.Click += new System.EventHandler(this.BtnRastgeleEleman_Click);
            // 
            // btnElemanEkle
            // 
            this.btnElemanEkle.Location = new System.Drawing.Point(13, 115);
            this.btnElemanEkle.Name = "btnElemanEkle";
            this.btnElemanEkle.Size = new System.Drawing.Size(243, 45);
            this.btnElemanEkle.TabIndex = 0;
            this.btnElemanEkle.Text = "Elemanları Listbox\'a Ekle";
            this.btnElemanEkle.UseVisualStyleBackColor = true;
            this.btnElemanEkle.Click += new System.EventHandler(this.BtnElemanEkle_Click);
            // 
            // lbox1
            // 
            this.lbox1.FormattingEnabled = true;
            this.lbox1.Location = new System.Drawing.Point(13, 167);
            this.lbox1.Name = "lbox1";
            this.lbox1.Size = new System.Drawing.Size(243, 95);
            this.lbox1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 274);
            this.Controls.Add(this.lbox1);
            this.Controls.Add(this.btnElemanEkle);
            this.Controls.Add(this.btnRastgeleEleman);
            this.Controls.Add(this.btnSoneleman);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSoneleman;
        private System.Windows.Forms.Button btnRastgeleEleman;
        private System.Windows.Forms.Button btnElemanEkle;
        private System.Windows.Forms.ListBox lbox1;
    }
}