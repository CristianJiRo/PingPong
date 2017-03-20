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
            this.panelDer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_jug = new System.Windows.Forms.ListView();
            this.lv_liga = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelIzq.SuspendLayout();
            this.panelDer.SuspendLayout();
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
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.86634F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.13366F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel.Controls.Add(this.panelIzq, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelDer, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1227, 757);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panelIzq
            // 
            this.panelIzq.Controls.Add(this.lv_jug);
            this.panelIzq.Controls.Add(this.label1);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIzq.Location = new System.Drawing.Point(3, 3);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(384, 751);
            this.panelIzq.TabIndex = 0;
            // 
            // panelDer
            // 
            this.panelDer.Controls.Add(this.lv_liga);
            this.panelDer.Controls.Add(this.label2);
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.Location = new System.Drawing.Point(393, 3);
            this.panelDer.Name = "panelDer";
            this.panelDer.Size = new System.Drawing.Size(831, 751);
            this.panelDer.TabIndex = 1;
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
            // lv_jug
            // 
            this.lv_jug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_jug.Location = new System.Drawing.Point(0, 31);
            this.lv_jug.Name = "lv_jug";
            this.lv_jug.Size = new System.Drawing.Size(384, 720);
            this.lv_jug.TabIndex = 1;
            this.lv_jug.UseCompatibleStateImageBehavior = false;
            // 
            // lv_liga
            // 
            this.lv_liga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_liga.Location = new System.Drawing.Point(0, 31);
            this.lv_liga.Name = "lv_liga";
            this.lv_liga.Size = new System.Drawing.Size(831, 720);
            this.lv_liga.TabIndex = 1;
            this.lv_liga.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 781);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ping Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            this.panelDer.ResumeLayout(false);
            this.panelDer.PerformLayout();
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
        private System.Windows.Forms.Panel panelDer;
        private System.Windows.Forms.ListView lv_jug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_liga;
        private System.Windows.Forms.Label label2;
    }
}

