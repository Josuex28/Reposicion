namespace Tareaaaaaaaaa222
{
    partial class vehiculos
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
            this.grdGestionCarro = new System.Windows.Forms.DataGridView();
            this.idVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_chasis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Tareaaaaaaaaa222.Database1DataSet();
            this.txtBuscarCarro = new System.Windows.Forms.TextBox();
            this.lblBuscarCarro = new System.Windows.Forms.Label();
            this.cboOpcionBuscarCarro = new System.Windows.Forms.ComboBox();
            this.grbEdicionCarro = new System.Windows.Forms.GroupBox();
            this.btnEliminarCarro = new System.Windows.Forms.Button();
            this.btnModificarCarro = new System.Windows.Forms.Button();
            this.btnNuevoCarro = new System.Windows.Forms.Button();
            this.grbNavegacionCarro = new System.Windows.Forms.GroupBox();
            this.btnSiguienteCarro = new System.Windows.Forms.Button();
            this.lblRegistroCarro = new System.Windows.Forms.Label();
            this.btnUltimoCarro = new System.Windows.Forms.Button();
            this.btnAnteriorCarro = new System.Windows.Forms.Button();
            this.btnPrimeroCarro = new System.Windows.Forms.Button();
            this.grbDatosGestionCarro = new System.Windows.Forms.GroupBox();
            this.txtNumeroCarro = new System.Windows.Forms.TextBox();
            this.lblNumeroCarro = new System.Windows.Forms.Label();
            this.txtTelefonoCarro = new System.Windows.Forms.TextBox();
            this.txtDireccionCarro = new System.Windows.Forms.TextBox();
            this.txtNombreCarro = new System.Windows.Forms.TextBox();
            this.txtCodigoCarro = new System.Windows.Forms.TextBox();
            this.lblCodigoCarro = new System.Windows.Forms.Label();
            this.lblTelefonoCarro = new System.Windows.Forms.Label();
            this.lblNombreCarro = new System.Windows.Forms.Label();
            this.lblDireccionCarro = new System.Windows.Forms.Label();
            this.vehiculosTableAdapter = new Tareaaaaaaaaa222.Database1DataSetTableAdapters.vehiculosTableAdapter();
            this.erpCarro = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdGestionCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.grbEdicionCarro.SuspendLayout();
            this.grbNavegacionCarro.SuspendLayout();
            this.grbDatosGestionCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // grdGestionCarro
            // 
            this.grdGestionCarro.AllowUserToAddRows = false;
            this.grdGestionCarro.AllowUserToDeleteRows = false;
            this.grdGestionCarro.AutoGenerateColumns = false;
            this.grdGestionCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGestionCarro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculo,
            this.marca,
            this.modelo,
            this.year,
            this.num_motor,
            this.num_chasis});
            this.grdGestionCarro.DataSource = this.vehiculosBindingSource;
            this.grdGestionCarro.Location = new System.Drawing.Point(305, 87);
            this.grdGestionCarro.Name = "grdGestionCarro";
            this.grdGestionCarro.ReadOnly = true;
            this.grdGestionCarro.Size = new System.Drawing.Size(626, 220);
            this.grdGestionCarro.TabIndex = 49;
            // 
            // idVehiculo
            // 
            this.idVehiculo.DataPropertyName = "idVehiculo";
            this.idVehiculo.HeaderText = "ID";
            this.idVehiculo.Name = "idVehiculo";
            this.idVehiculo.ReadOnly = true;
            this.idVehiculo.Visible = false;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Año";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // num_motor
            // 
            this.num_motor.DataPropertyName = "num_motor";
            this.num_motor.HeaderText = "Numero motor";
            this.num_motor.Name = "num_motor";
            this.num_motor.ReadOnly = true;
            // 
            // num_chasis
            // 
            this.num_chasis.DataPropertyName = "num_chasis";
            this.num_chasis.HeaderText = "Numero Chasis";
            this.num_chasis.Name = "num_chasis";
            this.num_chasis.ReadOnly = true;
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "vehiculos";
            this.vehiculosBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBuscarCarro
            // 
            this.txtBuscarCarro.Location = new System.Drawing.Point(501, 61);
            this.txtBuscarCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBuscarCarro.Name = "txtBuscarCarro";
            this.txtBuscarCarro.Size = new System.Drawing.Size(173, 20);
            this.txtBuscarCarro.TabIndex = 50;
            // 
            // lblBuscarCarro
            // 
            this.lblBuscarCarro.AutoSize = true;
            this.lblBuscarCarro.Location = new System.Drawing.Point(311, 65);
            this.lblBuscarCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarCarro.Name = "lblBuscarCarro";
            this.lblBuscarCarro.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarCarro.TabIndex = 48;
            this.lblBuscarCarro.Text = "Buscar:";
            // 
            // cboOpcionBuscarCarro
            // 
            this.cboOpcionBuscarCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarCarro.FormattingEnabled = true;
            this.cboOpcionBuscarCarro.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Año",
            "Numero Motor",
            "Numero Chasis  "});
            this.cboOpcionBuscarCarro.Location = new System.Drawing.Point(361, 60);
            this.cboOpcionBuscarCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboOpcionBuscarCarro.Name = "cboOpcionBuscarCarro";
            this.cboOpcionBuscarCarro.Size = new System.Drawing.Size(136, 21);
            this.cboOpcionBuscarCarro.TabIndex = 47;
            // 
            // grbEdicionCarro
            // 
            this.grbEdicionCarro.Controls.Add(this.btnEliminarCarro);
            this.grbEdicionCarro.Controls.Add(this.btnModificarCarro);
            this.grbEdicionCarro.Controls.Add(this.btnNuevoCarro);
            this.grbEdicionCarro.Location = new System.Drawing.Point(526, 309);
            this.grbEdicionCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbEdicionCarro.Name = "grbEdicionCarro";
            this.grbEdicionCarro.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbEdicionCarro.Size = new System.Drawing.Size(251, 91);
            this.grbEdicionCarro.TabIndex = 46;
            this.grbEdicionCarro.TabStop = false;
            this.grbEdicionCarro.Text = "Edicion";
            // 
            // btnEliminarCarro
            // 
            this.btnEliminarCarro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCarro.ForeColor = System.Drawing.Color.LightCoral;
            this.btnEliminarCarro.Location = new System.Drawing.Point(163, 39);
            this.btnEliminarCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarCarro.Name = "btnEliminarCarro";
            this.btnEliminarCarro.Size = new System.Drawing.Size(72, 31);
            this.btnEliminarCarro.TabIndex = 9;
            this.btnEliminarCarro.Text = "Eliminar";
            this.btnEliminarCarro.UseVisualStyleBackColor = true;
            // 
            // btnModificarCarro
            // 
            this.btnModificarCarro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCarro.Location = new System.Drawing.Point(79, 39);
            this.btnModificarCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModificarCarro.Name = "btnModificarCarro";
            this.btnModificarCarro.Size = new System.Drawing.Size(80, 31);
            this.btnModificarCarro.TabIndex = 8;
            this.btnModificarCarro.Text = "Modificar";
            this.btnModificarCarro.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCarro
            // 
            this.btnNuevoCarro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCarro.Location = new System.Drawing.Point(5, 39);
            this.btnNuevoCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevoCarro.Name = "btnNuevoCarro";
            this.btnNuevoCarro.Size = new System.Drawing.Size(61, 31);
            this.btnNuevoCarro.TabIndex = 7;
            this.btnNuevoCarro.Text = "Nuevo";
            this.btnNuevoCarro.UseVisualStyleBackColor = true;
            this.btnNuevoCarro.Click += new System.EventHandler(this.btnNuevoCarro_Click);
            // 
            // grbNavegacionCarro
            // 
            this.grbNavegacionCarro.Controls.Add(this.btnSiguienteCarro);
            this.grbNavegacionCarro.Controls.Add(this.lblRegistroCarro);
            this.grbNavegacionCarro.Controls.Add(this.btnUltimoCarro);
            this.grbNavegacionCarro.Controls.Add(this.btnAnteriorCarro);
            this.grbNavegacionCarro.Controls.Add(this.btnPrimeroCarro);
            this.grbNavegacionCarro.Location = new System.Drawing.Point(321, 309);
            this.grbNavegacionCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbNavegacionCarro.Name = "grbNavegacionCarro";
            this.grbNavegacionCarro.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbNavegacionCarro.Size = new System.Drawing.Size(188, 91);
            this.grbNavegacionCarro.TabIndex = 45;
            this.grbNavegacionCarro.TabStop = false;
            this.grbNavegacionCarro.Text = "Navegacion";
            // 
            // btnSiguienteCarro
            // 
            this.btnSiguienteCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteCarro.Location = new System.Drawing.Point(118, 39);
            this.btnSiguienteCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSiguienteCarro.Name = "btnSiguienteCarro";
            this.btnSiguienteCarro.Size = new System.Drawing.Size(21, 31);
            this.btnSiguienteCarro.TabIndex = 21;
            this.btnSiguienteCarro.Text = ">";
            this.btnSiguienteCarro.UseVisualStyleBackColor = true;
            this.btnSiguienteCarro.Click += new System.EventHandler(this.btnSiguienteCarro_Click);
            // 
            // lblRegistroCarro
            // 
            this.lblRegistroCarro.AutoSize = true;
            this.lblRegistroCarro.Location = new System.Drawing.Point(82, 47);
            this.lblRegistroCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistroCarro.Name = "lblRegistroCarro";
            this.lblRegistroCarro.Size = new System.Drawing.Size(36, 13);
            this.lblRegistroCarro.TabIndex = 18;
            this.lblRegistroCarro.Text = "x de n";
            // 
            // btnUltimoCarro
            // 
            this.btnUltimoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoCarro.Location = new System.Drawing.Point(144, 39);
            this.btnUltimoCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUltimoCarro.Name = "btnUltimoCarro";
            this.btnUltimoCarro.Size = new System.Drawing.Size(31, 31);
            this.btnUltimoCarro.TabIndex = 3;
            this.btnUltimoCarro.Text = ">|";
            this.btnUltimoCarro.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorCarro
            // 
            this.btnAnteriorCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorCarro.Location = new System.Drawing.Point(54, 39);
            this.btnAnteriorCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnteriorCarro.Name = "btnAnteriorCarro";
            this.btnAnteriorCarro.Size = new System.Drawing.Size(24, 31);
            this.btnAnteriorCarro.TabIndex = 1;
            this.btnAnteriorCarro.Text = "<";
            this.btnAnteriorCarro.UseVisualStyleBackColor = true;
            this.btnAnteriorCarro.Click += new System.EventHandler(this.btnAnteriorCarro_Click);
            // 
            // btnPrimeroCarro
            // 
            this.btnPrimeroCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroCarro.Location = new System.Drawing.Point(12, 39);
            this.btnPrimeroCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrimeroCarro.Name = "btnPrimeroCarro";
            this.btnPrimeroCarro.Size = new System.Drawing.Size(37, 31);
            this.btnPrimeroCarro.TabIndex = 0;
            this.btnPrimeroCarro.Text = "|<";
            this.btnPrimeroCarro.UseVisualStyleBackColor = true;
            this.btnPrimeroCarro.Click += new System.EventHandler(this.btnPrimerCarro_Click_1);
            // 
            // grbDatosGestionCarro
            // 
            this.grbDatosGestionCarro.Controls.Add(this.txtNumeroCarro);
            this.grbDatosGestionCarro.Controls.Add(this.lblNumeroCarro);
            this.grbDatosGestionCarro.Controls.Add(this.txtTelefonoCarro);
            this.grbDatosGestionCarro.Controls.Add(this.txtDireccionCarro);
            this.grbDatosGestionCarro.Controls.Add(this.txtNombreCarro);
            this.grbDatosGestionCarro.Controls.Add(this.txtCodigoCarro);
            this.grbDatosGestionCarro.Controls.Add(this.lblCodigoCarro);
            this.grbDatosGestionCarro.Controls.Add(this.lblTelefonoCarro);
            this.grbDatosGestionCarro.Controls.Add(this.lblNombreCarro);
            this.grbDatosGestionCarro.Controls.Add(this.lblDireccionCarro);
            this.grbDatosGestionCarro.Location = new System.Drawing.Point(11, 65);
            this.grbDatosGestionCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbDatosGestionCarro.Name = "grbDatosGestionCarro";
            this.grbDatosGestionCarro.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbDatosGestionCarro.Size = new System.Drawing.Size(289, 261);
            this.grbDatosGestionCarro.TabIndex = 44;
            this.grbDatosGestionCarro.TabStop = false;
            this.grbDatosGestionCarro.Text = "Ingreso de Datos ";
            // 
            // txtNumeroCarro
            // 
            this.txtNumeroCarro.Location = new System.Drawing.Point(109, 205);
            this.txtNumeroCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumeroCarro.Name = "txtNumeroCarro";
            this.txtNumeroCarro.ReadOnly = true;
            this.txtNumeroCarro.Size = new System.Drawing.Size(103, 20);
            this.txtNumeroCarro.TabIndex = 37;
            // 
            // lblNumeroCarro
            // 
            this.lblNumeroCarro.AutoSize = true;
            this.lblNumeroCarro.Location = new System.Drawing.Point(36, 208);
            this.lblNumeroCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroCarro.Name = "lblNumeroCarro";
            this.lblNumeroCarro.Size = new System.Drawing.Size(77, 13);
            this.lblNumeroCarro.TabIndex = 37;
            this.lblNumeroCarro.Text = "Numero Motor:";
            // 
            // txtTelefonoCarro
            // 
            this.txtTelefonoCarro.Location = new System.Drawing.Point(109, 171);
            this.txtTelefonoCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTelefonoCarro.Name = "txtTelefonoCarro";
            this.txtTelefonoCarro.ReadOnly = true;
            this.txtTelefonoCarro.Size = new System.Drawing.Size(103, 20);
            this.txtTelefonoCarro.TabIndex = 30;
            // 
            // txtDireccionCarro
            // 
            this.txtDireccionCarro.Location = new System.Drawing.Point(109, 132);
            this.txtDireccionCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDireccionCarro.Name = "txtDireccionCarro";
            this.txtDireccionCarro.ReadOnly = true;
            this.txtDireccionCarro.Size = new System.Drawing.Size(103, 20);
            this.txtDireccionCarro.TabIndex = 28;
            // 
            // txtNombreCarro
            // 
            this.txtNombreCarro.Location = new System.Drawing.Point(109, 88);
            this.txtNombreCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreCarro.Name = "txtNombreCarro";
            this.txtNombreCarro.ReadOnly = true;
            this.txtNombreCarro.Size = new System.Drawing.Size(103, 20);
            this.txtNombreCarro.TabIndex = 26;
            // 
            // txtCodigoCarro
            // 
            this.txtCodigoCarro.Location = new System.Drawing.Point(109, 43);
            this.txtCodigoCarro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCodigoCarro.Name = "txtCodigoCarro";
            this.txtCodigoCarro.ReadOnly = true;
            this.txtCodigoCarro.Size = new System.Drawing.Size(103, 20);
            this.txtCodigoCarro.TabIndex = 24;
            // 
            // lblCodigoCarro
            // 
            this.lblCodigoCarro.AutoSize = true;
            this.lblCodigoCarro.Location = new System.Drawing.Point(36, 46);
            this.lblCodigoCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoCarro.Name = "lblCodigoCarro";
            this.lblCodigoCarro.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoCarro.TabIndex = 23;
            this.lblCodigoCarro.Text = "Marca:";
            // 
            // lblTelefonoCarro
            // 
            this.lblTelefonoCarro.AutoSize = true;
            this.lblTelefonoCarro.Location = new System.Drawing.Point(36, 174);
            this.lblTelefonoCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoCarro.Name = "lblTelefonoCarro";
            this.lblTelefonoCarro.Size = new System.Drawing.Size(77, 13);
            this.lblTelefonoCarro.TabIndex = 29;
            this.lblTelefonoCarro.Text = "Numero Motor:";
            // 
            // lblNombreCarro
            // 
            this.lblNombreCarro.AutoSize = true;
            this.lblNombreCarro.Location = new System.Drawing.Point(36, 91);
            this.lblNombreCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCarro.Name = "lblNombreCarro";
            this.lblNombreCarro.Size = new System.Drawing.Size(45, 13);
            this.lblNombreCarro.TabIndex = 25;
            this.lblNombreCarro.Text = "Modelo:";
            // 
            // lblDireccionCarro
            // 
            this.lblDireccionCarro.AutoSize = true;
            this.lblDireccionCarro.Location = new System.Drawing.Point(37, 137);
            this.lblDireccionCarro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccionCarro.Name = "lblDireccionCarro";
            this.lblDireccionCarro.Size = new System.Drawing.Size(29, 13);
            this.lblDireccionCarro.TabIndex = 27;
            this.lblDireccionCarro.Text = "Año:";
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // erpCarro
            // 
            this.erpCarro.ContainerControl = this;
            // 
            // vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 406);
            this.Controls.Add(this.grdGestionCarro);
            this.Controls.Add(this.txtBuscarCarro);
            this.Controls.Add(this.lblBuscarCarro);
            this.Controls.Add(this.cboOpcionBuscarCarro);
            this.Controls.Add(this.grbEdicionCarro);
            this.Controls.Add(this.grbNavegacionCarro);
            this.Controls.Add(this.grbDatosGestionCarro);
            this.Name = "vehiculos";
            this.Text = "vehiculos";
            this.Load += new System.EventHandler(this.vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGestionCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.grbEdicionCarro.ResumeLayout(false);
            this.grbNavegacionCarro.ResumeLayout(false);
            this.grbNavegacionCarro.PerformLayout();
            this.grbDatosGestionCarro.ResumeLayout(false);
            this.grbDatosGestionCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdGestionCarro;
        private System.Windows.Forms.TextBox txtBuscarCarro;
        private System.Windows.Forms.Label lblBuscarCarro;
        private System.Windows.Forms.ComboBox cboOpcionBuscarCarro;
        private System.Windows.Forms.GroupBox grbEdicionCarro;
        private System.Windows.Forms.Button btnEliminarCarro;
        private System.Windows.Forms.Button btnModificarCarro;
        private System.Windows.Forms.Button btnNuevoCarro;
        private System.Windows.Forms.GroupBox grbNavegacionCarro;
        private System.Windows.Forms.Button btnSiguienteCarro;
        private System.Windows.Forms.Label lblRegistroCarro;
        private System.Windows.Forms.Button btnUltimoCarro;
        private System.Windows.Forms.Button btnAnteriorCarro;
        private System.Windows.Forms.Button btnPrimeroCarro;
        private System.Windows.Forms.GroupBox grbDatosGestionCarro;
        private System.Windows.Forms.TextBox txtNumeroCarro;
        private System.Windows.Forms.Label lblNumeroCarro;
        private System.Windows.Forms.TextBox txtTelefonoCarro;
        private System.Windows.Forms.TextBox txtDireccionCarro;
        private System.Windows.Forms.TextBox txtNombreCarro;
        private System.Windows.Forms.TextBox txtCodigoCarro;
        private System.Windows.Forms.Label lblCodigoCarro;
        private System.Windows.Forms.Label lblTelefonoCarro;
        private System.Windows.Forms.Label lblNombreCarro;
        private System.Windows.Forms.Label lblDireccionCarro;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.vehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_motor;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_chasis;
        private System.Windows.Forms.ErrorProvider erpCarro;
    }
}