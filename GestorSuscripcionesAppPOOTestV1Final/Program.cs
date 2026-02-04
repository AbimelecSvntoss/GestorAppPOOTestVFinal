using System.IO;
using GestorSuscripcionesAppPOOTestV1Final;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "Gestor de Gastos POO TecNM Campus Monclova";

        Console.WriteLine("════════ Bienvenido al Gestor de Gastos POO ════════");
        Console.WriteLine("");

        Console.Write("Ingrese su suscripción: ");
        string nombreSuscripcion = Console.ReadLine();
        Console.WriteLine("════════════════════════════════════════════════════════════════════════════");

        Console.Write("Ingrese el costo mensual de la suscripción: ");
        double costoMensual = double.Parse(Console.ReadLine());
        Console.WriteLine("════════════════════════════════════════════════════════════════════════════");

        Console.Write("Ingrese la fecha de cobro (dd/mm/yyyy): ");
        DateTime fechaCobro = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("════════════════════════════════════════════════════════════════════════════");

        List<Suscripcion> ListaSuscripciones = new();

        ListaSuscripciones.Add(new Suscripcion(nombreSuscripcion, costoMensual, fechaCobro));

        /*
        ListaSuscripciones.Add(new Suscripcion("Beatstars", 359, DateTime.Now.AddDays(7)));
        ListaSuscripciones.Add(new Suscripcion("Netflix", 159, DateTime.Now.AddDays(15)));

        ListaSuscripciones.Add(new Suscripcion("TecNM", 2000, DateTime.Now.AddDays(20)));

        ListaSuscripciones.Add(new Suscripcion("Spotify", 129, DateTime.Now.AddDays(30)));
        */

        double totalGastosMensuales = 0;

        foreach (var item in ListaSuscripciones)
        {
            item.MostrarDetalles();
            totalGastosMensuales += item.PrecioMensual;
            if (item is INotificador notificador)
            {
                notificador.EnviarNotificacion("Tu suscripción esta por renovarse.");
            }
            Console.WriteLine("════════════════════════════════════════════════════════════════════════════");
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Total de gastos mensuales: ${totalGastosMensuales}");
    }
}