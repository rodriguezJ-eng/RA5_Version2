using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RA52M3
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }

        List<Estudiante> ListaEstudiante = new List<Estudiante>();

        void Limpiar()
        {
            txtCarnet.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCarnet.Focus();
            cmbSexo.SelectedIndex = -1;
        }

        void Imprimir()
        {
            dgvEstudiante.DataSource = null;
            dgvEstudiante.DataSource = ListaEstudiante;
        }

        void Guardar()
        {
            ListaEstudiante.Add(new Estudiante ()
            {
                Carnet = txtCarnet.Text,
                Nombre = txtNombres.Text,
                Apellido = txtApellidos.Text,
                Telefono = txtTelefono.Text,
                sexo = cmbSexo.Text
            });
            MessageBox.Show("Estudiante Registrado");
            Imprimir();
            Limpiar();
        }

        void Buscar()
        {
            string CarnetBuscar = txtCarnet.Text;
            Estudiante Resultado = ListaEstudiante.Where(x =>x.Carnet == CarnetBuscar).FirstOrDefault();

            if (Resultado == null)
            {
                MessageBox.Show("No existe un estudiante con ese carnet");
                Limpiar();
                return;
            }
            txtNombres.Text = Resultado.Nombre;
            txtApellidos.Text=Resultado.Apellido;
            txtTelefono.Text = Resultado.Telefono;
            cmbSexo.Text = Resultado.sexo;

        }


        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbSexob.Items.Add("Masculino");
            cmbSexob.Items.Add("Femenino");
            cmbSexob.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbOrden.Items.Add("Apellido (A-Z)");
            cmbOrden.Items.Add("Apellido (Z-A)");
            cmbOrden.Items.Add("Nombre (A-Z)");
            cmbOrden.Items.Add("Nombre (Z-A)");
            cmbOrden.DropDownStyle = ComboBoxStyle.DropDownList;

            rbNombres.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void dgvEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int FilaActual = e.RowIndex;

            txtCarnet.Text = dgvEstudiante.Rows[FilaActual].Cells[0].Value.ToString();
            txtNombres.Text = dgvEstudiante.Rows[FilaActual].Cells[1].Value.ToString();
            txtApellidos.Text = dgvEstudiante.Rows[FilaActual].Cells[2].Value.ToString();
            txtTelefono.Text = dgvEstudiante.Rows[FilaActual].Cells[3].Value.ToString();
           cmbSexo.Text = dgvEstudiante.Rows[FilaActual].Cells[4].Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        void Filtrar()
        {
            List<Estudiante> Resultado;
            if(rbNombres.Checked == true)
            {
                Resultado = ListaEstudiante.Where(x => x.Nombre.ToLower().StartsWith(txtFiltrar.Text.ToLower())).ToList();
            }
            else if(rbApellidos.Checked == true)
            {
                Resultado = ListaEstudiante.Where(x => x.Apellido.ToLower().StartsWith(txtFiltrar.Text.ToLower())).ToList();
            }
            else
            {
                Resultado = ListaEstudiante;
            }

            dgvEstudiante.DataSource = null;
            dgvEstudiante.DataSource = Resultado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string CarnetBuscar = txtCarnet.Text;
            Estudiante Resultado = ListaEstudiante.Where(x => x.Carnet == CarnetBuscar).FirstOrDefault();

            if (Resultado == null)
            {
                MessageBox.Show("No existe un estudiante con ese carnet");
                Limpiar();
                return;
            }

            Resultado.Nombre = txtNombres.Text;
            Resultado.Apellido = txtApellidos.Text;
            Resultado.Telefono = txtTelefono.Text;
            Resultado.sexo = cmbSexo.Text;
            MessageBox.Show("Se guardaron los cambios");
            Limpiar();
            Imprimir();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string CarnetBuscar = txtCarnet.Text;
            Estudiante Resultado = ListaEstudiante.Where(x => x.Carnet == CarnetBuscar).FirstOrDefault();

            if (Resultado == null)
            {
                MessageBox.Show("No existe un estudiante con ese carnet");
                Limpiar();
                return;
            }

            ListaEstudiante.Remove(Resultado);
            MessageBox.Show("Estudiante Eliminado");
            Limpiar();
            Imprimir() ;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void cmbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Opcion = cmbOrden.SelectedIndex;
            List<Estudiante> ListaOrdenada;
            switch (cmbOrden.SelectedIndex)
            {
                case 0:
                    ListaOrdenada = ListaEstudiante.OrderBy(x => x.Apellido).ToList();
                    break;
                case 1:
                    ListaOrdenada = ListaEstudiante.OrderByDescending(x => x.Apellido).ToList();
                    break;
                case 2:
                    ListaOrdenada = ListaEstudiante.OrderBy(x => x.Nombre).ToList();
                    break;
                case 3:
                    ListaOrdenada = ListaEstudiante.OrderByDescending(x => x.Nombre).ToList();
                    break;
                default:
                    ListaOrdenada = ListaEstudiante;
                    break;
            }
            dgvEstudiante.DataSource = null;
            dgvEstudiante.DataSource = ListaOrdenada;
        }
    }
}
