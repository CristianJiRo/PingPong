using Firebase.Database;
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

        public static List<Jugador> Jugadores = new List<Jugador>();
        public static Liga liga = null;
        public static List<Partido> Partidos = new List<Partido>();




        public Form1()
        {
            InitializeComponent();

            //Datos de ejemplo
            ex();

            //Iniciar Grid de los partidos.
            dgPartidos();

            //Iniciar Grid de la liga.
            dgLiga();

            //Iniciar Grid de los Jugadores.
            dgJugadores();


            refresh();   
            
        }

        private void dgJugadores() 
        {
            //Configuramos el DataGridView de los Jugadores.

            gvJugadores.AutoGenerateColumns = false;
            gvJugadores.AutoSize = false;
            gvJugadores.ReadOnly = true;
            //gvJugadores.AllowUserToAddRows = false;

            //Añadimos columnas

            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //Image image;
            //try {

            //image = Image.FromFile("/user.png");
            //imageColumn.Image = image;
            //MessageBox.Show("Ok");
            //}

            //catch {

            //image = null;
            //imageColumn.Image = null;
            //MessageBox.Show("Error");

            //};


            //imageColumn.Name = "Image";
            //imageColumn.HeaderText = "Image";


            //gvJugadores.Columns.Add(imageColumn);

            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "Imagen";
            column2.Name = "Imagen";
            gvJugadores.Columns.Add(column2);


            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Nombre";
            column.Name = "Nombre";
            gvJugadores.Columns.Add(column);
            
        }
        
        public static void ex()
        {
            Jugador item = new Jugador("paco", "1");
            Jugadores.Add(item);
            Jugador item2 = new Jugador("Ramon", "2");
            Jugadores.Add(item2);
            Jugador item3 = new Jugador("pedro", "3");
            Jugadores.Add(item3);
            Jugador item4 = new Jugador("Juan", "4");
            Jugadores.Add(item4);
        }

        public void LigaPopulate()
        {
            if (Jugadores.Any() && liga != null)
            {
                
                gvLiga.Rows.Clear();
                gvLiga.Refresh();

                foreach (Jugador item in Jugadores)
                {
                    DataGridViewRow row = (DataGridViewRow)gvLiga.Rows[0].Clone();
                    row.Cells[0].Value = item.nombre;
                    row.Cells[1].Value = item.puntos;
                    row.Cells[2].Value = item.dif;
                    gvLiga.Rows.Add(row);
                   
                }
                
                //gvLiga.Sort(gvPartidos.Columns[1], ListSortDirection.Ascending);

            }
        }

        public void partidosPopulate()
        {
            
            if (liga != null) {

                gvPartidos.Rows.Clear();
                gvPartidos.Refresh();

                foreach (Partido item in liga.partidos)
                {

                    DataGridViewRow row = (DataGridViewRow)gvPartidos.Rows[0].Clone();
                    row.Cells[0].Value = item.jugador1.nombre;
                    row.Cells[1].Value = item.resJ1;
                    row.Cells[2].Value = item.jugador2.nombre;
                    row.Cells[3].Value = item.resJ2;

                    if (item.resJ1-item.resJ2 > 0)
                    {

                        row.Cells[4].Value = item.jugador1.nombre;

                    }
                    else if (item.resJ1 - item.resJ2 > 0)
                    {
                        row.Cells[4].Value = item.jugador2.nombre;
                    }

                    else
                    {
                        row.Cells[4].Value = "No jugado";
                    }

                    
                    gvPartidos.Rows.Add(row);

                }
                    

            }
        }

        public void jugadorPopulate()
        {            
            
            if (Jugadores.Any())
            {
                
                
                
                gvJugadores.Rows.Clear();
                gvJugadores.Refresh();
               
                foreach (Jugador jug in Jugadores)
                {
                    //Añadir jugador;
                    DataGridViewRow row = (DataGridViewRow)gvJugadores.Rows[0].Clone();
                    
                    //DataGridViewRow row = (DataGridViewRow)gvLiga.Rows[0].Clone();
                    row.Cells[0].Value = jug.urlFoto;
                    row.Cells[1].Value = jug.nombre;
                    gvJugadores.Rows.Add(row);
                }
            }
            
            
        }
        
        private void dgLiga()
        {
            //Configuramos el DataGridView de la Liga.
            gvLiga.AutoGenerateColumns = false;
            gvLiga.AutoSize = true;
            gvLiga.ReadOnly = true;
            //gvLiga.AllowUserToAddRows = false;


            //Añadimos columnas
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Jugador";
            column.Name = "Jugador";
            gvLiga.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Puntuacion";
            column.Name = "Puntuación";
            gvLiga.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Diferencia";
            column.Name = "Diferencia Puntos";
            gvLiga.Columns.Add(column);                      

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
            column.Name = "Sets";
            gvPartidos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Jugador2";
            column.Name = "Jugador 2";
            gvPartidos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PuntJugador2";
            column.Name = "Sets";
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
            for (int a = 0; a < Jugadores.Count; a ++)
            {
                for (int b = a+1 ; b < Jugadores.Count; b++)
                {
                    Partido item = new Partido(
                        Jugadores[a],
                        Jugadores[b]
                        );
                    Partidos.Add(item);

                }
            }
            liga = new Liga(Partidos);

            refresh();

            añadirJugadorToolStripMenuItem.Enabled = false;
            eliminarJugadorToolStripMenuItem.Enabled = false;
            iniciarLigaToolStripMenuItem.Enabled = false;
            siguientePartidoToolStripMenuItem.Enabled = true;


        }
        
        private void eliminarLigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liga = null;
            Partidos = null;
            añadirJugadorToolStripMenuItem.Enabled = true;
            eliminarJugadorToolStripMenuItem.Enabled = true;
            iniciarLigaToolStripMenuItem.Enabled = true;
            eliminarLigaToolStripMenuItem.Enabled = false;
            siguientePartidoToolStripMenuItem.Enabled = false;
            
        }

        private void refresh ()
        {
            jugadorPopulate();
            LigaPopulate();
            partidosPopulate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
            
        }

       
    }

    
}
