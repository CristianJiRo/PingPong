namespace PingPong
{
    partial class FormAddJugador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_ape1 = new System.Windows.Forms.TextBox();
            this.tb_ape2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(468, 267);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(124, 23);
            this.bt_aceptar.TabIndex = 0;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(632, 267);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(107, 23);
            this.bt_cancelar.TabIndex = 1;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(28, 60);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(319, 22);
            this.tb_name.TabIndex = 2;
            // 
            // tb_ape1
            // 
            this.tb_ape1.Location = new System.Drawing.Point(28, 141);
            this.tb_ape1.Name = "tb_ape1";
            this.tb_ape1.Size = new System.Drawing.Size(319, 22);
            this.tb_ape1.TabIndex = 3;
            // 
            // tb_ape2
            // 
            this.tb_ape2.Location = new System.Drawing.Point(28, 237);
            this.tb_ape2.Name = "tb_ape2";
            this.tb_ape2.Size = new System.Drawing.Size(319, 22);
            this.tb_ape2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Primer apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Segundo apellido";
            // 
            // pb_foto
            // 
            this.pb_foto.Location = new System.Drawing.Point(468, 19);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(271, 193);
            this.pb_foto.TabIndex = 8;
            this.pb_foto.TabStop = false;
            // 
            // FormAddJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 311);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ape2);
            this.Controls.Add(this.tb_ape1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(794, 358);
            this.MinimumSize = new System.Drawing.Size(794, 358);
            this.Name = "FormAddJugador";
            this.Text = "Añadir Jugador";
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_ape1;
        private System.Windows.Forms.TextBox tb_ape2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_foto;
    }
}