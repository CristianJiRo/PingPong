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
    public partial class FormModificarJugador : Form
    {
        public FormModificarJugador()
        {
            InitializeComponent();

            foreach (Jugador player in Form1.Jugadores)
            {
                cb_item.Items.Add(player.nombre );
            }
        }

        private void bt_selec_Click(object sender, EventArgs e)
        {
            if (cb_item.SelectedIndex > -1 && cb_item.SelectedIndex < Form1.Jugadores.Count)
            {

                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;

                tb_nombre.Enabled = true;
                tb_ape1.Enabled = true;
                tb_ape2.Enabled = true;

            }

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {


            if (cb_item.SelectedIndex > -1 && cb_item.SelectedIndex < Form1.Jugadores.Count)
            {

                Form1.Jugadores[cb_item.SelectedIndex].nombre = tb_nombre.Text + " " + tb_ape1.Text + " " + tb_ape2.Text;
                this.Close();

            }

        }
    }
}
