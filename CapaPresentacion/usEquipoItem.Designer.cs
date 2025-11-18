namespace CapaPresentacion
{
    partial class usEquipoItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEquipo.ForeColor = System.Drawing.Color.Gray;
            this.lblNombreEquipo.Location = new System.Drawing.Point(173, 26);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(127, 19);
            this.lblNombreEquipo.TabIndex = 1;
            this.lblNombreEquipo.Text = "NombreEquipo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed;
            this.pictureBox1.Location = new System.Drawing.Point(22, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(3, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(338, 70);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion del Equipo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Location = new System.Drawing.Point(177, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 70);
            this.panel1.TabIndex = 4;
            // 
            // usEquipoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombreEquipo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "usEquipoItem";
            this.Size = new System.Drawing.Size(557, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panel1;
    }
}
