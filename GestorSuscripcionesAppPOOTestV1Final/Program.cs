using System.IO;
using GestorSuscripcionesAppPOOTestV1Final;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Gestor de Gastos | POO | TecNM Campus Monclova";
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("=== Sistema Virtual de Gestion de Gastos ===");
        Console.WriteLine();

        List<Suscripcion> ListaSuscripciones = new();

        ListaSuscripciones.Add(new Suscripcion("Beatstars", 359, DateTime.Now.AddDays(7)));
        ListaSuscripciones.Add(new Suscripcion("Netflix", 159, DateTime.Now.AddDays(15)));

        double totalGastosMensuales = 0;

        foreach (var item in ListaSuscripciones)
        {
            item.MostrarDetalles();
            totalGastosMensuales += item.PrecioMensual;
            if (item is INotificador notificador)
            {
                notificador.EnviarNotificacion("Tu suscripcion esta por renovarse.");
            }
            Console.WriteLine("====================================================");
        }
        Console.WriteLine($"Total de gastos mensuales: {totalGastosMensuales}");
    }
}