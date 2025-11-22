using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace CasaInteligente
{
    public class Arduino
    {
        private SerialPort puerto;
        private Thread hiloLectura;
        private bool continuar = false;

        // Evento que notificará al formulario cuando lleguen datos nuevos
        public event Action<Datos> DatosRecibidos;

        public Arduino(string puertoNombre, int baudRate = 9600)
        {
            puerto = new SerialPort(puertoNombre, baudRate);
        }

        public void Abrir()
        {
            if (!puerto.IsOpen)
            {
                puerto.Open();
                Thread.Sleep(2000); // Esperar a que Arduino se estabilice
            }

            continuar = true;

            hiloLectura = new Thread(LeerPuerto);
            hiloLectura.IsBackground = true;
            hiloLectura.Start();
        }

        private void LeerPuerto()
        {
            while (continuar)
            {
                try
                {
                    string linea = puerto.ReadLine().Trim();

                    // Filtrar líneas no JSON
                    if (!linea.StartsWith("{")) continue;

                    // Convertir el JSON mandado desde arduino a la clase Datos
                    var datos = JsonSerializer.Deserialize<Datos>(linea);
                    DatosRecibidos?.Invoke(datos); // Notificar al formulario

                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error ArduinoSerial: " + ex.Message);
                }
            }
        }

        public void Cerrar()
        {
            continuar = false;
            if (puerto.IsOpen) puerto.Close();
        }
    }
}
