namespace CapaPresentacion
{
    partial class frmPaginaPrincipal
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
            this.btnCrearEquipo = new System.Windows.Forms.Button();
            this.gpbAcciones = new System.Windows.Forms.GroupBox();
            this.gpbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearEquipo
            // 
            this.btnCrearEquipo.Location = new System.Drawing.Point(29, 32);
            this.btnCrearEquipo.Name = "btnCrearEquipo";
            this.btnCrearEquipo.Size = new System.Drawing.Size(89, 23);
            this.btnCrearEquipo.TabIndex = 0;
            this.btnCrearEquipo.Text = "Crear Equipo";
            this.btnCrearEquipo.UseVisualStyleBackColor = true;
            // 
            // gpbAcciones
            // 
            this.gpbAcciones.Controls.Add(this.btnCrearEquipo);
            this.gpbAcciones.Location = new System.Drawing.Point(22, 35);
            this.gpbAcciones.Name = "gpbAcciones";
            this.gpbAcciones.Size = new System.Drawing.Size(166, 324);
            this.gpbAcciones.TabIndex = 1;
            this.gpbAcciones.TabStop = false;
            this.gpbAcciones.Text = "Acciones";
            // 
            // frmPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbAcciones);
            this.Name = "frmPaginaPrincipal";
            this.Text = "frmPaginaPrincipal";
            this.gpbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearEquipo;
        private System.Windows.Forms.GroupBox gpbAcciones;
    }
}