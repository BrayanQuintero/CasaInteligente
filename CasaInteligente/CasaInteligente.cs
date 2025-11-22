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

        private Color verdeON = Color.Green;
        private Color verdeOFF = Color.FromArgb(0, 64, 0);
        private Color amarilloON = Color.Yellow;
        private Color amarilloOFF = Color.Olive;
        private Color rojoON = Color.Red;
        private Color rojoOFF = Color.Maroon;
        public CasaInteligente()
        {
            InitializeComponent();

            // Seleccionar el puerto al conectar otro arduino u otro puerto
            arduino = new Arduino("COM4");
            arduino.DatosRecibidos += ActualizarUI;
            arduino.Abrir();

            // Configuracion del reloj en pantalla
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void ActualizarUI(Datos datos)
        {
            // Se ejecuta desde el hilo del puerto serie, usar BeginInvoke para la UI
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(() => ActualizarUI(datos)));
                return;
            }

            // Mostrar los datos en su etiqueta correspondiente
            lblHumedadPatio.Text = datos.humedadPatio;
            lblEstadoBomba.Text = datos.estadoBomba;

            lblTemperatura.Text = datos.temperatura;
            lblHumedadCuarto.Text = datos.humedadCuarto;
            lblEstadoAbanico.Text = datos.estadoAbanico;
            
            lblEstadoPuerta.Text = datos.estadoPuerta;
            lblIntentos.Text = datos.entrada;

            lblModoLed.Text = datos.modoLed;
            lblEstadoLed.Text = datos.estadoLed;

            lblEstadoAlarma.Text = datos.estadoAlarma;
            lblDistancia.Text = datos.distancia;
            lblDetectando.Text = datos.detectando;

            semaforo(datos);
        }

        // Cambia el color de los paneles dependiendo el valor leido, simulando el semaforo
        public void semaforo(Datos datos) {
            IRojo.BackColor = "ON".Equals(datos.iRojo) ? rojoON : rojoOFF;
            IAmarillo.BackColor = datos.iAmarillo.Equals("ON") ? amarilloON : amarilloOFF;
            IVerde.BackColor = datos.iVerde.Equals("ON") ? verdeON : verdeOFF;

            DRojo.BackColor = datos.dRojo.Equals("ON") ? rojoON : rojoOFF;
            DAmarillo.BackColor = datos.dAmarillo.Equals("ON") ? amarilloON : amarilloOFF;
            DVerde.BackColor = datos.dVerde.Equals("ON") ? verdeON : verdeOFF;

        }

        private void CasaInteligente_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            arduino.Cerrar();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Muestra la hora actual en el label
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss"); // 24 horas con minutos y segundos
        }
    }
}
