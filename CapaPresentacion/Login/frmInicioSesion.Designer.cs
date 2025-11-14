namespace CapaPresentacion
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(115, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(89, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INICIAR SESION";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.txtCorreo.Location = new System.Drawing.Point(27, 267);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(252, 20);
            this.txtCorreo.TabIndex = 1;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCorreo.Location = new System.Drawing.Point(24, 241);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(43, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.txtContraseña.Location = new System.Drawing.Point(27, 342);
            this.txtContraseña.MaxLength = 25;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(252, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(103)))), ((int)(((byte)(242)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(85, 422);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(122, 28);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.ptbCerrar);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 50);
            this.panel2.TabIndex = 8;
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(254, 12);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(25, 25);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCerrar.TabIndex = 0;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lnkCrearCuenta
            // 
            this.lnkCrearCuenta.ActiveLinkColor = System.Drawing.Color.Chartreuse;
            this.lnkCrearCuenta.AutoSize = true;
            this.lnkCrearCuenta.LinkColor = System.Drawing.Color.White;
            this.lnkCrearCuenta.Location = new System.Drawing.Point(95, 471);
            this.lnkCrearCuenta.Name = "lnkCrearCuenta";
            this.lnkCrearCuenta.Size = new System.Drawing.Size(100, 13);
            this.lnkCrearCuenta.TabIndex = 10;
            this.lnkCrearCuenta.TabStop = true;
            this.lnkCrearCuenta.Text = "¿No tienes cuenta?";
            this.lnkCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCrearCuenta_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(27, 387);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Recordar contraseña";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(303, 514);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lnkCrearCuenta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkCrearCuenta;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

