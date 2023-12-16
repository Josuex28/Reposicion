namespace Tareaaaaaaaaa222
{
    partial class materias
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
            this.cboOpcionBuscarMaterias = new System.Windows.Forms.ComboBox();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.lblBuscarMaterias = new System.Windows.Forms.Label();
            this.grbEdicionMateria = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnNuevoMateria = new System.Windows.Forms.Button();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblnRegistroMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.txtUvMateria = new System.Windows.Forms.TextBox();
            this.lblUvMateria = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.erpMaterias = new System.Windows.Forms.ErrorProvider(this.components);
            this.grdDatosMaterias = new System.Windows.Forms.DataGridView();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Tareaaaaaaaaa222.Database1DataSet();
            this.materiasTableAdapter = new Tareaaaaaaaaa222.Database1DataSetTableAdapters.materiasTableAdapter();
            this.tableAdapterManager = new Tareaaaaaaaaa222.Database1DataSetTableAdapters.TableAdapterManager();
            this.idMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionMateria.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbDatosMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOpcionBuscarMaterias
            // 
            this.cboOpcionBuscarMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarMaterias.FormattingEnabled = true;
            this.cboOpcionBuscarMaterias.Items.AddRange(new object[] {
            "Codigo",
            "Materia"});
            this.cboOpcionBuscarMaterias.Location = new System.Drawing.Point(614, 12);
            this.cboOpcionBuscarMaterias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboOpcionBuscarMaterias.Name = "cboOpcionBuscarMaterias";
            this.cboOpcionBuscarMaterias.Size = new System.Drawing.Size(147, 21);
            this.cboOpcionBuscarMaterias.TabIndex = 15;
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(762, 12);
            this.txtBuscarMaterias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.ReadOnly = true;
            this.txtBuscarMaterias.Size = new System.Drawing.Size(199, 20);
            this.txtBuscarMaterias.TabIndex = 14;
            this.txtBuscarMaterias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMaterias_KeyUp);
            // 
            // lblBuscarMaterias
            // 
            this.lblBuscarMaterias.AutoSize = true;
            this.lblBuscarMaterias.Location = new System.Drawing.Point(544, 15);
            this.lblBuscarMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarMaterias.Name = "lblBuscarMaterias";
            this.lblBuscarMaterias.Size = new System.Drawing.Size(61, 13);
            this.lblBuscarMaterias.TabIndex = 13;
            this.lblBuscarMaterias.Text = "BUSCAR:";
            // 
            // grbEdicionMateria
            // 
            this.grbEdicionMateria.Controls.Add(this.btnEliminarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnNuevoMateria);
            this.grbEdicionMateria.Location = new System.Drawing.Point(762, 313);
            this.grbEdicionMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbEdicionMateria.Name = "grbEdicionMateria";
            this.grbEdicionMateria.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbEdicionMateria.Size = new System.Drawing.Size(296, 71);
            this.grbEdicionMateria.TabIndex = 11;
            this.grbEdicionMateria.TabStop = false;
            this.grbEdicionMateria.Text = "Edicion";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarMateria.Location = new System.Drawing.Point(195, 28);
            this.btnEliminarMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(84, 29);
            this.btnEliminarMateria.TabIndex = 9;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click_1);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(95, 27);
            this.btnModificarMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(81, 29);
            this.btnModificarMateria.TabIndex = 8;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click_1);
            // 
            // btnNuevoMateria
            // 
            this.btnNuevoMateria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMateria.Location = new System.Drawing.Point(8, 27);
            this.btnNuevoMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevoMateria.Name = "btnNuevoMateria";
            this.btnNuevoMateria.Size = new System.Drawing.Size(69, 28);
            this.btnNuevoMateria.TabIndex = 7;
            this.btnNuevoMateria.Text = "Nuevo";
            this.btnNuevoMateria.UseVisualStyleBackColor = true;
            this.btnNuevoMateria.Click += new System.EventHandler(this.btnNuevoMateria_Click_1);
            // 
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.Controls.Add(this.lblnRegistroMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionMateria.Location = new System.Drawing.Point(544, 313);
            this.grbNavegacionMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbNavegacionMateria.Size = new System.Drawing.Size(207, 71);
            this.grbNavegacionMateria.TabIndex = 10;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Navegacion";
            // 
            // lblnRegistroMateria
            // 
            this.lblnRegistroMateria.AutoSize = true;
            this.lblnRegistroMateria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnRegistroMateria.ForeColor = System.Drawing.Color.Black;
            this.lblnRegistroMateria.Location = new System.Drawing.Point(90, 34);
            this.lblnRegistroMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnRegistroMateria.Name = "lblnRegistroMateria";
            this.lblnRegistroMateria.Size = new System.Drawing.Size(39, 15);
            this.lblnRegistroMateria.TabIndex = 6;
            this.lblnRegistroMateria.Text = "x de n";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.ForeColor = System.Drawing.Color.Black;
            this.btnUltimoMateria.Location = new System.Drawing.Point(174, 27);
            this.btnUltimoMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(31, 28);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = ">|";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click_1);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.ForeColor = System.Drawing.Color.Black;
            this.btnSiguienteMateria.Location = new System.Drawing.Point(144, 27);
            this.btnSiguienteMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(22, 28);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click_1);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.ForeColor = System.Drawing.Color.Black;
            this.btnAnteriorMateria.Location = new System.Drawing.Point(47, 27);
            this.btnAnteriorMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(22, 28);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click_1);
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMateria.ForeColor = System.Drawing.Color.Black;
            this.btnPrimeroMateria.Location = new System.Drawing.Point(11, 27);
            this.btnPrimeroMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(28, 28);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "|<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            this.btnPrimeroMateria.Click += new System.EventHandler(this.btnPrimeroMateria_Click_1);
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.txtUvMateria);
            this.grbDatosMateria.Controls.Add(this.lblUvMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombreMateria);
            this.grbDatosMateria.Controls.Add(this.lblNombreMateria);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMateria.Location = new System.Drawing.Point(10, 92);
            this.grbDatosMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbDatosMateria.Size = new System.Drawing.Size(446, 185);
            this.grbDatosMateria.TabIndex = 9;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "Datos Materia";
            // 
            // txtUvMateria
            // 
            this.txtUvMateria.Location = new System.Drawing.Point(103, 123);
            this.txtUvMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUvMateria.Name = "txtUvMateria";
            this.txtUvMateria.ReadOnly = true;
            this.txtUvMateria.Size = new System.Drawing.Size(73, 20);
            this.txtUvMateria.TabIndex = 5;
            // 
            // lblUvMateria
            // 
            this.lblUvMateria.AutoSize = true;
            this.lblUvMateria.ForeColor = System.Drawing.Color.White;
            this.lblUvMateria.Location = new System.Drawing.Point(66, 130);
            this.lblUvMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUvMateria.Name = "lblUvMateria";
            this.lblUvMateria.Size = new System.Drawing.Size(28, 13);
            this.lblUvMateria.TabIndex = 4;
            this.lblUvMateria.Text = "UV:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(103, 77);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.ReadOnly = true;
            this.txtNombreMateria.Size = new System.Drawing.Size(312, 20);
            this.txtNombreMateria.TabIndex = 3;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.ForeColor = System.Drawing.Color.White;
            this.lblNombreMateria.Location = new System.Drawing.Point(28, 84);
            this.lblNombreMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(66, 13);
            this.lblNombreMateria.TabIndex = 2;
            this.lblNombreMateria.Text = "MATERIA:";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(103, 33);
            this.txtCodigoMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.ReadOnly = true;
            this.txtCodigoMateria.Size = new System.Drawing.Size(165, 20);
            this.txtCodigoMateria.TabIndex = 1;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.ForeColor = System.Drawing.Color.White;
            this.lblCodigoMateria.Location = new System.Drawing.Point(35, 40);
            this.lblCodigoMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(59, 13);
            this.lblCodigoMateria.TabIndex = 0;
            this.lblCodigoMateria.Text = "CODIGO:";
            // 
            // erpMaterias
            // 
            this.erpMaterias.ContainerControl = this;
            // 
            // grdDatosMaterias
            // 
            this.grdDatosMaterias.AllowUserToAddRows = false;
            this.grdDatosMaterias.AllowUserToDeleteRows = false;
            this.grdDatosMaterias.AutoGenerateColumns = false;
            this.grdDatosMaterias.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdDatosMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateriaDataGridViewTextBoxColumn,
            this.codigo,
            this.materia,
            this.uv});
            this.grdDatosMaterias.DataSource = this.materiasBindingSource;
            this.grdDatosMaterias.Location = new System.Drawing.Point(544, 38);
            this.grdDatosMaterias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdDatosMaterias.Name = "grdDatosMaterias";
            this.grdDatosMaterias.ReadOnly = true;
            this.grdDatosMaterias.Size = new System.Drawing.Size(514, 259);
            this.grdDatosMaterias.TabIndex = 16;
            this.grdDatosMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosMaterias_CellContentClick);
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.materiasTableAdapter = this.materiasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Tareaaaaaaaaa222.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vehiculosTableAdapter = null;
            // 
            // idMateriaDataGridViewTextBoxColumn
            // 
            this.idMateriaDataGridViewTextBoxColumn.DataPropertyName = "idMateria";
            this.idMateriaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idMateriaDataGridViewTextBoxColumn.Name = "idMateriaDataGridViewTextBoxColumn";
            this.idMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMateriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // materia
            // 
            this.materia.DataPropertyName = "materia";
            this.materia.HeaderText = "materia";
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "uv";
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            // 
            // materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1161, 417);
            this.Controls.Add(this.grdDatosMaterias);
            this.Controls.Add(this.cboOpcionBuscarMaterias);
            this.Controls.Add(this.txtBuscarMaterias);
            this.Controls.Add(this.lblBuscarMaterias);
            this.Controls.Add(this.grbEdicionMateria);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMateria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "materias";
            this.Text = "Parquimetro";
            this.Load += new System.EventHandler(this.materias_Load);
            this.grbEdicionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOpcionBuscarMaterias;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.Label lblBuscarMaterias;
        private System.Windows.Forms.GroupBox grbEdicionMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnNuevoMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.Label lblnRegistroMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.TextBox txtUvMateria;
        private System.Windows.Forms.Label lblUvMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.ErrorProvider erpMaterias;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView grdDatosMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
    }
}