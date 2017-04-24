using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class FormEliminarJugador : Form
    {
        public FormEliminarJugador()
        {
            InitializeComponent();

            foreach (Jugador player in Form1.Jugadores)
            {
                cb_item.Items.Add(player.nombre);
            }
        }

        private void FormEliminarJugador_Load(object sender, EventArgs e)
        {

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if(cb_item.SelectedIndex >-1 && cb_item.SelectedIndex < Form1.Jugadores.Count)
            {

                Form1.Jugadores.RemoveAt(cb_item.SelectedIndex);
                this.Close();

            }

            
        }
    }
}
