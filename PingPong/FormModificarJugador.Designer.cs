namespace PingPong
{
    partial class FormModificarJugador
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
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.bt_selec = new System.Windows.Forms.Button();
            this.tb_ape2 = new System.Windows.Forms.TextBox();
            this.tb_ape1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(23, 52);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(639, 24);
            this.cb_item.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona jugador:";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Enabled = false;
            this.tb_nombre.Location = new System.Drawing.Point(23, 195);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(217, 22);
            this.tb_nombre.TabIndex = 2;
            // 
            // bt_selec
            // 
            this.bt_selec.Location = new System.Drawing.Point(689, 53);
            this.bt_selec.Name = "bt_selec";
            this.bt_selec.Size = new System.Drawing.Size(75, 23);
            this.bt_selec.TabIndex = 3;
            this.bt_selec.Text = "Modificar";
            this.bt_selec.UseVisualStyleBackColor = true;
            this.bt_selec.Click += new System.EventHandler(this.bt_selec_Click);
            // 
            // tb_ape2
            // 
            this.tb_ape2.Enabled = false;
            this.tb_ape2.Location = new System.Drawing.Point(547, 195);
            this.tb_ape2.Name = "tb_ape2";
            this.tb_ape2.Size = new System.Drawing.Size(217, 22);
            this.tb_ape2.TabIndex = 4;
            // 
            // tb_ape1
            // 
            this.tb_ape1.Enabled = false;
            this.tb_ape1.Location = new System.Drawing.Point(280, 195);
            this.tb_ape1.Name = "tb_ape1";
            this.tb_ape1.Size = new System.Drawing.Size(217, 22);
            this.tb_ape1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(20, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(277, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Primer apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(544, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Segundo apellido";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(445, 259);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(123, 40);
            this.bt_save.TabIndex = 9;
            this.bt_save.Text = "Guardar";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(641, 259);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(123, 40);
            this.bt_cancel.TabIndex = 10;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(20, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Introduce los nuevos datos:";
            // 
            // FormModificarJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ape1);
            this.Controls.Add(this.tb_ape2);
            this.Controls.Add(this.bt_selec);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_item);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(794, 358);
            this.MinimumSize = new System.Drawing.Size(794, 358);
            this.Name = "FormModificarJugador";
            this.Text = "Modificar Jugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Button bt_selec;
        private System.Windows.Forms.TextBox tb_ape2;
        private System.Windows.Forms.TextBox tb_ape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label5;
    }
}