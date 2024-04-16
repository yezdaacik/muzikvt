namespace muzik_vt_815
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
            // FormTumSarkilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgwTumSarkilar);
            this.Name = "FormTumSarkilar";
            this.Text = "FormTumSarkilar";
            this.Load += new System.EventHandler(this.FormTumSarkilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTumSarkilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTumSarkilar;
        private System.Windows.Forms.Button btnSil;
    }
}