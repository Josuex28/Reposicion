﻿
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Tareaaaaaaaaa222
{
        public partial class materias : Form
        {
            Conexion objConexion = new Conexion();
            DataSet miDs = new DataSet();
            DataTable miTabla = new DataTable();

            

            private int posicion = 0;
            String accion = "nuevo";
            public materias()
            {
                InitializeComponent();
            }
        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDsMaterias();
            cboOpcionBuscarMaterias.SelectedIndex = 1;
        }

        private void actualizarDsMaterias()
            {
                miDs.Clear();
                miDs = objConexion.obtenerDatos();
                miTabla = miDs.Tables["materias"];
                miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idMateria"] };
                mostrarMaterias();
                mostrarDatosMateria();
            }
            private void mostrarMaterias()
            {

                grdDatosMaterias.DataSource = miTabla.DefaultView;
            }
            private void filtrarMaterias(String valor, int opcion)
            {
                try
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = grdDatosMaterias.DataSource;
                    bs.Filter = opcion == 0 ? "codigo=" + valor : "materia like '%" + valor + "%'";
                    grdDatosMaterias.DataSource = bs;
                    erpMaterias.SetError(txtBuscarMaterias, "");
                }
                catch (Exception e)
                {
                    erpMaterias.SetError(txtBuscarMaterias, "Por favor ingrese un codigo o materia a buscr");
                }
            }
            private void mostrarDatosMateria()
            {
                if (miTabla.Rows.Count > 0)
                {
                    txtCodigoMateria.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                    txtNombreMateria.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                    txtUvMateria.Text = miTabla.Rows[posicion].ItemArray[3].ToString();

                    lblnRegistroMateria.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
                }
                else
                {
                    limpiarCajas();
                }
            }

        private void btnSiguienteMateria_Click_1(object sender, EventArgs e)
        {
                if (posicion < miTabla.Rows.Count - 1)
                {
                    posicion++;
                    mostrarDatosMateria();
                }
                else
                {
                    MessageBox.Show("Ultimo Registro", "Registro de Materias");
                }
            }

        private void btnUltimoMateria_Click_1(object sender, EventArgs e)
        {
                posicion = miTabla.Rows.Count - 1;
                mostrarDatosMateria();
            }

        private void btnAnteriorMateria_Click_1(object sender, EventArgs e)
        {
                if (posicion > 0)
                {
                    posicion--;
                    mostrarDatosMateria();
                }
                else
                {
                    MessageBox.Show("Primer regisro", "Registro de Materias");
                }
            }

        private void btnPrimeroMateria_Click_1(object sender, EventArgs e)
        {
                posicion = 0;
                mostrarDatosMateria();
            }

        private void btnNuevoMateria_Click_1(object sender, EventArgs e)
        {
                if (btnNuevoMateria.Text == "Nuevo")
                {
                    btnNuevoMateria.Text = "Guardar";
                    btnModificarMateria.Text = "Cancelar";
                    estadoControles(false);
                    limpiarCajas();
                    accion = "nuevo";
                }
                else
                {
                    String[] materias = new string[] {
                    accion,txtCodigoMateria.Text, txtNombreMateria.Text, txtUvMateria.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                    String msg = objConexion.mantenimientoMaterias(materias);
                    if (msg != "1")
                    {
                        MessageBox.Show("Error en el registro de materias: " + msg, "Registro de Materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        actualizarDsMaterias();
                        estadoControles(true);
                        btnNuevoMateria.Text = "Nuevo";
                        btnModificarMateria.Text = "Modificar";
                    }
                }
            }

        private void btnModificarMateria_Click_1(object sender, EventArgs e)
        {
                if (btnModificarMateria.Text == "Modificar")
                {
                    btnNuevoMateria.Text = "Guardar";
                    btnModificarMateria.Text = "Cancelar";
                    estadoControles(false);
                    accion = "modificar";
                }
                else
                {

                    estadoControles(true);
                    mostrarDatosMateria();
                    btnNuevoMateria.Text = "Nuevo";
                    btnModificarMateria.Text = "Modificar";
                }
            }
            private void estadoControles(Boolean estado)
            {
                txtCodigoMateria.ReadOnly = estado;
                txtNombreMateria.ReadOnly = estado;
                txtUvMateria.ReadOnly = estado;

                grbNavegacionMateria.Enabled = estado;
                btnEliminarMateria.Enabled = estado;
                txtBuscarMaterias.ReadOnly = !estado;
            }
            private void limpiarCajas()
            {
                txtCodigoMateria.Text = "";
                txtNombreMateria.Text = "";
                txtUvMateria.Text = "";
            }

        
        private void seleccionarMateria()
            {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosMaterias.CurrentRow.Cells["idMateria"].Value.ToString()));
            mostrarDatosMateria();
            }

        private void grdDatosMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                seleccionarMateria();
            }

        private void btnEliminarMateria_Click_1(object sender, EventArgs e)
        {
                if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreMateria.Text, "Eliminado Materias",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String[] materias = new string[] {
                    "eliminar",txtCodigoMateria.Text, txtNombreMateria.Text, txtUvMateria.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                    String msg = objConexion.mantenimientoMaterias(materias);
                    if (msg != "1")
                    {
                        MessageBox.Show("Error en la eliminacion de materias: " + msg, "Registro de Materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        posicion = 0;
                        actualizarDsMaterias();
                    }
                }
            }

        

        private void materias_Load(object sender, EventArgs e)
        {
            actualizarDsMaterias();
            cboOpcionBuscarMaterias.SelectedIndex = 1;

        }

       

        private void cboOpcionBuscarMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtBuscarMaterias_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarMaterias(txtBuscarMaterias.Text, cboOpcionBuscarMaterias.SelectedIndex);
            if (e.KeyCode == Keys.Enter)
            {
                seleccionarMateria();
                e.SuppressKeyPress = true;
            }
        }

        private void txtBuscarMaterias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}