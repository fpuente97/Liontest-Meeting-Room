using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomLista
{
    public class SalasExistentes
    {
        public int SalaID { get; set; }
        public string Sala { get; set; }

    }

    public class ListHours
    {
        public string HourHalf { get; set; }
    }

    public class ListSalasUsuario
    {
        public int ID { get; set; }
        public string Sala { get; set; }
        public string FechaInicio { get; set; }
        public string HoraInicio { get; set; }
        public string FechaFinal { get; set; }
        public string HoraFinal { get; set; }
    }

}
