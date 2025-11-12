namespace CapaPresentacion
{
    partial class frmCrearCuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbInfoCuenta = new System.Windows.Forms.GroupBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.gpbInfoPersonal = new System.Windows.Forms.GroupBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.gpbInfoCuenta.SuspendLayout();
            this.gpbInfoPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(134, 94);
            this.txtContraseña.MaxLength = 10;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 8;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(19, 74);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(134, 68);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(174, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "CREAR CUENTA";
            // 
            // gpbInfoCuenta
            // 
            this.gpbInfoCuenta.Controls.Add(this.txtNomUsuario);
            this.gpbInfoCuenta.Controls.Add(this.lblNomUsuario);
            this.gpbInfoCuenta.Controls.Add(this.txtContraseña);
            this.gpbInfoCuenta.Controls.Add(this.label1);
            this.gpbInfoCuenta.Controls.Add(this.txtCorreo);
            this.gpbInfoCuenta.Controls.Add(this.lblCorreo);
            this.gpbInfoCuenta.Location = new System.Drawing.Point(43, 89);
            this.gpbInfoCuenta.Name = "gpbInfoCuenta";
            this.gpbInfoCuenta.Size = new System.Drawing.Size(253, 156);
            this.gpbInfoCuenta.TabIndex = 10;
            this.gpbInfoCuenta.TabStop = false;
            this.gpbInfoCuenta.Text = "Infromacion de la Cuenta";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(134, 42);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 10;
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(19, 48);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblNomUsuario.TabIndex = 11;
            this.lblNomUsuario.Text = "Nombre de Usuario";
            // 
            // gpbInfoPersonal
            // 
            this.gpbInfoPersonal.Controls.Add(this.txttelefono);
            this.gpbInfoPersonal.Controls.Add(this.lblCelular);
            this.gpbInfoPersonal.Controls.Add(this.dtpNacimiento);
            this.gpbInfoPersonal.Controls.Add(this.lblFechaNacimiento);
            this.gpbInfoPersonal.Controls.Add(this.txtMaterno);
            this.gpbInfoPersonal.Controls.Add(this.lblMaterno);
            this.gpbInfoPersonal.Controls.Add(this.txtPaterno);
            this.gpbInfoPersonal.Controls.Add(this.lblPaterno);
            this.gpbInfoPersonal.Controls.Add(this.txtNombres);
            this.gpbInfoPersonal.Controls.Add(this.lblNombres);
            this.gpbInfoPersonal.Location = new System.Drawing.Point(324, 89);
            this.gpbInfoPersonal.Name = "gpbInfoPersonal";
            this.gpbInfoPersonal.Size = new System.Drawing.Size(360, 228);
            this.gpbInfoPersonal.TabIndex = 11;
            this.gpbInfoPersonal.TabStop = false;
            this.gpbInfoPersonal.Text = "Informacion Personal";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(134, 33);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(194, 20);
            this.txtNombres.TabIndex = 12;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(79, 40);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 13;
            this.lblNombres.Text = "Nombres";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(134, 66);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(194, 20);
            this.txtPaterno.TabIndex = 14;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(44, 73);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblPaterno.TabIndex = 15;
            this.lblPaterno.Text = "Apellido Paterno";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(134, 104);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(194, 20);
            this.txtMaterno.TabIndex = 16;
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(42, 107);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(86, 13);
            this.lblMaterno.TabIndex = 17;
            this.lblMaterno.Text = "Apellido Materno";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 154);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 18;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(134, 148);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 19;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(79, 186);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(49, 13);
            this.lblCelular.TabIndex = 20;
            this.lblCelular.Text = "Telefono";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(140, 186);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(194, 20);
            this.txttelefono.TabIndex = 21;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(43, 265);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // frmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.gpbInfoPersonal);
            this.Controls.Add(this.gpbInfoCuenta);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCrearCuenta";
            this.Text = "frmCrearCuenta";
            this.gpbInfoCuenta.ResumeLayout(false);
            this.gpbInfoCuenta.PerformLayout();
            this.gpbInfoPersonal.ResumeLayout(false);
            this.gpbInfoPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbInfoCuenta;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.GroupBox gpbInfoPersonal;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnCrear;
    }
}