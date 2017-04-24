//https://msdn.microsoft.com/en-us/library/y0wfd4yz(v=vs.110).aspx

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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.gvJugadores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCent = new System.Windows.Forms.Panel();
            this.gvLiga = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDer = new System.Windows.Forms.Panel();
            this.gvPartidos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJugadores)).BeginInit();
            this.panelCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLiga)).BeginInit();
            this.panelDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligaToolStripMenuItem,
            this.jugadoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
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
            this.iniciarLigaToolStripMenuItem.Click += new System.EventHandler(this.iniciarLigaToolStripMenuItem_Click);
            // 
            // eliminarLigaToolStripMenuItem
            // 
            this.eliminarLigaToolStripMenuItem.Enabled = false;
            this.eliminarLigaToolStripMenuItem.Name = "eliminarLigaToolStripMenuItem";
            this.eliminarLigaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarLigaToolStripMenuItem.Text = "Eliminar Liga";
            this.eliminarLigaToolStripMenuItem.Click += new System.EventHandler(this.eliminarLigaToolStripMenuItem_Click);
            // 
            // siguientePartidoToolStripMenuItem
            // 
            this.siguientePartidoToolStripMenuItem.Enabled = false;
            this.siguientePartidoToolStripMenuItem.Name = "siguientePartidoToolStripMenuItem";
            this.siguientePartidoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.siguientePartidoToolStripMenuItem.Text = "Siguiente Partido";
            this.siguientePartidoToolStripMenuItem.Click += new System.EventHandler(this.siguientePartidoToolStripMenuItem_Click);
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
            this.añadirJugadorToolStripMenuItem.Text = "Anadir Jugador";
            this.añadirJugadorToolStripMenuItem.Click += new System.EventHandler(this.anadirJugadorToolStripMenuItem_Click);
            // 
            // eliminarJugadorToolStripMenuItem
            // 
            this.eliminarJugadorToolStripMenuItem.Name = "eliminarJugadorToolStripMenuItem";
            this.eliminarJugadorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarJugadorToolStripMenuItem.Text = "Eliminar Jugador";
            this.eliminarJugadorToolStripMenuItem.Click += new System.EventHandler(this.eliminarJugadorToolStripMenuItem_Click);
            // 
            // modificarJugadorToolStripMenuItem
            // 
            this.modificarJugadorToolStripMenuItem.Name = "modificarJugadorToolStripMenuItem";
            this.modificarJugadorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarJugadorToolStripMenuItem.Text = "Modificar Jugador";
            this.modificarJugadorToolStripMenuItem.Click += new System.EventHandler(this.modificarJugadorToolStripMenuItem_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.33735F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.66265F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 462F));
            this.tableLayoutPanel.Controls.Add(this.panelIzq, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelCent, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.panelDer, 2, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1234, 758);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panelIzq
            // 
            this.panelIzq.Controls.Add(this.gvJugadores);
            this.panelIzq.Controls.Add(this.label1);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIzq.Location = new System.Drawing.Point(3, 3);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(336, 752);
            this.panelIzq.TabIndex = 0;
            // 
            // gvJugadores
            // 
            this.gvJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvJugadores.Location = new System.Drawing.Point(0, 31);
            this.gvJugadores.Name = "gvJugadores";
            this.gvJugadores.Size = new System.Drawing.Size(336, 721);
            this.gvJugadores.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jugadores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelCent
            // 
            this.panelCent.Controls.Add(this.gvLiga);
            this.panelCent.Controls.Add(this.label2);
            this.panelCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCent.Location = new System.Drawing.Point(345, 3);
            this.panelCent.Name = "panelCent";
            this.panelCent.Size = new System.Drawing.Size(423, 752);
            this.panelCent.TabIndex = 1;
            // 
            // gvLiga
            // 
            this.gvLiga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvLiga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLiga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvLiga.Location = new System.Drawing.Point(0, 31);
            this.gvLiga.Name = "gvLiga";
            this.gvLiga.Size = new System.Drawing.Size(423, 721);
            this.gvLiga.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Liga";
            // 
            // panelDer
            // 
            this.panelDer.Controls.Add(this.gvPartidos);
            this.panelDer.Controls.Add(this.label3);
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.Location = new System.Drawing.Point(774, 3);
            this.panelDer.Name = "panelDer";
            this.panelDer.Size = new System.Drawing.Size(457, 752);
            this.panelDer.TabIndex = 2;
            // 
            // gvPartidos
            // 
            this.gvPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPartidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPartidos.Location = new System.Drawing.Point(0, 31);
            this.gvPartidos.Name = "gvPartidos";
            this.gvPartidos.Size = new System.Drawing.Size(457, 721);
            this.gvPartidos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Partidos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1157, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 782);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1250, 818);
            this.Name = "Form1";
            this.Text = "Ping Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJugadores)).EndInit();
            this.panelCent.ResumeLayout(false);
            this.panelCent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLiga)).EndInit();
            this.panelDer.ResumeLayout(false);
            this.panelDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidos)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Panel panelCent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDer;
        private System.Windows.Forms.DataGridView gvPartidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvJugadores;
        private System.Windows.Forms.DataGridView gvLiga;
        private System.Windows.Forms.Button button2;
    }
}

