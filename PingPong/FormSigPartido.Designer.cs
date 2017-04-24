namespace PingPong
{
    partial class FormSigPartido
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
            this.cb_partido = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_p1 = new System.Windows.Forms.TextBox();
            this.tb_p2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_tot1 = new System.Windows.Forms.TextBox();
            this.tb_tot2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_partido
            // 
            this.cb_partido.FormattingEnabled = true;
            this.cb_partido.Location = new System.Drawing.Point(34, 51);
            this.cb_partido.Name = "cb_partido";
            this.cb_partido.Size = new System.Drawing.Size(320, 24);
            this.cb_partido.TabIndex = 0;
            this.cb_partido.SelectedIndexChanged += new System.EventHandler(this.cb_partido_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona Partido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // tb_p1
            // 
            this.tb_p1.Location = new System.Drawing.Point(34, 163);
            this.tb_p1.Name = "tb_p1";
            this.tb_p1.Size = new System.Drawing.Size(127, 22);
            this.tb_p1.TabIndex = 4;
            this.tb_p1.Visible = false;
            // 
            // tb_p2
            // 
            this.tb_p2.Location = new System.Drawing.Point(233, 163);
            this.tb_p2.Name = "tb_p2";
            this.tb_p2.Size = new System.Drawing.Size(121, 22);
            this.tb_p2.TabIndex = 5;
            this.tb_p2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sets";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sets";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Puntuacion total";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Puntuacion total";
            this.label8.Visible = false;
            // 
            // tb_tot1
            // 
            this.tb_tot1.Location = new System.Drawing.Point(37, 252);
            this.tb_tot1.Name = "tb_tot1";
            this.tb_tot1.Size = new System.Drawing.Size(127, 22);
            this.tb_tot1.TabIndex = 13;
            this.tb_tot1.Visible = false;
            // 
            // tb_tot2
            // 
            this.tb_tot2.Location = new System.Drawing.Point(233, 252);
            this.tb_tot2.Name = "tb_tot2";
            this.tb_tot2.Size = new System.Drawing.Size(127, 22);
            this.tb_tot2.TabIndex = 14;
            this.tb_tot2.Visible = false;
            // 
            // FormSigPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 311);
            this.Controls.Add(this.tb_tot2);
            this.Controls.Add(this.tb_tot1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_p2);
            this.Controls.Add(this.tb_p1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_partido);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(794, 358);
            this.MinimumSize = new System.Drawing.Size(794, 358);
            this.Name = "FormSigPartido";
            this.Text = "Siguiente Partido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_partido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_p1;
        private System.Windows.Forms.TextBox tb_p2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_tot1;
        private System.Windows.Forms.TextBox tb_tot2;
    }
}