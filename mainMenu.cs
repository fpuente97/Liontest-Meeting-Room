using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeetingRoomDatabase;

namespace Liontest_Meeting_Room
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        public MeetingDatabase room = new MeetingDatabase();

        private void cmbUser_TextChanged(object sender, EventArgs e)
        {
            ObtenerDGVDatos();
        }

        private void ObtenerDGVDatos()
        {
            dgvReservas.DataSource = room.SalasPorUsuario(cmbUser.Text);

            dgvReservas.Columns["Sala"].Width = 100;
            dgvReservas.Columns["FechaInicio"].Width = 82;
            dgvReservas.Columns["HoraInicio"].Width = 82;
            dgvReservas.Columns["FechaFinal"].Width = 82;
            dgvReservas.Columns["HoraFinal"].Width = 82;

            dgvReservas.Columns["ID"].Visible = false;
            dgvReservas.Columns["FechaInicio"].HeaderText = "Inicio";
            dgvReservas.Columns["HoraInicio"].HeaderText = "";
            dgvReservas.Columns["FechaFinal"].HeaderText = "Final";
            dgvReservas.Columns["HoraFinal"].HeaderText = "";
        }

        private void bttnReserv_Click(object sender, EventArgs e)
        {

            string username = cmbUser.Text;

            if(username == "")
            {
                MessageBox.Show("Selecciona un usuario");
            }
            else
            {
                revForm revform = new revForm(username);
                revform.Show();
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            //Verificar que se haya seleccionado una reserva
            if(dgvReservas.SelectedRows.Count > 0)
            {
                //Obtenemos el ID de la reserva y ejecutamos el método de CancelarReserva para actualizar en la base de datos.
                //Y al final hacemos un refresh del dgv
                int selectedID = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells[0].Value);
                room.CancelarReserva(selectedID);
                ObtenerDGVDatos();
            }
            else
            {
                MessageBox.Show("Selecciona una reserva");
            }
            
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            ObtenerDGVDatos();
        }
    }
}
