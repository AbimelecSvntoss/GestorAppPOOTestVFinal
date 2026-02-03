using System;
using System.Collections.Generic;
using System.Text;

namespace GestorSuscripcionesAppPOOTestV1Final
{
    public class SPremium : Suscripcion, INotificador
    {
        public string BeneficiosAdicionales { get; set; }
        public SPremium(string nombre, double precioMensual, DateTime fechaCobro, string beneficiosAdicionales)
            : base(nombre, precioMensual, fechaCobro)
        {
            BeneficiosAdicionales = beneficiosAdicionales;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Beneficios Adicionales: {BeneficiosAdicionales}");
        }
        public void EnviarAlerta(string mensaje)
        {
            Console.WriteLine($"ALERTA PUSH!: {Nombre} dice {mensaje}");
        }
    }
}
