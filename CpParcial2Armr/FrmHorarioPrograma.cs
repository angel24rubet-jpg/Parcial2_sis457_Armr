using CadParcial2Armr;
using ClnParcial2Armr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpParcial2Armr
{
    public partial class FrmHorarioPrograma : Form
    {
        private bool esNuevo;
        public FrmHorarioPrograma()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var lista = HorarioProgramaCln.listar(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idCanal"].Visible = false;
            dgvLista.Columns["canal"].HeaderText = "CANAL";
            dgvLista.Columns["titulo"].HeaderText = "TITULO";
            dgvLista.Columns["horaInicio"].HeaderText = "HORA INICIO";
            dgvLista.Columns["horaFin"].HeaderText = "HORA FIN";
            dgvLista.Columns["estado"].HeaderText = "ESTADO";
            dgvLista.Columns["diaSemana"].HeaderText = "DIA SEMANA";
            dgvLista.Columns["conductorPrincipal"].HeaderText = "CONDUCTOR PRINCIPAL";
            dgvLista.Columns["clasificacion"].HeaderText = "CLASIFICACIÓN";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["canal"];

            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;

        }

        private void cargarCanal()
        {
            cboCanal.DataSource = CanalCln.listar();
            cboCanal.ValueMember = "id";
            cboCanal.DisplayMember = "nombre";
            cboCanal.SelectedIndex = -1;
        }
        private void cargarDias()
        {
            cboDiaSemana.Items.Clear();
            cboDiaSemana.Items.Add("Lunes");
            cboDiaSemana.Items.Add("Martes");
            cboDiaSemana.Items.Add("Miércoles");
            cboDiaSemana.Items.Add("Jueves");
            cboDiaSemana.Items.Add("Viernes");
            cboDiaSemana.Items.Add("Sábado");
            cboDiaSemana.Items.Add("Domingo");

            cboDiaSemana.SelectedIndex = -1;
        }
        // nuevo metodo 
        private void cargarClasificacion()
        {
            cboClasificacion.Items.Clear();
            cboClasificacion.Items.Add("ATP");
            cboClasificacion.Items.Add("10+");
            cboClasificacion.Items.Add("13+");
            cboClasificacion.Items.Add("18+");
            cboClasificacion.SelectedIndex = 0;
        }
        private void FrmHorarioPrograma_Load(object sender, EventArgs e)
        {
            Size = new Size(1072,536);
            listar();
            cargarCanal();
            cargarDias();
            cargarClasificacion();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();

        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                listar();
            }
        }

        private void resetearCampos()
        {
            cboCanal.SelectedIndex = -1;
            txtTituloPrograma.Clear();
            dtpHoraInicio.Value = DateTime.Today;
            dtpHoraFin.Value = DateTime.Today;
            cboDiaSemana.SelectedIndex = -1;
            txtConductorPrincipal.Clear();
            cboClasificacion.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(1072, 838);
            pnlAcciones.Enabled = false;
            resetearCampos();
            cboCanal.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;

            var id = Convert.ToInt32(dgvLista.CurrentRow.Cells["id"].Value);
            var registro = HorarioProgramaCln.obtener(id);

            if (registro == null)
            {
                MessageBox.Show("No se encontró el programa.");
                return;
            }

            cboCanal.SelectedValue = registro.idCanal;
            txtTituloPrograma.Text = registro.titulo;
            dtpHoraInicio.Value = DateTime.Today.Add(registro.horaInicio);
            dtpHoraFin.Value = DateTime.Today.Add(registro.horaFin);
            cboDiaSemana.Text = registro.diaSemana;
            txtConductorPrincipal.Text = registro.conductorPrincipal;
            cboClasificacion.Text = registro.clasificacion;

            Size = new Size(1072, 838);
            pnlAcciones.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetearCampos();
            Size = new Size(1072, 536);
            pnlAcciones.Enabled = true;
            listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCanal.SelectedIndex == -1)
                    throw new Exception("Seleccione un canal.");

                if (string.IsNullOrWhiteSpace(txtTituloPrograma.Text))
                    throw new Exception("Ingrese el título del programa.");

                if (cboDiaSemana.SelectedIndex == -1)
                    throw new Exception("Seleccione el día de la semana.");

                if (string.IsNullOrWhiteSpace(txtConductorPrincipal.Text))
                    throw new Exception("Ingrese el conductor principal.");

                if (dtpHoraInicio.Value.TimeOfDay >= dtpHoraFin.Value.TimeOfDay)
                    throw new Exception("La hora de inicio debe ser menor a la hora de fin.");

                var horarioPrograma = new HorarioPrograma();
                horarioPrograma.idCanal = Convert.ToInt32(cboCanal.SelectedValue);
                horarioPrograma.titulo = txtTituloPrograma.Text.Trim();
                horarioPrograma.horaInicio = dtpHoraInicio.Value.TimeOfDay;
                horarioPrograma.horaFin = dtpHoraFin.Value.TimeOfDay;
                horarioPrograma.diaSemana = cboDiaSemana.Text;
                horarioPrograma.conductorPrincipal = txtConductorPrincipal.Text.Trim();
                horarioPrograma.clasificacion = cboClasificacion.Text;
                horarioPrograma.estado = 1;

                if (esNuevo)
                {
                    HorarioProgramaCln.crear(horarioPrograma);
                }
                else
                {
                    horarioPrograma.id = Convert.ToInt32(dgvLista.CurrentRow.Cells["id"].Value);
                    HorarioProgramaCln.actualizar(horarioPrograma);
                }

                listar();
                resetearCampos();
                Size = new Size(1072, 536);
                pnlAcciones.Enabled = true;

                MessageBox.Show("Registro guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvLista.CurrentRow.Cells["id"].Value);

                var resultado = MessageBox.Show(
                    "¿Está seguro de eliminar este programa?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    HorarioProgramaCln.eliminar(id);

                    listar();
                    resetearCampos();

                    MessageBox.Show("Programa eliminado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
