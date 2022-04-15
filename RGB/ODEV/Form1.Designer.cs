
namespace ODEV
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pt_resim = new System.Windows.Forms.PictureBox();
            this.pt_YResim = new System.Windows.Forms.PictureBox();
            this.btn_piksel = new System.Windows.Forms.Button();
            this.lbl_gri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pt_resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_YResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pt_resim
            // 
            this.pt_resim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pt_resim.Location = new System.Drawing.Point(25, 27);
            this.pt_resim.Name = "pt_resim";
            this.pt_resim.Size = new System.Drawing.Size(299, 373);
            this.pt_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_resim.TabIndex = 1;
            this.pt_resim.TabStop = false;
            this.pt_resim.Click += new System.EventHandler(this.pt_resim_Click);
            // 
            // pt_YResim
            // 
            this.pt_YResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pt_YResim.Location = new System.Drawing.Point(350, 27);
            this.pt_YResim.Name = "pt_YResim";
            this.pt_YResim.Size = new System.Drawing.Size(301, 373);
            this.pt_YResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_YResim.TabIndex = 6;
            this.pt_YResim.TabStop = false;
            this.pt_YResim.Click += new System.EventHandler(this.pt_YResim_Click);
            // 
            // btn_piksel
            // 
            this.btn_piksel.Location = new System.Drawing.Point(585, 415);
            this.btn_piksel.Name = "btn_piksel";
            this.btn_piksel.Size = new System.Drawing.Size(75, 23);
            this.btn_piksel.TabIndex = 7;
            this.btn_piksel.Text = "Dönüşüm";
            this.btn_piksel.UseVisualStyleBackColor = true;
            this.btn_piksel.Click += new System.EventHandler(this.btn_piksel_Click);
            // 
            // lbl_gri
            // 
            this.lbl_gri.AutoSize = true;
            this.lbl_gri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gri.Location = new System.Drawing.Point(423, 415);
            this.lbl_gri.Name = "lbl_gri";
            this.lbl_gri.Size = new System.Drawing.Size(41, 26);
            this.lbl_gri.TabIndex = 8;
            this.lbl_gri.Text = "G: ";
            this.lbl_gri.Click += new System.EventHandler(this.lbl_gri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.lbl_gri);
            this.Controls.Add(this.btn_piksel);
            this.Controls.Add(this.pt_YResim);
            this.Controls.Add(this.pt_resim);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pt_resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_YResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pt_resim;
        private System.Windows.Forms.PictureBox pt_YResim;
        private System.Windows.Forms.Button btn_piksel;
        private System.Windows.Forms.Label lbl_gri;
    }
}

