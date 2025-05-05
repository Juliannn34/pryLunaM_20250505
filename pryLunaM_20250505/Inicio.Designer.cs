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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.numFuerza = new System.Windows.Forms.NumericUpDown();
            this.numDestreza = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDestreza)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSuperheroe
            // 
            this.cmbSuperheroe.FormattingEnabled = true;
            this.cmbSuperheroe.Location = new System.Drawing.Point(24, 38);
            this.cmbSuperheroe.Name = "cmbSuperheroe";
            this.cmbSuperheroe.Size = new System.Drawing.Size(121, 21);
            this.cmbSuperheroe.TabIndex = 0;
            this.cmbSuperheroe.SelectedIndexChanged += new System.EventHandler(this.cmbSuperheroe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Superheroe";
            // 
            // picImagen
            // 
            this.picImagen.Image = global::pryLunaM_20250505.Properties.Resources.fea23152696aa824fc0bbd224a6d889a;
            this.picImagen.Location = new System.Drawing.Point(24, 81);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(152, 106);
            this.picImagen.TabIndex = 2;
            this.picImagen.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numDestreza);
            this.groupBox1.Controls.Add(this.numFuerza);
            this.groupBox1.Controls.Add(this.lblDestreza);
            this.groupBox1.Controls.Add(this.lblFuerza);
            this.groupBox1.Location = new System.Drawing.Point(32, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Personaje";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(260, 392);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFuerza.Location = new System.Drawing.Point(32, 45);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(42, 13);
            this.lblFuerza.TabIndex = 5;
            this.lblFuerza.Text = "Fuerza:";
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDestreza.Location = new System.Drawing.Point(32, 95);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(52, 13);
            this.lblDestreza.TabIndex = 6;
            this.lblDestreza.Text = "Destreza:";
            // 
            // numFuerza
            // 
            this.numFuerza.Location = new System.Drawing.Point(138, 43);
            this.numFuerza.Name = "numFuerza";
            this.numFuerza.Size = new System.Drawing.Size(120, 20);
            this.numFuerza.TabIndex = 7;
            // 
            // numDestreza
            // 
            this.numDestreza.Location = new System.Drawing.Point(138, 95);
            this.numDestreza.Name = "numDestreza";
            this.numDestreza.Size = new System.Drawing.Size(120, 20);
            this.numDestreza.TabIndex = 8;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 587);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSuperheroe);
            this.Name = "Inicio";
            this.Text = "Proyecto Base";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDestreza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSuperheroe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numDestreza;
        private System.Windows.Forms.NumericUpDown numFuerza;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Button btnCrear;
    }
}

