﻿namespace muzik_vt_815
{
    partial class FormTumSarkilar
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
            this.dgwTumSarkilar = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblSure = new System.Windows.Forms.Label();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.cbFavori = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtSanatci = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTumSarkilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTumSarkilar
            // 
            this.dgwTumSarkilar.AllowUserToAddRows = false;
            this.dgwTumSarkilar.AllowUserToDeleteRows = false;
            this.dgwTumSarkilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTumSarkilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTumSarkilar.Location = new System.Drawing.Point(12, 180);
            this.dgwTumSarkilar.Name = "dgwTumSarkilar";
            this.dgwTumSarkilar.ReadOnly = true;
            this.dgwTumSarkilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTumSarkilar.Size = new System.Drawing.Size(776, 258);
            this.dgwTumSarkilar.TabIndex = 0;
            this.dgwTumSarkilar.SelectionChanged += new System.EventHandler(this.dgwTumSarkilar_SelectionChanged);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::muzik_vt_815.Properties.Resources._001_delete;
            this.btnSil.Location = new System.Drawing.Point(702, 108);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 56);
            this.btnSil.TabIndex = 1;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(52, 128);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(35, 16);
            this.lblSure.TabIndex = 28;
            this.lblSure.Text = "Süre";
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(99, 127);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(155, 20);
            this.txtSure.TabIndex = 27;
            // 
            // cbFavori
            // 
            this.cbFavori.AutoSize = true;
            this.cbFavori.Location = new System.Drawing.Point(379, 90);
            this.cbFavori.Name = "cbFavori";
            this.cbFavori.Size = new System.Drawing.Size(55, 17);
            this.cbFavori.TabIndex = 26;
            this.cbFavori.Text = "Favori";
            this.cbFavori.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(270, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Eklenme Tarihi";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(379, 51);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(155, 20);
            this.dtTarih.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(340, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sanatçı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Şarkı Adı";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(379, 15);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(155, 21);
            this.cmbTur.TabIndex = 19;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(99, 91);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(155, 20);
            this.txtYil.TabIndex = 18;
            // 
            // txtSanatci
            // 
            this.txtSanatci.Location = new System.Drawing.Point(99, 51);
            this.txtSanatci.Name = "txtSanatci";
            this.txtSanatci.Size = new System.Drawing.Size(155, 20);
            this.txtSanatci.TabIndex = 17;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(99, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(155, 20);
            this.txtAd.TabIndex = 16;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::muzik_vt_815.Properties.Resources._007_updating;
            this.btnGuncelle.Location = new System.Drawing.Point(597, 108);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 56);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FormTumSarkilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.cbFavori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtSanatci);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgwTumSarkilar);
            this.Name = "FormTumSarkilar";
            this.Text = "FormTumSarkilar";
            this.Load += new System.EventHandler(this.FormTumSarkilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTumSarkilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTumSarkilar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.CheckBox cbFavori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtSanatci;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnGuncelle;
    }
}