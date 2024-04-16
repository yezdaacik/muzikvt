namespace muzik_vt_815
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
            this.btnTumSarkilar = new System.Windows.Forms.Button();
            this.btnEkleForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTumSarkilar
            // 
            this.btnTumSarkilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumSarkilar.Location = new System.Drawing.Point(218, 54);
            this.btnTumSarkilar.Name = "btnTumSarkilar";
            this.btnTumSarkilar.Size = new System.Drawing.Size(153, 78);
            this.btnTumSarkilar.TabIndex = 1;
            this.btnTumSarkilar.Text = "Tüm Şarkılar";
            this.btnTumSarkilar.UseVisualStyleBackColor = true;
            this.btnTumSarkilar.Click += new System.EventHandler(this.btnTumSarkilar_Click);
            // 
            // btnEkleForm
            // 
            this.btnEkleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleForm.Location = new System.Drawing.Point(41, 54);
            this.btnEkleForm.Name = "btnEkleForm";
            this.btnEkleForm.Size = new System.Drawing.Size(153, 78);
            this.btnEkleForm.TabIndex = 0;
            this.btnEkleForm.Text = "Şarkı Ekle";
            this.btnEkleForm.UseVisualStyleBackColor = true;
            this.btnEkleForm.Click += new System.EventHandler(this.btnEkleForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 175);
            this.Controls.Add(this.btnTumSarkilar);
            this.Controls.Add(this.btnEkleForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkleForm;
        private System.Windows.Forms.Button btnTumSarkilar;
    }
}

