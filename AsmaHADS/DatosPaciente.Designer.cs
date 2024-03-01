namespace AsmaHADS
{
    partial class DatosPaciente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosPaciente));
            this.DatosContacto = new System.Windows.Forms.TabControl();
            this.tbcDatosPrincipales = new System.Windows.Forms.TabPage();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNIdentificacion = new System.Windows.Forms.TextBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cboTidentificacion = new System.Windows.Forms.ComboBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblNIdentificacion = new System.Windows.Forms.Label();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.tbcDatosContacto = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSubsidiado = new System.Windows.Forms.RadioButton();
            this.rdbContributivo = new System.Windows.Forms.RadioButton();
            this.cboEps = new System.Windows.Forms.ComboBox();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.lblEps = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNEscolaridad = new System.Windows.Forms.ComboBox();
            this.txtCEmergencia = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboOcupacion = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cboCiudadResidencia = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNEscolaridad = new System.Windows.Forms.Label();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblCEmergencia = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCiudadResidencia = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.erpDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpDatosPaciente = new System.Windows.Forms.ToolTip(this.components);
            this.DatosContacto.SuspendLayout();
            this.tbcDatosPrincipales.SuspendLayout();
            this.tbcDatosContacto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosContacto
            // 
            this.DatosContacto.Controls.Add(this.tbcDatosPrincipales);
            this.DatosContacto.Controls.Add(this.tbcDatosContacto);
            this.DatosContacto.Location = new System.Drawing.Point(12, 27);
            this.DatosContacto.Name = "DatosContacto";
            this.DatosContacto.SelectedIndex = 0;
            this.DatosContacto.Size = new System.Drawing.Size(768, 427);
            this.DatosContacto.TabIndex = 0;
            // 
            // tbcDatosPrincipales
            // 
            this.tbcDatosPrincipales.Controls.Add(this.rdbNoBinario);
            this.tbcDatosPrincipales.Controls.Add(this.rdbFemenino);
            this.tbcDatosPrincipales.Controls.Add(this.rdbMasculino);
            this.tbcDatosPrincipales.Controls.Add(this.dtpNacimiento);
            this.tbcDatosPrincipales.Controls.Add(this.txtNIdentificacion);
            this.tbcDatosPrincipales.Controls.Add(this.cboEstadoCivil);
            this.tbcDatosPrincipales.Controls.Add(this.cboTidentificacion);
            this.tbcDatosPrincipales.Controls.Add(this.txtApellidos);
            this.tbcDatosPrincipales.Controls.Add(this.txtNombres);
            this.tbcDatosPrincipales.Controls.Add(this.lblGenero);
            this.tbcDatosPrincipales.Controls.Add(this.lblEstado);
            this.tbcDatosPrincipales.Controls.Add(this.lblNacimiento);
            this.tbcDatosPrincipales.Controls.Add(this.lblNIdentificacion);
            this.tbcDatosPrincipales.Controls.Add(this.lblTipoIdentificacion);
            this.tbcDatosPrincipales.Controls.Add(this.lblApellidos);
            this.tbcDatosPrincipales.Controls.Add(this.lblNombres);
            this.tbcDatosPrincipales.Location = new System.Drawing.Point(4, 24);
            this.tbcDatosPrincipales.Name = "tbcDatosPrincipales";
            this.tbcDatosPrincipales.Padding = new System.Windows.Forms.Padding(3);
            this.tbcDatosPrincipales.Size = new System.Drawing.Size(760, 399);
            this.tbcDatosPrincipales.TabIndex = 0;
            this.tbcDatosPrincipales.Text = "Datos Principales";
            this.tbcDatosPrincipales.UseVisualStyleBackColor = true;
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbNoBinario.Location = new System.Drawing.Point(542, 285);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(99, 20);
            this.rdbNoBinario.TabIndex = 15;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No Binario";
            this.tlpDatosPaciente.SetToolTip(this.rdbNoBinario, "No binario");
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbFemenino.Location = new System.Drawing.Point(404, 285);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(94, 20);
            this.rdbFemenino.TabIndex = 14;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.tlpDatosPaciente.SetToolTip(this.rdbFemenino, "Femenino");
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbMasculino.Location = new System.Drawing.Point(265, 285);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(95, 20);
            this.rdbMasculino.TabIndex = 13;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.tlpDatosPaciente.SetToolTip(this.rdbMasculino, "Masculino");
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(265, 195);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(376, 23);
            this.dtpNacimiento.TabIndex = 12;
            this.tlpDatosPaciente.SetToolTip(this.dtpNacimiento, "Ingrese su fecha de nacimiento");
            // 
            // txtNIdentificacion
            // 
            this.txtNIdentificacion.Location = new System.Drawing.Point(267, 157);
            this.txtNIdentificacion.Name = "txtNIdentificacion";
            this.txtNIdentificacion.Size = new System.Drawing.Size(374, 23);
            this.txtNIdentificacion.TabIndex = 11;
            this.tlpDatosPaciente.SetToolTip(this.txtNIdentificacion, "Ingrese su número de identificación");
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(265, 238);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(376, 23);
            this.cboEstadoCivil.TabIndex = 10;
            this.tlpDatosPaciente.SetToolTip(this.cboEstadoCivil, "Seleccione su estado civil");
            // 
            // cboTidentificacion
            // 
            this.cboTidentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTidentificacion.FormattingEnabled = true;
            this.cboTidentificacion.Location = new System.Drawing.Point(267, 115);
            this.cboTidentificacion.Name = "cboTidentificacion";
            this.cboTidentificacion.Size = new System.Drawing.Size(374, 23);
            this.cboTidentificacion.TabIndex = 9;
            this.tlpDatosPaciente.SetToolTip(this.cboTidentificacion, "Seleccione un tipo de identificación");
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(265, 78);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(376, 23);
            this.txtApellidos.TabIndex = 8;
            this.tlpDatosPaciente.SetToolTip(this.txtApellidos, "Ingrese sus apellidos");
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(265, 38);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(376, 23);
            this.txtNombres.TabIndex = 7;
            this.tlpDatosPaciente.SetToolTip(this.txtNombres, "Ingrese sus nombres");
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.Location = new System.Drawing.Point(50, 285);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(59, 16);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Género";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.Location = new System.Drawing.Point(50, 245);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(92, 16);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado Civil";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNacimiento.Location = new System.Drawing.Point(50, 200);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(156, 16);
            this.lblNacimiento.TabIndex = 4;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblNIdentificacion
            // 
            this.lblNIdentificacion.AutoSize = true;
            this.lblNIdentificacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNIdentificacion.Location = new System.Drawing.Point(50, 159);
            this.lblNIdentificacion.Name = "lblNIdentificacion";
            this.lblNIdentificacion.Size = new System.Drawing.Size(187, 16);
            this.lblNIdentificacion.TabIndex = 3;
            this.lblNIdentificacion.Text = "Número de Identificación";
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(50, 122);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(162, 16);
            this.lblTipoIdentificacion.TabIndex = 2;
            this.lblTipoIdentificacion.Text = "Tipo de Identificación";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellidos.Location = new System.Drawing.Point(50, 80);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(72, 16);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombres.Location = new System.Drawing.Point(50, 40);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(70, 16);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres";
            // 
            // tbcDatosContacto
            // 
            this.tbcDatosContacto.Controls.Add(this.groupBox2);
            this.tbcDatosContacto.Controls.Add(this.groupBox1);
            this.tbcDatosContacto.Location = new System.Drawing.Point(4, 24);
            this.tbcDatosContacto.Name = "tbcDatosContacto";
            this.tbcDatosContacto.Padding = new System.Windows.Forms.Padding(3);
            this.tbcDatosContacto.Size = new System.Drawing.Size(760, 399);
            this.tbcDatosContacto.TabIndex = 1;
            this.tbcDatosContacto.Text = "Datos de Contacto";
            this.tbcDatosContacto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSubsidiado);
            this.groupBox2.Controls.Add(this.rdbContributivo);
            this.groupBox2.Controls.Add(this.cboEps);
            this.groupBox2.Controls.Add(this.lblRegimen);
            this.groupBox2.Controls.Add(this.lblEps);
            this.groupBox2.Location = new System.Drawing.Point(20, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // rdbSubsidiado
            // 
            this.rdbSubsidiado.AutoSize = true;
            this.rdbSubsidiado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbSubsidiado.Location = new System.Drawing.Point(289, 80);
            this.rdbSubsidiado.Name = "rdbSubsidiado";
            this.rdbSubsidiado.Size = new System.Drawing.Size(104, 20);
            this.rdbSubsidiado.TabIndex = 4;
            this.rdbSubsidiado.TabStop = true;
            this.rdbSubsidiado.Text = "Subsidiado";
            this.tlpDatosPaciente.SetToolTip(this.rdbSubsidiado, "Subsidiado");
            this.rdbSubsidiado.UseVisualStyleBackColor = true;
            // 
            // rdbContributivo
            // 
            this.rdbContributivo.AutoSize = true;
            this.rdbContributivo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbContributivo.Location = new System.Drawing.Point(110, 80);
            this.rdbContributivo.Name = "rdbContributivo";
            this.rdbContributivo.Size = new System.Drawing.Size(114, 20);
            this.rdbContributivo.TabIndex = 3;
            this.rdbContributivo.TabStop = true;
            this.rdbContributivo.Text = "Contributivo";
            this.tlpDatosPaciente.SetToolTip(this.rdbContributivo, "Contributivo");
            this.rdbContributivo.UseVisualStyleBackColor = true;
            // 
            // cboEps
            // 
            this.cboEps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEps.FormattingEnabled = true;
            this.cboEps.Location = new System.Drawing.Point(110, 30);
            this.cboEps.Name = "cboEps";
            this.cboEps.Size = new System.Drawing.Size(313, 23);
            this.cboEps.TabIndex = 2;
            this.tlpDatosPaciente.SetToolTip(this.cboEps, "Seleccione una EPS");
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegimen.Location = new System.Drawing.Point(23, 80);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(68, 16);
            this.lblRegimen.TabIndex = 1;
            this.lblRegimen.Text = "Régimen";
            // 
            // lblEps
            // 
            this.lblEps.AutoSize = true;
            this.lblEps.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEps.Location = new System.Drawing.Point(23, 32);
            this.lblEps.Name = "lblEps";
            this.lblEps.Size = new System.Drawing.Size(34, 16);
            this.lblEps.TabIndex = 0;
            this.lblEps.Text = "EPS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNEscolaridad);
            this.groupBox1.Controls.Add(this.txtCEmergencia);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.cboOcupacion);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.cboCiudadResidencia);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblNEscolaridad);
            this.groupBox1.Controls.Add(this.lblOcupacion);
            this.groupBox1.Controls.Add(this.lblCEmergencia);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblCiudadResidencia);
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboNEscolaridad
            // 
            this.cboNEscolaridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNEscolaridad.FormattingEnabled = true;
            this.cboNEscolaridad.Location = new System.Drawing.Point(526, 127);
            this.cboNEscolaridad.Name = "cboNEscolaridad";
            this.cboNEscolaridad.Size = new System.Drawing.Size(169, 23);
            this.cboNEscolaridad.TabIndex = 13;
            this.tlpDatosPaciente.SetToolTip(this.cboNEscolaridad, "Seleccione su nivel de escolaridad");
            // 
            // txtCEmergencia
            // 
            this.txtCEmergencia.Location = new System.Drawing.Point(595, 81);
            this.txtCEmergencia.Name = "txtCEmergencia";
            this.txtCEmergencia.Size = new System.Drawing.Size(113, 23);
            this.txtCEmergencia.TabIndex = 12;
            this.tlpDatosPaciente.SetToolTip(this.txtCEmergencia, "Ingrese el contacto de emergencia");
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(487, 29);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(221, 23);
            this.txtDireccion.TabIndex = 11;
            this.tlpDatosPaciente.SetToolTip(this.txtDireccion, "Ingrese su dirección");
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(185, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 23);
            this.txtEmail.TabIndex = 10;
            this.tlpDatosPaciente.SetToolTip(this.txtEmail, "Ingrese su email");
            // 
            // cboOcupacion
            // 
            this.cboOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOcupacion.FormattingEnabled = true;
            this.cboOcupacion.Location = new System.Drawing.Point(185, 127);
            this.cboOcupacion.Name = "cboOcupacion";
            this.cboOcupacion.Size = new System.Drawing.Size(187, 23);
            this.cboOcupacion.TabIndex = 9;
            this.tlpDatosPaciente.SetToolTip(this.cboOcupacion, "Seleccione su ocupación");
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(185, 75);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(187, 23);
            this.txtTelefono.TabIndex = 8;
            this.tlpDatosPaciente.SetToolTip(this.txtTelefono, "Ingrese su número de teléfono");
            // 
            // cboCiudadResidencia
            // 
            this.cboCiudadResidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudadResidencia.FormattingEnabled = true;
            this.cboCiudadResidencia.Location = new System.Drawing.Point(185, 29);
            this.cboCiudadResidencia.Name = "cboCiudadResidencia";
            this.cboCiudadResidencia.Size = new System.Drawing.Size(187, 23);
            this.cboCiudadResidencia.TabIndex = 7;
            this.tlpDatosPaciente.SetToolTip(this.cboCiudadResidencia, "Seleccione una ciudad");
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(23, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblNEscolaridad
            // 
            this.lblNEscolaridad.AutoSize = true;
            this.lblNEscolaridad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNEscolaridad.Location = new System.Drawing.Point(390, 127);
            this.lblNEscolaridad.Name = "lblNEscolaridad";
            this.lblNEscolaridad.Size = new System.Drawing.Size(130, 16);
            this.lblNEscolaridad.TabIndex = 5;
            this.lblNEscolaridad.Text = "Nivel Escolaridad";
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOcupacion.Location = new System.Drawing.Point(23, 127);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(81, 16);
            this.lblOcupacion.TabIndex = 4;
            this.lblOcupacion.Text = "Ocupación";
            // 
            // lblCEmergencia
            // 
            this.lblCEmergencia.AutoSize = true;
            this.lblCEmergencia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCEmergencia.Location = new System.Drawing.Point(390, 77);
            this.lblCEmergencia.Name = "lblCEmergencia";
            this.lblCEmergencia.Size = new System.Drawing.Size(183, 16);
            this.lblCEmergencia.TabIndex = 3;
            this.lblCEmergencia.Text = "Contacto de Emergencia";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(23, 77);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 16);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(390, 31);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 16);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblCiudadResidencia
            // 
            this.lblCiudadResidencia.AutoSize = true;
            this.lblCiudadResidencia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCiudadResidencia.Location = new System.Drawing.Point(17, 31);
            this.lblCiudadResidencia.Name = "lblCiudadResidencia";
            this.lblCiudadResidencia.Size = new System.Drawing.Size(162, 16);
            this.lblCiudadResidencia.TabIndex = 0;
            this.lblCiudadResidencia.Text = "Ciudad de Residencia";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(0, 517);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(800, 48);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnContinuar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnContinuar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.Location = new System.Drawing.Point(0, 470);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(800, 47);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // erpDatos
            // 
            this.erpDatos.ContainerControl = this;
            // 
            // DatosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.DatosContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosPaciente";
            this.Text = "DatosPaciente";
            this.DatosContacto.ResumeLayout(false);
            this.tbcDatosPrincipales.ResumeLayout(false);
            this.tbcDatosPrincipales.PerformLayout();
            this.tbcDatosContacto.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl DatosContacto;
        private TabPage tbcDatosPrincipales;
        private Label lblGenero;
        private Label lblEstado;
        private Label lblNacimiento;
        private Label lblNIdentificacion;
        private Label lblTipoIdentificacion;
        private Label lblApellidos;
        private Label lblNombres;
        private TabPage tbcDatosContacto;
        private RadioButton rdbNoBinario;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private DateTimePicker dtpNacimiento;
        private TextBox txtNIdentificacion;
        private ComboBox cboEstadoCivil;
        private ComboBox cboTidentificacion;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private GroupBox groupBox2;
        private RadioButton rdbSubsidiado;
        private RadioButton rdbContributivo;
        private ComboBox cboEps;
        private Label lblRegimen;
        private Label lblEps;
        private GroupBox groupBox1;
        private ComboBox cboNEscolaridad;
        private TextBox txtCEmergencia;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private ComboBox cboOcupacion;
        private TextBox txtTelefono;
        private ComboBox cboCiudadResidencia;
        private Label lblEmail;
        private Label lblNEscolaridad;
        private Label lblOcupacion;
        private Label lblCEmergencia;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblCiudadResidencia;
        private Button btnCancelar;
        private Button btnContinuar;
        private ErrorProvider erpDatos;
        private ToolTip tlpDatosPaciente;
    }
}