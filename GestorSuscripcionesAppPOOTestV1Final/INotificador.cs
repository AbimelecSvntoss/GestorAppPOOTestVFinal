using System;
using System.Collections.Generic;
using System.Text;

namespace GestorSuscripcionesAppPOOTestV1Final
{
    public interface INotificador
    {
        void EnviarNotificacion(string mensaje)
        {
            Console.WriteLine($"Notificación enviada: {mensaje}");
        }
    }
}
