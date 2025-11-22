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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblOpcional = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrorCorreo = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorApePaterno = new System.Windows.Forms.Label();
            this.lblErrorApeMaterno = new System.Windows.Forms.Label();
            this.lblErrorDocumento = new System.Windows.Forms.Label();
            this.lblErrorTelefono = new System.Windows.Forms.Label();
            this.lblErrorFechaNacimiento = new System.Windows.Forms.Label();
            this.lblErrorGenero = new System.Windows.Forms.Label();
            this.lblErrorNomUsuario = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.lblErrorContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.lblErrorDocCombox = new System.Windows.Forms.Label();
            this.lineControl9 = new LineControl();
            this.lineControl10 = new LineControl();
            this.lineControl11 = new LineControl();
            this.lineControl12 = new LineControl();
            this.lineControl13 = new LineControl();
            this.lineControl14 = new LineControl();
            this.lineControl15 = new LineControl();
            this.lineControl16 = new LineControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 762);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(97, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CREAR CUENTA";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(103, 51);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(372, 20);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "CORREO";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(103, 111);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "NOMBRE";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(103, 168);
            this.txtApellidoPaterno.MaxLength = 50;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(175, 20);
            this.txtApellidoPaterno.TabIndex = 7;
            this.txtApellidoPaterno.Text = "APELLIDO PATERNO";
            this.txtApellidoPaterno.Enter += new System.EventHandler(this.txtApellidoPaterno_Enter);
            this.txtApellidoPaterno.Leave += new System.EventHandler(this.txtApellidoPaterno_Leave);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(304, 168);
            this.txtApellidoMaterno.MaxLength = 50;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(175, 20);
            this.txtApellidoMaterno.TabIndex = 9;
            this.txtApellidoMaterno.Text = "APELLIDO MATERNO";
            this.txtApellidoMaterno.Enter += new System.EventHandler(this.txtApellidoMaterno_Enter);
            this.txtApellidoMaterno.Leave += new System.EventHandler(this.txtApellidoMaterno_Leave);
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.DimGray;
            this.txtDocumento.Location = new System.Drawing.Point(303, 232);
            this.txtDocumento.MaxLength = 12;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(175, 20);
            this.txtDocumento.TabIndex = 11;
            this.txtDocumento.Text = "DOCUMENTO";
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtDocumento.Enter += new System.EventHandler(this.txtDocumento_Enter);
            this.txtDocumento.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumento.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(103, 229);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(185, 29);
            this.cmbTipoDocumento.TabIndex = 24;
            this.cmbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(99, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(99, 309);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(179, 26);
            this.dtpFechaNacimiento.TabIndex = 26;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(303, 284);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(179, 20);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.Text = "TELEFONO";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // lblOpcional
            // 
            this.lblOpcional.AutoSize = true;
            this.lblOpcional.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcional.ForeColor = System.Drawing.Color.LightCoral;
            this.lblOpcional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOpcional.Location = new System.Drawing.Point(419, 318);
            this.lblOpcional.Name = "lblOpcional";
            this.lblOpcional.Size = new System.Drawing.Size(58, 16);
            this.lblOpcional.TabIndex = 30;
            this.lblOpcional.Text = "Opcional";
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "HOMBRE",
            "MUJER"});
            this.cmbGenero.Location = new System.Drawing.Point(195, 375);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(161, 21);
            this.cmbGenero.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(99, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "GENERO";
            // 
            // lblErrorCorreo
            // 
            this.lblErrorCorreo.AutoSize = true;
            this.lblErrorCorreo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCorreo.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorCorreo.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorCorreo.Location = new System.Drawing.Point(100, 83);
            this.lblErrorCorreo.Name = "lblErrorCorreo";
            this.lblErrorCorreo.Size = new System.Drawing.Size(96, 16);
            this.lblErrorCorreo.TabIndex = 33;
            this.lblErrorCorreo.Text = "Mensaje de Error";
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorNombre.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorNombre.Location = new System.Drawing.Point(100, 143);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(96, 16);
            this.lblErrorNombre.TabIndex = 34;
            this.lblErrorNombre.Text = "Mensaje de Error";
            // 
            // lblErrorApePaterno
            // 
            this.lblErrorApePaterno.AutoSize = true;
            this.lblErrorApePaterno.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorApePaterno.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorApePaterno.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorApePaterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorApePaterno.Location = new System.Drawing.Point(100, 200);
            this.lblErrorApePaterno.Name = "lblErrorApePaterno";
            this.lblErrorApePaterno.Size = new System.Drawing.Size(96, 16);
            this.lblErrorApePaterno.TabIndex = 35;
            this.lblErrorApePaterno.Text = "Mensaje de Error";
            // 
            // lblErrorApeMaterno
            // 
            this.lblErrorApeMaterno.AutoSize = true;
            this.lblErrorApeMaterno.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorApeMaterno.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorApeMaterno.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorApeMaterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorApeMaterno.Location = new System.Drawing.Point(301, 200);
            this.lblErrorApeMaterno.Name = "lblErrorApeMaterno";
            this.lblErrorApeMaterno.Size = new System.Drawing.Size(96, 16);
            this.lblErrorApeMaterno.TabIndex = 36;
            this.lblErrorApeMaterno.Text = "Mensaje de Error";
            // 
            // lblErrorDocumento
            // 
            this.lblErrorDocumento.AutoSize = true;
            this.lblErrorDocumento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDocumento.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorDocumento.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorDocumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorDocumento.Location = new System.Drawing.Point(301, 262);
            this.lblErrorDocumento.Name = "lblErrorDocumento";
            this.lblErrorDocumento.Size = new System.Drawing.Size(96, 16);
            this.lblErrorDocumento.TabIndex = 37;
            this.lblErrorDocumento.Text = "Mensaje de Error";
            // 
            // lblErrorTelefono
            // 
            this.lblErrorTelefono.AutoSize = true;
            this.lblErrorTelefono.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTelefono.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorTelefono.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorTelefono.Location = new System.Drawing.Point(301, 320);
            this.lblErrorTelefono.Name = "lblErrorTelefono";
            this.lblErrorTelefono.Size = new System.Drawing.Size(96, 16);
            this.lblErrorTelefono.TabIndex = 38;
            this.lblErrorTelefono.Text = "Mensaje de Error";
            // 
            // lblErrorFechaNacimiento
            // 
            this.lblErrorFechaNacimiento.AutoSize = true;
            this.lblErrorFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFechaNacimiento.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorFechaNacimiento.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorFechaNacimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorFechaNacimiento.Location = new System.Drawing.Point(100, 338);
            this.lblErrorFechaNacimiento.Name = "lblErrorFechaNacimiento";
            this.lblErrorFechaNacimiento.Size = new System.Drawing.Size(96, 16);
            this.lblErrorFechaNacimiento.TabIndex = 39;
            this.lblErrorFechaNacimiento.Text = "Mensaje de Error";
            // 
            // lblErrorGenero
            // 
            this.lblErrorGenero.AutoSize = true;
            this.lblErrorGenero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGenero.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorGenero.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorGenero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorGenero.Location = new System.Drawing.Point(260, 399);
            this.lblErrorGenero.Name = "lblErrorGenero";
            this.lblErrorGenero.Size = new System.Drawing.Size(96, 16);
            this.lblErrorGenero.TabIndex = 40;
            this.lblErrorGenero.Text = "Mensaje de Error";
            // 
            // lblErrorNomUsuario
            // 
            this.lblErrorNomUsuario.AutoSize = true;
            this.lblErrorNomUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNomUsuario.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorNomUsuario.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorNomUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorNomUsuario.Location = new System.Drawing.Point(100, 461);
            this.lblErrorNomUsuario.Name = "lblErrorNomUsuario";
            this.lblErrorNomUsuario.Size = new System.Drawing.Size(96, 16);
            this.lblErrorNomUsuario.TabIndex = 43;
            this.lblErrorNomUsuario.Text = "Mensaje de Error";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomUsuario.Location = new System.Drawing.Point(103, 429);
            this.txtNomUsuario.MaxLength = 50;
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(372, 20);
            this.txtNomUsuario.TabIndex = 41;
            this.txtNomUsuario.Text = "NOMBRE DE USUARIO";
            this.txtNomUsuario.Enter += new System.EventHandler(this.txtNomUsuario_Enter);
            this.txtNomUsuario.Leave += new System.EventHandler(this.txtNomUsuario_Leave);
            // 
            // lblErrorContraseña
            // 
            this.lblErrorContraseña.AutoSize = true;
            this.lblErrorContraseña.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorContraseña.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorContraseña.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorContraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorContraseña.Location = new System.Drawing.Point(100, 543);
            this.lblErrorContraseña.Name = "lblErrorContraseña";
            this.lblErrorContraseña.Size = new System.Drawing.Size(96, 16);
            this.lblErrorContraseña.TabIndex = 46;
            this.lblErrorContraseña.Text = "Mensaje de Error";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(103, 503);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(372, 20);
            this.txtContraseña.TabIndex = 44;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.LightGray;
            this.btnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnCrearCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCrearCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(99, 596);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(372, 40);
            this.btnCrearCuenta.TabIndex = 47;
            this.btnCrearCuenta.Text = "CREAR CUENTA";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // lblErrorDocCombox
            // 
            this.lblErrorDocCombox.AutoSize = true;
            this.lblErrorDocCombox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDocCombox.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorDocCombox.Image = global::CapaPresentacion.Properties.Resources.imgWarningRed20x20;
            this.lblErrorDocCombox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorDocCombox.Location = new System.Drawing.Point(100, 261);
            this.lblErrorDocCombox.Name = "lblErrorDocCombox";
            this.lblErrorDocCombox.Size = new System.Drawing.Size(96, 16);
            this.lblErrorDocCombox.TabIndex = 48;
            this.lblErrorDocCombox.Text = "Mensaje de Error";
            // 
            // lineControl9
            // 
            this.lineControl9.LineColor = System.Drawing.Color.White;
            this.lineControl9.Location = new System.Drawing.Point(103, 70);
            this.lineControl9.Name = "lineControl9";
            this.lineControl9.Size = new System.Drawing.Size(185, 10);
            this.lineControl9.TabIndex = 49;
            this.lineControl9.Text = "lineControl9";
            // 
            // lineControl10
            // 
            this.lineControl10.LineColor = System.Drawing.Color.White;
            this.lineControl10.Location = new System.Drawing.Point(103, 130);
            this.lineControl10.Name = "lineControl10";
            this.lineControl10.Size = new System.Drawing.Size(185, 10);
            this.lineControl10.TabIndex = 50;
            this.lineControl10.Text = "lineControl10";
            // 
            // lineControl11
            // 
            this.lineControl11.LineColor = System.Drawing.Color.White;
            this.lineControl11.Location = new System.Drawing.Point(103, 187);
            this.lineControl11.Name = "lineControl11";
            this.lineControl11.Size = new System.Drawing.Size(185, 10);
            this.lineControl11.TabIndex = 51;
            this.lineControl11.Text = "lineControl11";
            // 
            // lineControl12
            // 
            this.lineControl12.LineColor = System.Drawing.Color.White;
            this.lineControl12.Location = new System.Drawing.Point(304, 187);
            this.lineControl12.Name = "lineControl12";
            this.lineControl12.Size = new System.Drawing.Size(185, 10);
            this.lineControl12.TabIndex = 52;
            this.lineControl12.Text = "lineControl12";
            // 
            // lineControl13
            // 
            this.lineControl13.LineColor = System.Drawing.Color.White;
            this.lineControl13.Location = new System.Drawing.Point(304, 249);
            this.lineControl13.Name = "lineControl13";
            this.lineControl13.Size = new System.Drawing.Size(185, 10);
            this.lineControl13.TabIndex = 53;
            this.lineControl13.Text = "lineControl13";
            // 
            // lineControl14
            // 
            this.lineControl14.LineColor = System.Drawing.Color.White;
            this.lineControl14.Location = new System.Drawing.Point(304, 305);
            this.lineControl14.Name = "lineControl14";
            this.lineControl14.Size = new System.Drawing.Size(185, 10);
            this.lineControl14.TabIndex = 54;
            this.lineControl14.Text = "lineControl14";
            // 
            // lineControl15
            // 
            this.lineControl15.LineColor = System.Drawing.Color.White;
            this.lineControl15.Location = new System.Drawing.Point(103, 448);
            this.lineControl15.Name = "lineControl15";
            this.lineControl15.Size = new System.Drawing.Size(185, 10);
            this.lineControl15.TabIndex = 55;
            this.lineControl15.Text = "lineControl15";
            // 
            // lineControl16
            // 
            this.lineControl16.LineColor = System.Drawing.Color.White;
            this.lineControl16.Location = new System.Drawing.Point(103, 529);
            this.lineControl16.Name = "lineControl16";
            this.lineControl16.Size = new System.Drawing.Size(185, 10);
            this.lineControl16.TabIndex = 56;
            this.lineControl16.Text = "lineControl16";
            // 
            // frmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(632, 762);
            this.Controls.Add(this.lineControl16);
            this.Controls.Add(this.lineControl15);
            this.Controls.Add(this.lineControl14);
            this.Controls.Add(this.lineControl13);
            this.Controls.Add(this.lineControl12);
            this.Controls.Add(this.lineControl11);
            this.Controls.Add(this.lineControl10);
            this.Controls.Add(this.lineControl9);
            this.Controls.Add(this.lblErrorDocCombox);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.lblErrorContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblErrorNomUsuario);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.lblErrorGenero);
            this.Controls.Add(this.lblErrorFechaNacimiento);
            this.Controls.Add(this.lblErrorTelefono);
            this.Controls.Add(this.lblErrorDocumento);
            this.Controls.Add(this.lblErrorApeMaterno);
            this.Controls.Add(this.lblErrorApePaterno);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblErrorCorreo);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOpcional);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearCuen";
            this.Load += new System.EventHandler(this.frmCrearCuen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private LineControl lineControl1;
        private System.Windows.Forms.TextBox txtCorreo;
        private LineControl lineControl2;
        private System.Windows.Forms.TextBox txtNombre;
        private LineControl lineControl3;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private LineControl lineControl4;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private LineControl lineControl5;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private LineControl lineControl6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblOpcional;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrorCorreo;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorApePaterno;
        private System.Windows.Forms.Label lblErrorApeMaterno;
        private System.Windows.Forms.Label lblErrorDocumento;
        private System.Windows.Forms.Label lblErrorTelefono;
        private System.Windows.Forms.Label lblErrorFechaNacimiento;
        private System.Windows.Forms.Label lblErrorGenero;
        private System.Windows.Forms.Label lblErrorNomUsuario;
        private LineControl lineControl7;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label lblErrorContraseña;
        private LineControl lineControl8;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Label lblErrorDocCombox;
        private LineControl lineControl9;
        private LineControl lineControl10;
        private LineControl lineControl11;
        private LineControl lineControl12;
        private LineControl lineControl13;
        private LineControl lineControl14;
        private LineControl lineControl15;
        private LineControl lineControl16;
    }
}