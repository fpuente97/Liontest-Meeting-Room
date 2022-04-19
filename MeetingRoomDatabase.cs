using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingRoomLista;
using MySqlConnector;
using System.Windows.Forms;

namespace MeetingRoomDatabase
{
    public class MeetingDatabase
    {

        public MySqlConnectionStringBuilder ConnectionString = new MySqlConnectionStringBuilder
        {
            Server = "fpuentepi97.ddnsfree.com",
            Port = 8080,
            Database = "lionsstest",
            UserID = "liontest",
            Password = "liontest"
        };

        public List<SalasExistentes> Salas()
        {
            try
            {
                MySqlConnection Conn = new MySqlConnection(ConnectionString.ToString());
                string MySqlStr = "SELECT * FROM tblSalas";
                MySqlCommand cmd = new MySqlCommand(MySqlStr, Conn);

                Conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<SalasExistentes> Lista = new List<SalasExistentes>();

                while (rdr.Read())
                {
                    SalasExistentes fila = new SalasExistentes();
                    fila.SalaID = rdr.GetInt32(0);
                    fila.Sala = rdr.GetString(1);
                    Lista.Add(fila);
                }

                Conn.Close();

                return Lista;
            }
            catch(MySqlException ex)
            {

                MessageBox.Show("Ha ocurrido un error: " + ex.Number);
                
                return null;
            }
        }

        public List<ListSalasUsuario> SalasPorUsuario(string Usuario)
        {
            try
            {
                MySqlConnection Conn = new MySqlConnection(ConnectionString.ToString());
                string MySqlStr = "SELECT r.Reserva_ID, s.Sala, r.InicioRenta, r.FinRenta FROM tblReserva r INNER JOIN tblSalas s ON r.Sala_ID = s.Sala_ID " +
                    "WHERE r.Usuario = @Usuario And r.Activa = 1";
                MySqlCommand cmd = new MySqlCommand(MySqlStr, Conn);

                cmd.Parameters.AddWithValue("@Usuario",Usuario);

                Conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<ListSalasUsuario> Lista = new List<ListSalasUsuario>();

                while (rdr.Read())
                {
                    ListSalasUsuario fila = new ListSalasUsuario();
                    fila.ID = rdr.GetInt32(0);
                    fila.Sala = rdr.GetString(1);
                    fila.FechaInicio = rdr.GetDateTime(2).Date.ToString("dd/MM/yyyy");
                    fila.HoraInicio = rdr.GetDateTime(2).ToShortTimeString();
                    fila.FechaFinal = rdr.GetDateTime(3).Date.ToString("dd/MM/yyyy");
                    fila.HoraFinal = rdr.GetDateTime(3).ToShortTimeString();
                    Lista.Add(fila);
                }

                return Lista;

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Number);

                return null;
            }
        }

        public List<ListHours> Horas(DateTime CurrentTime, bool EsInicio) //Se crea lista de horas para llenar en las combobox
        {
            try
            {
                List<ListHours> Lista = new List<ListHours>();

                int intMinute = CurrentTime.Minute;

                if (intMinute > 0)
                {
                    if (intMinute <= 30)
                    {
                        CurrentTime = Convert.ToDateTime(CurrentTime.Hour + ":30:00");
                    }
                    else
                    {
                        CurrentTime = Convert.ToDateTime(CurrentTime.AddHours(1).Hour + ":00:00");
                    }
                }

                int i = 1;
                int x;

                if(EsInicio == true) //Esta variable identifica si es la hora de inicio o la hora final
                {
                    x = 48;
                }
                else
                {
                    x = 4;
                }

                while (i <= x) //Se crea un registro de cada media hora
                {
                    ListHours fila = new ListHours();
                    fila.HourHalf = CurrentTime.ToShortTimeString();
                    Lista.Add(fila);
                    CurrentTime = CurrentTime.AddMinutes(30);
                    i++;
                }

                return Lista;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido el error " + ex.Number);

                return null;
            }
        }

        public void ReservarSala(string Sala, DateTime FechaInicio, DateTime FechaFinal, string username)
        {
            try
            {
                //Registrar la reservación de la sala en la base de datos
                MySqlConnection Conn = new MySqlConnection(ConnectionString.ToString());
                string MySqlStr = "INSERT INTO tblReserva(Sala_ID,InicioRenta,FinRenta,Activa, Usuario) " +
                    "VALUES(@Sala, @FechaInicio, @FechaFinal, true, @UserName)";
                MySqlCommand cmd = new MySqlCommand(MySqlStr, Conn);

                cmd.Parameters.AddWithValue("@Sala", Sala);
                cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", FechaFinal);
                cmd.Parameters.AddWithValue("@UserName", username);

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();

                MessageBox.Show("La Sala fue reservada exitosamente");

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido el error " + ex.Number);
            }
        }

        public void CancelarReserva(int reservaID)
        {
            try
            {
                //Cancela la reserva con el ID
                MySqlConnection Conn = new MySqlConnection(ConnectionString.ToString());
                string MySqlStr = "UPDATE tblReserva r Set r.Activa = 0 Where r.Reserva_ID = @reservaID";
                MySqlCommand cmd = new MySqlCommand(MySqlStr, Conn);

                cmd.Parameters.AddWithValue("@reservaID", reservaID);

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();

                MessageBox.Show("Reserva de sala cancelada");

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Ocurrió el error: " + ex.Number);
            }
        }

        public bool SalaYaReservada(string Sala, DateTime FechaInicio, DateTime FechaFinal)
        {
            MySqlConnection Conn = new MySqlConnection(ConnectionString.ToString());

            string MySqlStr = "SELECT InicioRenta, FinRenta FROM tblReserva WHERE Activa = 1 AND Sala_ID = @SalaName";
            MySqlCommand cmd = new MySqlCommand(MySqlStr, Conn);
            cmd.Parameters.AddWithValue("@SalaName", Sala);

            bool Resultado = false;

            Conn.Open();
            MySqlDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                if (FechaInicio >= sqldr.GetDateTime(0) && FechaInicio < sqldr.GetDateTime(1))
                {
                    Resultado = true;
                }
                else if (FechaFinal > sqldr.GetDateTime(0) && FechaFinal <= sqldr.GetDateTime(1))
                {
                    Resultado = true;
                }
                else if (sqldr.GetDateTime(0) >= FechaInicio && sqldr.GetDateTime(0) < FechaFinal)
                {
                    Resultado = true;
                }
                else if (sqldr.GetDateTime(1) > FechaInicio && sqldr.GetDateTime(1) <= FechaFinal)
                {
                    Resultado = true;
                }
            }

            Conn.Close();

            if(Resultado == true)
            {
                MessageBox.Show("Esta reserva causa conflicto con otra. No fue posible reservar la sala");
            }

            return Resultado;
        }
    }
}
