using System; 

class Ejercicio2Lab2
{
    static void Main()
    {
        DateTime fechaActual = DateTime.Now;

        int diaActual = fechaActual.Day;
        int mesActual = fechaActual.Month;
        int añoActual = fechaActual.Year;

        DateTime navidad = new DateTime(añoActual, 12, 25);
        DateTime añoNuevo = new DateTime(añoActual + 1, 1, 1);
        TimeSpan tiempoHastaNavidad = navidad - fechaActual;
        TimeSpan tiempoHastaAñoNuevo = añoNuevo - fechaActual;

        int diasParaNavidad = tiempoHastaNavidad.Days;
        int diasParaAñoNuevo = tiempoHastaAñoNuevo.Days;

        Console.WriteLine("Día actual: " + diaActual);
        Console.WriteLine("Mes actual: " + mesActual);
        Console.WriteLine("Año actual: " + añoActual);
        Console.WriteLine("Días faltan para Navidad: " + diasParaNavidad);
        Console.WriteLine("Días faltan para Año Nuevo: " + diasParaAñoNuevo);
    }







}







