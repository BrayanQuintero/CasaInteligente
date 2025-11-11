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
        SerialPort puerto;
        public CasaInteligente()
        {
            InitializeComponent();
            puerto = new SerialPort
            {
                PortName = "COM16",      // 👈 Cambia esto por tu puerto real
                BaudRate = 9600,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None,
                ReadTimeout = 500,
                NewLine = "\n"
            };


            // Suscribirse al evento cuando llegan datos
            puerto.DataReceived += Puerto_DataReceived;

            try
            {
                puerto.Open();
                Console.WriteLine("Conectado al Arduino.\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con Arduino: " + ex.Message);
            }


        }


        public void humedad() {
            try
            {
                puerto.Open();
                Console.WriteLine("Conectado al Arduino.\n");

                while (true)
                {
                    string linea = puerto.ReadLine();
                    string[] datos = linea.Trim().Split(';');

                    if (datos.Length == 1)
                    {
                        int humedad = int.Parse(datos[0]);

                        this.lblHumedad.Text = humedad.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (puerto.IsOpen)
                    puerto.Close();
            }
        }

        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string linea = puerto.ReadLine();
                string[] datos = linea.Trim().Split(';');

                if (datos.Length >= 1)
                {
                    int humedad = int.Parse(datos[0]);

                    // ⚠️ Actualiza el control en el hilo principal
                    this.Invoke(new Action(() =>
                    {
                        lblHumedad.Text = humedad.ToString();
                    }));
                }
            }
            catch (TimeoutException)
            {
                // Ignorar si no llegan datos a tiempo
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer datos: " + ex.Message);
            }
        }

        private void CasaInteligente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (puerto != null && puerto.IsOpen)
                puerto.Close();
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
            if (puerto != null && puerto.IsOpen)
                puerto.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
