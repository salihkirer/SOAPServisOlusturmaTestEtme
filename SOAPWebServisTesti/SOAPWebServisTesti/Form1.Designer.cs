namespace SOAPWebServisTesti
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
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.txtIkinciSayi = new System.Windows.Forms.TextBox();
            this.btnToplama = new System.Windows.Forms.Button();
            this.txtIkinci = new System.Windows.Forms.Label();
            this.txtIlk = new System.Windows.Forms.Label();
            this.txtIlkSayi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(69, 102);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(137, 20);
            this.txtSonuc.TabIndex = 12;
            // 
            // txtIkinciSayi
            // 
            this.txtIkinciSayi.Location = new System.Drawing.Point(69, 38);
            this.txtIkinciSayi.Name = "txtIkinciSayi";
            this.txtIkinciSayi.Size = new System.Drawing.Size(137, 20);
            this.txtIkinciSayi.TabIndex = 13;
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(69, 68);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(137, 28);
            this.btnToplama.TabIndex = 11;
            this.btnToplama.Text = "TOPLAMA";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // txtIkinci
            // 
            this.txtIkinci.AutoSize = true;
            this.txtIkinci.Location = new System.Drawing.Point(8, 41);
            this.txtIkinci.Name = "txtIkinci";
            this.txtIkinci.Size = new System.Drawing.Size(55, 13);
            this.txtIkinci.TabIndex = 9;
            this.txtIkinci.Text = "İkinci Sayi";
            // 
            // txtIlk
            // 
            this.txtIlk.AutoSize = true;
            this.txtIlk.Location = new System.Drawing.Point(22, 15);
            this.txtIlk.Name = "txtIlk";
            this.txtIlk.Size = new System.Drawing.Size(41, 13);
            this.txtIlk.TabIndex = 10;
            this.txtIlk.Text = "İlk Sayi";
            // 
            // txtIlkSayi
            // 
            this.txtIlkSayi.Location = new System.Drawing.Point(69, 12);
            this.txtIlkSayi.Name = "txtIlkSayi";
            this.txtIlkSayi.Size = new System.Drawing.Size(137, 20);
            this.txtIlkSayi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sonuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 139);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtIkinciSayi);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.txtIkinci);
            this.Controls.Add(this.txtIlk);
            this.Controls.Add(this.txtIlkSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.TextBox txtIkinciSayi;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Label txtIkinci;
        private System.Windows.Forms.Label txtIlk;
        private System.Windows.Forms.TextBox txtIlkSayi;
        private System.Windows.Forms.Label label3;
    }
}

