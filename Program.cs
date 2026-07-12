using System;

class Program
{
    // 1. Suma de 2 números
    static int Suma(int a, int b)
    {
        return a + b;
    }

    // 2. Verificar si es mayor de edad
    static string MayorEdad(int edad)
    {
        if (edad >= 18)
            return "Es mayor de edad";
        else
            return "Es menor de edad";
    }

    // 3. Área de un círculo
    static double AreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }

    // 4. Área de un triángulo
    static double AreaTriangulo(double baseTri, double altura)
    {
        return (baseTri * altura) / 2;
    }

    static void Main()
    {
        Console.WriteLine("--- PRUEBA DE FUNCIONES ---");

        Console.Write("Ingresa el primer número para sumar: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el segundo número para sumar: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"La suma es: {Suma(num1, num2)}\n");

        Console.Write("Ingresa una edad: ");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine($"{MayorEdad(edad)}\n");

        Console.Write("Ingresa el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());
        Console.WriteLine($"El área del círculo es: {AreaCirculo(radio):F2}\n");

        Console.Write("Ingresa la base del triángulo: ");
        double baseT = double.Parse(Console.ReadLine());
        Console.Write("Ingresa la altura del triángulo: ");
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine($"El área del triángulo es: {AreaTriangulo(baseT, altura):F2}");
    }
}
