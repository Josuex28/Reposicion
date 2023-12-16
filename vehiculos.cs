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
    public partial class vehiculos : Form
    {
        public vehiculos()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";

            
            private void actualizarDsCarro()
            {
                miDs.Clear();
                miDs = objConexion.obtenerDatos();
                miTabla = miDs.Tables["vehiculos"];
                miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idVehiculo"] };
                mostrarCarro();
                mostrarDatosCarro();
            }
            private void mostrarCarro()
            {

            grdGestionCarro.DataSource = miTabla.DefaultView;
            }
        private void filtrarCarro(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdGestionCarro.DataSource;
                bs.Filter = opcion == 0 ? "codigo=" + valor : "materia like '%" + valor + "%'"; 
                grdGestionCarro.DataSource = bs;
                erpCarro.SetError(txtBuscarCarros, "");
              
                }
                catch (Exception e)
                {
                erpCarro.SetError(txtBuscarCarros, "Por favor ingrese un parametro a buscar");
                }
            }
            private void mostrarDatosCarro()
            {
                if (miTabla.Rows.Count > 0)
                {
                txtCodigoCarro.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreCarro.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtDireccionCarro.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoCarro.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtNumeroCarro.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblRegistroCarro.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
                }
                else
                {
                    limpiarCajas();
                }
            }

        private void btnSiguienteCarro_Click(object sender, EventArgs e)
        {
                if (posicion < miTabla.Rows.Count - 1)
                {
                    posicion++;
                mostrarDatosCarro();
                }
                else
                {
                    MessageBox.Show("Ultimo Registro", "Registro de Carro");
                }
            }

        private void btnUltimoCarro_Click(object sender, EventArgs e)
        {
                posicion = miTabla.Rows.Count - 1;
            mostrarDatosCarro();
            }

        private void btnAnteriorCarro_Click(object sender, EventArgs e)
        {
                if (posicion > 0)
                {
                    posicion--;
                mostrarDatosCarro();
                }
                else
                {
                    MessageBox.Show("Primer regisro", "Registro de Carro");
                }
        }

            private void btnPrimerCarro_Click_1(object sender, EventArgs e)
            {
                posicion = 0;
            mostrarDatosCarro();
            }

        private void btnNuevoCarro_Click(object sender, EventArgs e)
        {
                if (btnNuevoCarro.Text == "Nuevo")
                {
                btnNuevoCarro.Text = "Guardar";
                btnModificarCarro.Text = "Cancelar";
                    estadoControles(false);
                    limpiarCajas();
                    accion = "nuevo";
                }
                else
                {
                    String[] vehiculos = new string[] {
                    accion,txtCodigoCarro.Text, txtNombreCarro.Text, txtDireccionCarro.Text, txtTelefonoCarro.Text,txtNumeroCarro.Text, 
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                    String msg = objConexion.mantenimientoCarro(vehiculos);
                    if (msg != "1")
                    {
                        MessageBox.Show("Error en el registro de Carro: " + msg, "Registro de Carro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        actualizarDsCarro();
                        estadoControles(true);
                    btnNuevoCarro.Text = "Nuevo";
                    btnModificarCarro.Text = "Modificar";
                    }
                }
            }

        private void btnModificarCarro_Click(object sender, EventArgs e)
        {
                if (btnModificarCarro.Text == "Modificar")
                {
                btnNuevoCarro.Text = "Guardar";
                btnModificarCarro.Text = "Cancelar";
                    estadoControles(false);
                    accion = "modificar";
                }
                else
                {

                    estadoControles(true);
                    mostrarDatosCarro();
                btnNuevoCarro.Text = "Nuevo";
                btnModificarCarro.Text = "Modificar";
                }
            }
            private void estadoControles(Boolean estado)
            {
            txtCodigoCarro.ReadOnly = estado;
            txtNombreCarro.ReadOnly = estado;
            txtDireccionCarro.ReadOnly = estado;
            txtTelefonoCarro.ReadOnly = estado;
            txtNumeroCarro.ReadOnly = estado;
            

            grbNavegacionCarro.Enabled = estado;
            btnEliminarCarro.Enabled = estado;
            txtBuscarCarros.ReadOnly = !estado;
            }
            private void limpiarCajas()
            {
            txtCodigoCarro.Text = "";
            txtNombreCarro.Text = "";
            txtDireccionCarro.Text = "";
            txtTelefonoCarro.Text = "";
            txtNumeroCarro.Text = "";
        }


            private void seleccionarCarro()
            {
                posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdGestionCarro.CurrentRow.Cells["idVehiculo"].Value.ToString()));
                mostrarDatosCarro();
            }

            private void grdDatosMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                seleccionarCarro();
            }

        private void btnEliminarCarro_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Esta seguro de eliminar a " + txtCodigoCarro.Text, "Eliminado Carro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String[] vehiculos = new string[] {
                    "eliminar",txtCodigoCarro.Text, txtNombreCarro.Text,txtDireccionCarro.Text, txtTelefonoCarro.Text, txtNumeroCarro.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                    String msg = objConexion.mantenimientoCarro(vehiculos);
                    if (msg != "1")
                    {
                        MessageBox.Show("Error en la eliminacion de Carro: " + msg, "Registro de Carro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        posicion = 0;
                        actualizarDsCarro();
                    }
                }
        
        }

            

            private void vehiculos_Load(object sender, EventArgs e)
            {
                actualizarDsCarro();
                cboOpcionBuscarCarros.SelectedIndex = 1;

            }

        

        private void cboOpcionBuscarCarros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarCarros_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarCarro(txtBuscarCarros.Text, cboOpcionBuscarCarros.SelectedIndex);
            if (e.KeyCode == Keys.Enter)
            {
                seleccionarCarro();
                e.SuppressKeyPress = true;
            }
        }
    }


}
