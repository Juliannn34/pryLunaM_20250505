namespace pryLunaM_20250505
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSuperheroe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSuperheroe
            // 
            this.cmbSuperheroe.FormattingEnabled = true;
            this.cmbSuperheroe.Location = new System.Drawing.Point(127, 150);
            this.cmbSuperheroe.Name = "cmbSuperheroe";
            this.cmbSuperheroe.Size = new System.Drawing.Size(121, 21);
            this.cmbSuperheroe.TabIndex = 0;
            this.cmbSuperheroe.SelectedIndexChanged += new System.EventHandler(this.cmbSuperheroe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(124, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Superheroe";
            // 
            // picImagen
            // 
            this.picImagen.Image = global::pryLunaM_20250505.Properties.Resources.fea23152696aa824fc0bbd224a6d889a;
            this.picImagen.Location = new System.Drawing.Point(127, 193);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(250, 182);
            this.picImagen.TabIndex = 2;
            this.picImagen.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 472);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSuperheroe);
            this.Name = "Inicio";
            this.Text = "Proyecto Base";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSuperheroe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImagen;
    }
}

