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
    public partial class FormSigPartido : Form
    {
        public FormSigPartido()
        {
            InitializeComponent();

            foreach (Partido item in Form1.liga.partidos)
            {
                if (item.resJ1 == 0 && item.resJ2 == 0)
                {
                    cb_partido.Items.Add(item.jugador1.nombre + " vs " + item.jugador2.nombre);
                }
            }
        }

        private void cb_partido_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Text = Form1.liga.partidos[cb_partido.SelectedIndex].jugador1.nombre;

            label3.Visible = true;
            label3.Text = Form1.liga.partidos[cb_partido.SelectedIndex].jugador2.nombre;

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            tb_p1.Visible = true;
            tb_p2.Visible = true;
            tb_tot1.Visible = true;
            tb_tot2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resJ1 = Int32.Parse(tb_p1.Text);
            int resJ2 = Int32.Parse(tb_p2.Text);
            int tot1 = Int32.Parse(tb_tot1.Text);
            int tot2 = Int32.Parse(tb_tot2.Text);

            Form1.liga.partidos[cb_partido.SelectedIndex].resJ1 = resJ1;
            Form1.liga.partidos[cb_partido.SelectedIndex].resJ2 = resJ2;
            Form1.liga.partidos[cb_partido.SelectedIndex].jugador1.dif += tot1 - tot2;
            Form1.liga.partidos[cb_partido.SelectedIndex].jugador2.dif += tot2 - tot1;
            Form1.liga.jornada += 1;

            if (resJ1 < resJ2)
            {
                Form1.liga.partidos[cb_partido.SelectedIndex].jugador2.puntos += 3;
            }
            else
            {
                Form1.liga.partidos[cb_partido.SelectedIndex].jugador1.puntos += 3;
            }

            this.Close();
        }
    }
}
