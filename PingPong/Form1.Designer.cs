namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ligaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarLigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguientePartidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligaToolStripMenuItem,
            this.jugadoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ligaToolStripMenuItem
            // 
            this.ligaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarLigaToolStripMenuItem,
            this.eliminarLigaToolStripMenuItem,
            this.siguientePartidoToolStripMenuItem});
            this.ligaToolStripMenuItem.Name = "ligaToolStripMenuItem";
            this.ligaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.ligaToolStripMenuItem.Text = "Liga";
            // 
            // iniciarLigaToolStripMenuItem
            // 
            this.iniciarLigaToolStripMenuItem.Name = "iniciarLigaToolStripMenuItem";
            this.iniciarLigaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.iniciarLigaToolStripMenuItem.Text = "Iniciar Liga";
            // 
            // eliminarLigaToolStripMenuItem
            // 
            this.eliminarLigaToolStripMenuItem.Name = "eliminarLigaToolStripMenuItem";
            this.eliminarLigaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarLigaToolStripMenuItem.Text = "Eliminar Liga";
            // 
            // siguientePartidoToolStripMenuItem
            // 
            this.siguientePartidoToolStripMenuItem.Name = "siguientePartidoToolStripMenuItem";
            this.siguientePartidoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.siguientePartidoToolStripMenuItem.Text = "Siguiente Partido";
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirJugadorToolStripMenuItem,
            this.eliminarJugadorToolStripMenuItem,
            this.modificarJugadorToolStripMenuItem});
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.jugadoresToolStripMenuItem.Text = "Jugadores";
            // 
            // añadirJugadorToolStripMenuItem
            // 
            this.añadirJugadorToolStripMenuItem.Name = "añadirJugadorToolStripMenuItem";
            this.añadirJugadorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.añadirJugadorToolStripMenuItem.Text = "Añadir Jugador";
            // 
            // eliminarJugadorToolStripMenuItem
            // 
            this.eliminarJugadorToolStripMenuItem.Name = "eliminarJugadorToolStripMenuItem";
            this.eliminarJugadorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarJugadorToolStripMenuItem.Text = "Eliminar Jugador";
            // 
            // modificarJugadorToolStripMenuItem
            // 
            this.modificarJugadorToolStripMenuItem.Name = "modificarJugadorToolStripMenuItem";
            this.modificarJugadorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarJugadorToolStripMenuItem.Text = "Modificar Jugador";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.62085F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.37915F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1227, 757);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 781);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ping Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ligaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarLigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarLigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguientePartidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarJugadorToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

