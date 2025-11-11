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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstadoBomba = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Calle.SuspendLayout();
            this.DSemaforo.SuspendLayout();
            this.DFondo.SuspendLayout();
            this.ISemaforo.SuspendLayout();
            this.IFondo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
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
            this.panel7.Location = new System.Drawing.Point(594, 192);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(285, 183);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(287, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(301, 183);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 192);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(278, 183);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(594, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 183);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl);
            this.panel3.Controls.Add(this.lblTemperatura);
            this.panel3.Location = new System.Drawing.Point(287, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 183);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.lblEstadoBomba);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblHumedad);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 183);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Humedad: ";
            // 
            // lblHumedad
            // 
            this.lblHumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.Location = new System.Drawing.Point(130, 70);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(135, 34);
            this.lblHumedad.TabIndex = 1;
            this.lblHumedad.Text = " ";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(20, 39);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(134, 25);
            this.lblTemperatura.TabIndex = 1;
            this.lblTemperatura.Text = "Temperatura";
            this.lblTemperatura.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Bomba";
            // 
            // lblEstadoBomba
            // 
            this.lblEstadoBomba.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoBomba.Location = new System.Drawing.Point(166, 126);
            this.lblEstadoBomba.Name = "lblEstadoBomba";
            this.lblEstadoBomba.Size = new System.Drawing.Size(87, 34);
            this.lblEstadoBomba.TabIndex = 3;
            this.lblEstadoBomba.Text = " ";
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(160, 39);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(135, 34);
            this.lbl.TabIndex = 2;
            this.lbl.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado abanico";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Estado Puerta";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 34);
            this.label6.TabIndex = 3;
            this.label6.Text = " ";
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
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEstadoBomba;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
    }
}

