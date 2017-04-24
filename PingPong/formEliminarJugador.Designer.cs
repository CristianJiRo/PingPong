namespace PingPong
{
    partial class FormEliminarJugador
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
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(24, 82);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(639, 24);
            this.cb_item.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona un jugador";
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(338, 219);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(132, 46);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Eliminar";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(531, 219);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(132, 46);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // FormEliminarJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 311);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_item);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(794, 358);
            this.MinimumSize = new System.Drawing.Size(794, 358);
            this.Name = "FormEliminarJugador";
            this.Text = "Eliminar Jugador";
            this.Load += new System.EventHandler(this.FormEliminarJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_cancel;
    }
}