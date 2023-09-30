using System;

class EjercicioLab2
{
    static void Main(string[]arg)
    {

        Console.Write("Ingrese la coordenada x del punto 1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la coordenada y del punto 1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la coordenada x del punto 2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la coordenada y del punto 2: ");
        double y2 = double.Parse(Console.ReadLine());

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"La distancia entre los puntos ({x1}, {y1}) y ({x2}, {y2}) es: {distancia}");
    }
}
