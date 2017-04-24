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
    public partial class FormAddJugador : Form
    {
        public FormAddJugador()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {           
            String nombre = tb_name.Text + " " + tb_ape1.Text + " " + tb_ape2.Text;
            String url = "empty";

            Jugador item = new Jugador(nombre, url);
            Form1.Jugadores.Add(item);
            this.Close();
        }
    }
}
