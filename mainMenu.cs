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
            dgvReservas.DataSource = room.SalasPorUsuario(cmbUser.Text);
        }

        private void bttnReserv_Click(object sender, EventArgs e)
        {
            revForm revform = new revForm();
            revform.Show();
        }

        public static string usertext()
        {
            return cmbUser.Text;
        }
    }
}
