namespace CasaInteligente
{
    partial class CasaInteligente
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
            this.Calle = new System.Windows.Forms.Panel();
            this.DSemaforo = new System.Windows.Forms.Panel();
            this.DFondo = new System.Windows.Forms.Panel();
            this.DAmarillo = new System.Windows.Forms.Panel();
            this.DRojo = new System.Windows.Forms.Panel();
            this.DVerde = new System.Windows.Forms.Panel();
            this.ISemaforo = new System.Windows.Forms.Panel();
            this.IFondo = new System.Windows.Forms.Panel();
            this.IAmarillo = new System.Windows.Forms.Panel();
            this.IRojo = new System.Windows.Forms.Panel();
            this.IVerde = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInformaciónHumedad = new System.Windows.Forms.Label();
            this.lblRiego = new System.Windows.Forms.Label();
            this.lblEstadoBomba = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.temperatura = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.Calle.SuspendLayout();
            this.DSemaforo.SuspendLayout();
            this.DFondo.SuspendLayout();
            this.ISemaforo.SuspendLayout();
            this.IFondo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calle
            // 
            this.Calle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Calle.Controls.Add(this.DSemaforo);
            this.Calle.Controls.Add(this.ISemaforo);
            this.Calle.Location = new System.Drawing.Point(-2, 382);
            this.Calle.Margin = new System.Windows.Forms.Padding(0);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(891, 153);
            this.Calle.TabIndex = 0;
            // 
            // DSemaforo
            // 
            this.DSemaforo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DSemaforo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.DSemaforo.Controls.Add(this.DFondo);
            this.DSemaforo.Location = new System.Drawing.Point(818, 0);
            this.DSemaforo.Margin = new System.Windows.Forms.Padding(0);
            this.DSemaforo.Name = "DSemaforo";
            this.DSemaforo.Size = new System.Drawing.Size(67, 153);
            this.DSemaforo.TabIndex = 5;
            // 
            // DFondo
            // 
            this.DFondo.BackColor = System.Drawing.Color.Black;
            this.DFondo.Controls.Add(this.DAmarillo);
            this.DFondo.Controls.Add(this.DRojo);
            this.DFondo.Controls.Add(this.DVerde);
            this.DFondo.Location = new System.Drawing.Point(6, 12);
            this.DFondo.Margin = new System.Windows.Forms.Padding(0);
            this.DFondo.Name = "DFondo";
            this.DFondo.Size = new System.Drawing.Size(55, 129);
            this.DFondo.TabIndex = 4;
            // 
            // DAmarillo
            // 
            this.DAmarillo.BackColor = System.Drawing.Color.Olive;
            this.DAmarillo.Location = new System.Drawing.Point(7, 45);
            this.DAmarillo.Margin = new System.Windows.Forms.Padding(0);
            this.DAmarillo.Name = "DAmarillo";
            this.DAmarillo.Size = new System.Drawing.Size(42, 39);
            this.DAmarillo.TabIndex = 3;
            // 
            // DRojo
            // 
            this.DRojo.BackColor = System.Drawing.Color.Maroon;
            this.DRojo.Location = new System.Drawing.Point(7, 85);
            this.DRojo.Margin = new System.Windows.Forms.Padding(0);
            this.DRojo.Name = "DRojo";
            this.DRojo.Size = new System.Drawing.Size(42, 39);
            this.DRojo.TabIndex = 3;
            // 
            // DVerde
            // 
            this.DVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DVerde.Location = new System.Drawing.Point(7, 5);
            this.DVerde.Margin = new System.Windows.Forms.Padding(0);
            this.DVerde.Name = "DVerde";
            this.DVerde.Size = new System.Drawing.Size(42, 39);
            this.DVerde.TabIndex = 2;
            // 
            // ISemaforo
            // 
            this.ISemaforo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ISemaforo.Controls.Add(this.IFondo);
            this.ISemaforo.Location = new System.Drawing.Point(3, 0);
            this.ISemaforo.Margin = new System.Windows.Forms.Padding(0);
            this.ISemaforo.Name = "ISemaforo";
            this.ISemaforo.Size = new System.Drawing.Size(67, 153);
            this.ISemaforo.TabIndex = 1;
            // 
            // IFondo
            // 
            this.IFondo.BackColor = System.Drawing.Color.Black;
            this.IFondo.Controls.Add(this.IAmarillo);
            this.IFondo.Controls.Add(this.IRojo);
            this.IFondo.Controls.Add(this.IVerde);
            this.IFondo.Location = new System.Drawing.Point(6, 12);
            this.IFondo.Margin = new System.Windows.Forms.Padding(0);
            this.IFondo.Name = "IFondo";
            this.IFondo.Size = new System.Drawing.Size(55, 129);
            this.IFondo.TabIndex = 4;
            // 
            // IAmarillo
            // 
            this.IAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.IAmarillo.Location = new System.Drawing.Point(7, 45);
            this.IAmarillo.Margin = new System.Windows.Forms.Padding(0);
            this.IAmarillo.Name = "IAmarillo";
            this.IAmarillo.Size = new System.Drawing.Size(42, 39);
            this.IAmarillo.TabIndex = 3;
            // 
            // IRojo
            // 
            this.IRojo.BackColor = System.Drawing.Color.Red;
            this.IRojo.Location = new System.Drawing.Point(7, 85);
            this.IRojo.Margin = new System.Windows.Forms.Padding(0);
            this.IRojo.Name = "IRojo";
            this.IRojo.Size = new System.Drawing.Size(42, 39);
            this.IRojo.TabIndex = 3;
            this.IRojo.Paint += new System.Windows.Forms.PaintEventHandler(this.IRojo_Paint);
            // 
            // IVerde
            // 
            this.IVerde.BackColor = System.Drawing.Color.Green;
            this.IVerde.Location = new System.Drawing.Point(7, 5);
            this.IVerde.Margin = new System.Windows.Forms.Padding(0);
            this.IVerde.Name = "IVerde";
            this.IVerde.Size = new System.Drawing.Size(42, 39);
            this.IVerde.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.97891F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.02109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 378);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(592, 192);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(287, 183);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(286, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 183);
            this.panel6.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Alarma Perimetral Antirrobo";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 192);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 183);
            this.panel5.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Iluminación Inteligente";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(592, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 183);
            this.panel4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sistema de Acceso y Seguridad";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.lblTemp);
            this.panel3.Controls.Add(this.temperatura);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(286, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 183);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Control de Climatización";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.lblInformaciónHumedad);
            this.panel2.Controls.Add(this.lblRiego);
            this.panel2.Controls.Add(this.lblEstadoBomba);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblHumedad);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 183);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblInformaciónHumedad
            // 
            this.lblInformaciónHumedad.AutoSize = true;
            this.lblInformaciónHumedad.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformaciónHumedad.Location = new System.Drawing.Point(18, 29);
            this.lblInformaciónHumedad.Name = "lblInformaciónHumedad";
            this.lblInformaciónHumedad.Size = new System.Drawing.Size(242, 14);
            this.lblInformaciónHumedad.TabIndex = 5;
            this.lblInformaciónHumedad.Text = "Humedad baja: >750    Humedad alta: <250";
            // 
            // lblRiego
            // 
            this.lblRiego.AutoSize = true;
            this.lblRiego.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiego.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRiego.Location = new System.Drawing.Point(3, 5);
            this.lblRiego.Name = "lblRiego";
            this.lblRiego.Size = new System.Drawing.Size(272, 21);
            this.lblRiego.TabIndex = 4;
            this.lblRiego.Text = "Riego Automatizado de Jardín";
            this.lblRiego.Click += new System.EventHandler(this.lblRiego_Click);
            // 
            // lblEstadoBomba
            // 
            this.lblEstadoBomba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadoBomba.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoBomba.Location = new System.Drawing.Point(166, 126);
            this.lblEstadoBomba.Name = "lblEstadoBomba";
            this.lblEstadoBomba.Size = new System.Drawing.Size(87, 34);
            this.lblEstadoBomba.TabIndex = 3;
            this.lblEstadoBomba.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Bomba:";
            // 
            // lblHumedad
            // 
            this.lblHumedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHumedad.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.Location = new System.Drawing.Point(166, 71);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(87, 34);
            this.lblHumedad.TabIndex = 1;
            this.lblHumedad.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Humedad: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 378);
            this.panel1.TabIndex = 2;
            // 
            // temperatura
            // 
            this.temperatura.AutoSize = true;
            this.temperatura.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatura.Location = new System.Drawing.Point(21, 84);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(131, 21);
            this.temperatura.TabIndex = 6;
            this.temperatura.Text = "Temperatura: ";
            this.temperatura.Click += new System.EventHandler(this.temperatura_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(158, 84);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 21);
            this.lblTemp.TabIndex = 7;
            // 
            // CasaInteligente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Calle);
            this.Name = "CasaInteligente";
            this.Text = "Casa Inteligente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CasaInteligente_FormClosing_1);
            this.Calle.ResumeLayout(false);
            this.DSemaforo.ResumeLayout(false);
            this.DFondo.ResumeLayout(false);
            this.ISemaforo.ResumeLayout(false);
            this.IFondo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Calle;
        private System.Windows.Forms.Panel ISemaforo;
        private System.Windows.Forms.Panel IRojo;
        private System.Windows.Forms.Panel IAmarillo;
        private System.Windows.Forms.Panel IVerde;
        private System.Windows.Forms.Panel IFondo;
        private System.Windows.Forms.Panel DSemaforo;
        private System.Windows.Forms.Panel DFondo;
        private System.Windows.Forms.Panel DAmarillo;
        private System.Windows.Forms.Panel DRojo;
        private System.Windows.Forms.Panel DVerde;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEstadoBomba;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRiego;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblInformaciónHumedad;
        private System.Windows.Forms.Label temperatura;
        private System.Windows.Forms.Label lblTemp;
    }
}

