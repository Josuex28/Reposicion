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

            private void vehiculos_Load(object sender, EventArgs e)
            {
                actualizarDsCarro();
                cboOpcionBuscarCarro.SelectedIndex = 0;
            }
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
                erpCarro.SetError(txtBuscarCarro, "");
                }
                catch (Exception e)
                {
                erpCarro.SetError(txtBuscarCarro, "Por favor ingrese un codigo o materia a buscr");
                }
            }
            private void mostrarDatosCarro()
            {
                if (miTabla.Rows.Count > 0)
                {
                txtCodigoCarro.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreCarro.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                

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

            private void btnUltimoMateria_Click_1(object sender, EventArgs e)
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

            private void btnNuevoMateria_Click_1(object sender, EventArgs e)
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
                {//Gu
                    String[] materias = new string[] {
                    accion,txtCodigoCarro.Text, txtNombreCarro.Text, 
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                    String msg = objConexion.mantenimientoMaterias(materias);
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

            private void btnModificarMateria_Click_1(object sender, EventArgs e)
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
            txtBuscarCarro.ReadOnly = !estado;
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

            private void btnEliminarMateria_Click_1(object sender, EventArgs e)
            {
                if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreCarro.Text, "Eliminado Carro",
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

            private void materiasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
            {
                this.Validate();
                this.vehiculosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet);

            }

            private void vehiculo_Load(object sender, EventArgs e)
            {
                actualizarDsCarro();
                cboOpcionBuscarCarro.SelectedIndex = 1;

            }

            private void txtBuscarMaterias_KeyUp(object sender, KeyEventArgs e)
            {
                filtrarCarro(txtBuscarCarro.Text, cboOpcionBuscarCarro.SelectedIndex);
                if (e.KeyCode == Keys.Enter)
                {
                    seleccionarCarro();
                    e.SuppressKeyPress = true;
                }
            }

        
    }


    }
