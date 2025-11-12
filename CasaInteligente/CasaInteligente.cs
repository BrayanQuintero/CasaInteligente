using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaInteligente
{
    public partial class CasaInteligente : Form
    {
        private Arduino arduino;
        public CasaInteligente()
        {
            InitializeComponent();
            arduino = new Arduino("COM7");
            arduino.DatosRecibidos += ActualizarUI;
            arduino.Abrir();
        }

        private void ActualizarUI(Datos datos)
        {
            // Se ejecuta desde el hilo del puerto serie, usar BeginInvoke para la UI
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(() => ActualizarUI(datos)));
                return;
            }

            lblEstadoBomba.Text = datos.estadoBomba;
            lblHumedad.Text = datos.humedad;
            lblTemp.Text = datos.temperatura;
            //lblHumedadCuarto.Text = $"Humedad Cuarto: {datos.humedadCuarto}";
            //lblBomba.Text = $"Estado Bomba: {datos.estadoBomba}";
            //lblVentilador.Text = $"Estado Ventilador: {datos.estadoVentilador}";
        }


        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {

        }

        private void ConnectToArduino(string portName)
        {
        }
        private void IRojo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DRojo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //humedad();
        }

        private void CasaInteligente_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            arduino.Cerrar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRiego_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void temperatura_Click(object sender, EventArgs e)
        {

        }
    }
}
