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
    public partial class Form1 : Form
    {

        private BindingSource bindingSource1 = new BindingSource();


        public Form1()
        {
            InitializeComponent();

            //Iniciar Grid de los partidos.
            dgPartidos();

            //Iniciar Grid de la liga.
            dgLiga();

            //Iniciar Grid de los jugadores.
            dgJugadores();



        }

        private void dgJugadores() 
        {
            //Configuramos el DataGridView de los jugadores.

            gvJugadores.AutoGenerateColumns = false;
            gvJugadores.AutoSize = false;
            gvJugadores.ReadOnly = true;

            //Añadimos columnas
            
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            Image image;
            try {
                
                image = Image.FromFile("/user.png");
                imageColumn.Image = image;
                MessageBox.Show("Ok");
            }

            catch {

                image = null;
                imageColumn.Image = null;
                MessageBox.Show("Error");

            };
                                
           
            imageColumn.Name = "Image";
            imageColumn.HeaderText = "Image";
            

            gvJugadores.Columns.Add(imageColumn);

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Nombre";
            column.Name = "Nombre";
            gvJugadores.Columns.Add(column);

            DataGridViewRow row = (DataGridViewRow)gvJugadores.Rows[0].Clone();
            row.Cells[0].Value = image;
            row.Cells[1].Value = "pepe";
            
            gvJugadores.Rows.Add(row);



        }

        private void dgLiga()
        {
            //Configuramos el DataGridView de la Liga.
            gvLiga.AutoGenerateColumns = false;
            gvLiga.AutoSize = true;
            gvLiga.ReadOnly = true;


            //Añadimos columnas
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Jugador1";
            column.Name = "Jugador";
            gvLiga.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PuntosJugador1";
            column.Name = "Puntuación";
            gvLiga.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Jugados";
            column.Name = "Jugados";
            gvLiga.Columns.Add(column);


            DataGridViewRow row = (DataGridViewRow)gvLiga.Rows[0].Clone();
            row.Cells[0].Value = "user.png";
            row.Cells[1].Value = "pepe";
            row.Cells[2].Value = "pepe";
            gvLiga.Rows.Add(row);

        }


        private void dgPartidos()
        {
            //Configuramos el DataGridView de los Partidos.
            gvPartidos.AutoGenerateColumns = false;
            gvPartidos.AutoSize = true;
            gvPartidos.ReadOnly = true;


            //Añadimos columnas
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Jugador1";
            column.Name = "Jugador 1";
            gvPartidos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PuntJugador1";
            column.Name = "Puntos";
            gvPartidos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Jugador2";
            column.Name = "Jugador 2";
            gvPartidos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PuntJugador2";
            column.Name = "Puntos";
            gvPartidos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Ganador";
            column.Name = "Ganador";
            gvPartidos.Columns.Add(column);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void anadirJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddJugador window = new FormAddJugador();
            window.ShowDialog();
        }

        private void eliminarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarJugador window = new FormEliminarJugador();
            window.ShowDialog();
        }

        private void modificarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarJugador window = new FormModificarJugador();
            window.ShowDialog();
        }

        private void siguientePartidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSigPartido window = new FormSigPartido();
            window.ShowDialog();
        }



        private void iniciarLigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }



        private void eliminarLigaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }

    
}
