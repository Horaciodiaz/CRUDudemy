using CRUDudemy.Datos;
using CRUDudemy.Entidades;
using CRUDudemy.Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDudemy.Presentacion
{
    public partial class FormContactos : Form
    {
        public FormContactos()
        {
            InitializeComponent();
            estadoTexto(false);
            estadoBotonesProceso(false);
        }

        #region "Mis Variables"
        int vCodigoContacto = 0;
        int vCodigoCargo = 0;
        int nEstadoGuardar = 0;
        #endregion

        #region "Mis Metodos"
        private void limpiarTexto()
        {
            Nombre.Clear();
            Correo.Clear();
            Telefono.Clear();
        }

        private void estadoTexto(bool Estado)
        {
            Nombre.Enabled = Estado;
            Correo.Enabled = Estado;
            Telefono.Enabled = Estado;
            Cargo.Enabled = Estado;
            FechaNacimiento.Enabled = Estado;
        }

        private void estadoBotonesProceso(bool Estado)
        {
            btnCancelar.Visible = Estado;
            btnGuardar.Visible = Estado;
        }

        private void estadoBotonesPrincipal(bool Estado)
        {
            botonNuevo.Enabled = Estado;
            botonActualizar.Enabled = Estado;
            botonEliminar.Enabled = Estado;
            botonReporte.Enabled = Estado;
            botonSalir.Enabled = Estado;
        }

        private void listadoCargos()
        {
            try
            {
                Datos_contactos Datos = new Datos_contactos();
                Cargo.DataSource = Datos.listadoCargos();
                Cargo.ValueMember = "cargo_id";
                Cargo.DisplayMember = "descripcion_cargos";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void listadoContactos(string contTexto)
        {
            try
            {
                Datos_contactos Datos = new Datos_contactos();
                Listado.DataSource = Datos.listadoContactos(contTexto);
                this.formatoContactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void formatoContactos()
        {
            Listado.Columns[0].Width = 58;
            Listado.Columns[0].HeaderText = "CODIGO";
            Listado.Columns[1].Width = 150;
            Listado.Columns[1].HeaderText = "NOMBRE";
            Listado.Columns[2].Width = 70;
            Listado.Columns[2].HeaderText = "TELEFONO";
            Listado.Columns[3].Width = 150;
            Listado.Columns[3].HeaderText = "CORREO";
            Listado.Columns[4].Width = 100;
            Listado.Columns[4].HeaderText = "FECHA DE NACIMIENTO";
            Listado.Columns[5].Width = 100;
            Listado.Columns[5].HeaderText = "CARGO";
        }

        private void seleccionarContacto()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Listado.CurrentRow.Cells["codigo"].Value)))//si no se selecciono ningun dato
            {
                MessageBox.Show("Seleccione un registro valido",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else //si se tienen dato/s seleccionados
            {
                vCodigoContacto = Convert.ToInt32(Listado.CurrentRow.Cells["codigo"].Value);
                Nombre.Text = Convert.ToString(Listado.CurrentRow.Cells["nombre"].Value);
                Telefono.Text = Convert.ToString(Listado.CurrentRow.Cells["telefono"].Value);
                Correo.Text = Convert.ToString(Listado.CurrentRow.Cells["correo"].Value);
                FechaNacimiento.Text = Convert.ToString(Listado.CurrentRow.Cells["fechanac"].Value);
                Cargo.Text = Convert.ToString(Listado.CurrentRow.Cells["cargo"].Value);
            }
        }
        #endregion

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuardar = 1; //Nuevo registro
            this.limpiarTexto();
            this.estadoTexto(true);
            this.estadoBotonesProceso(true);
            this.estadoBotonesPrincipal(false);
            Nombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nEstadoGuardar = 0; //default
            this.limpiarTexto();
            this.estadoTexto(false);
            this.estadoBotonesProceso(false);
            this.estadoBotonesPrincipal(true);
        }

        private void FormContactos_Load(object sender, EventArgs e)
        {
            this.listadoCargos();
            this.listadoContactos("%");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text == string.Empty ||
                Cargo.Text == string.Empty)//los datos obligatorios no estan cargados
            {
                MessageBox.Show("Faltan los datos requeridos (*)",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                string respuesta = "";
                vCodigoCargo = Convert.ToInt32(Cargo.SelectedValue);
                E_Contactos contacto = new E_Contactos();
                contacto.Contacto_id = vCodigoContacto;
                contacto.Nombre_contacto = Nombre.Text;
                contacto.Telefono_contacto = Telefono.Text;
                contacto.Correo_contacto = Correo.Text;
                contacto.Fechanac_contacto = FechaNacimiento.Text;
                contacto.Cargo_id = vCodigoCargo;

                Datos_contactos Datos = new Datos_contactos();
                respuesta = Datos.guardarContacto(nEstadoGuardar, contacto);
                if (respuesta.Equals("OK"))
                {
                    this.limpiarTexto();
                    this.estadoTexto(false);
                    this.estadoBotonesProceso(false);
                    this.estadoBotonesPrincipal(true);
                    this.listadoContactos("%");
                    MessageBox.Show("Los datos han sido guardados correctamente",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta,
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

            }
        }
        private void Listado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.seleccionarContacto();
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            nEstadoGuardar = 2; //actualizar registro
            this.estadoTexto(true);
            this.estadoBotonesProceso(true);
            this.estadoBotonesPrincipal(false);
            Nombre.Focus();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.listadoContactos(Buscar.Text);
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (Listado.Rows.Count > 0)
            {
                string respuesta = "";
                Datos_contactos Datos = new Datos_contactos();
                vCodigoContacto = Convert.ToInt32(Listado.CurrentRow.Cells["codigo"].Value);
                respuesta = Datos.eliminarContacto(vCodigoContacto);
                if (respuesta.Equals("OK"))
                {
                    vCodigoContacto = 0;
                    this.listadoContactos("%");
                    MessageBox.Show("Registro Eliminado",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(respuesta,
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void botonReporte_Click(object sender, EventArgs e)
        {
            Form_reporte_contactos reporte = new Form_reporte_contactos();
            reporte.txt01.Text = Buscar.Text;
            reporte.ShowDialog();
        }
    }
}
