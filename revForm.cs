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
    public partial class revForm : Form
    {
        public revForm(string userName)
        {
            InitializeComponent();
            SetcmbSalas();

            DateTime CurrentTime = DateTime.Now;

            dtFecha.Value = CurrentTime.Date;
            CargarHoras(CurrentTime);

            this.username = userName;

        }
        public string username { get; set; }

        public MeetingDatabase room = new MeetingDatabase();

        private void SetcmbSalas()
        {
            cmbSalas.DataSource = room.Salas();
            cmbSalas.DisplayMember = "Sala";
            cmbSalas.ValueMember = "SalaID";
        }

        private void bttnReservar_Click(object sender, EventArgs e)
        {
            
            //Convertimos la hora inicial en formato DateTime
            DateTime HoraInicio = Convert.ToDateTime(TiempoInicio.SelectedValue);
            DateTime FechaInicio = dtFecha.Value.AddHours(HoraInicio.Hour);
            FechaInicio = FechaInicio.AddMinutes(HoraInicio.Minute);

            //Convertimos la hora final en formato DateTime
            DateTime HoraFinal = Convert.ToDateTime(TiempoFinal.SelectedValue);
            DateTime FechaFinal = dtFecha.Value.AddHours(HoraFinal.Hour);
            FechaFinal = FechaFinal.AddMinutes(HoraFinal.Minute);

            //Calculamos el TimeSpan para determinar si la hora final ocurre al día siguiente
            TimeSpan DifHora = HoraFinal - HoraInicio;

            if (DifHora.TotalHours < 0)
            {
                FechaFinal = FechaFinal.AddDays(1); //Se suma un día en caso de que la diferencia de horas sea menor a 0
            }

            if(room.SalaYaReservada(cmbSalas.SelectedValue.ToString(), FechaInicio, FechaFinal) == false) //Buscamos que la reserva no tenga conflicto con alguna otra
            {
                room.ReservarSala(cmbSalas.SelectedValue.ToString(), FechaInicio, FechaFinal, username); //Se almacena en Base de Datos
            }
            

        }

        private void CargarHoras(DateTime CurrentTime) //Para cargar las horas en las Combobox
        {
            try
            {

                DateTime HoraInicio = Convert.ToDateTime(CurrentTime);

                //Cargamos las horas en la Combobox de la Hora Inicial
                TiempoInicio.DataSource = room.Horas(HoraInicio,true);
                TiempoInicio.DisplayMember = "HourHalf";
                TiempoInicio.ValueMember = "HourHalf";

                //Cargamos las horas en la Combobox de la Hora Final, seteando EsInicio como falso para limitar a dos horas
                TiempoFinal.DataSource = room.Horas(CurrentTime.AddMinutes(30),false);
                TiempoFinal.DisplayMember = "HourHalf";
                TiempoFinal.ValueMember = "HourHalf";

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void TiempoInicio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarHoras(Convert.ToDateTime(TiempoInicio.SelectedValue));
            }
            catch(Exception ex)
            {
                if(ex.HResult == -2147467262)
                {
                    //Permitir que el programa siga
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
