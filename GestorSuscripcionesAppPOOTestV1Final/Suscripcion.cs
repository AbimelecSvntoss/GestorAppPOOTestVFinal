using System;
using System.Collections.Generic;
using System.Text;

namespace GestorSuscripcionesAppPOOTestV1Final
{
    public class Suscripcion
    {
        public string Nombre { get; set; }
        public double PrecioMensual { get; set; }
        public DateTime FechaCobro { get; set; }

        public Suscripcion(string nombre, double precioMensual, DateTime fechaCobro)
        {
            Nombre = nombre;
            PrecioMensual = precioMensual;
            FechaCobro = fechaCobro;
        }
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Suscripción: {Nombre}, Precio Mensual: {PrecioMensual:C}, Fecha de Cobro: {FechaCobro.ToShortDateString()}");
        }
    }
}
