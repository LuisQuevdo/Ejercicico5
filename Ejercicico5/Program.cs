using System;

class Ejercicio5
{
    static void Main()
    {
        // Ejercicio 1: Suma de dos números
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int suma = Sumar(num1, num2);
        Console.WriteLine($"La suma de {num1} y {num2} es: {suma}\n");

        // Ejercicio 2: Invertir un string
        Console.Write("Ingrese una palabra o frase para invertir: ");
        string texto = Console.ReadLine();
        Console.WriteLine("Texto invertido: " + InvertirTexto(texto) + "\n");

        // Ejercicio 3: Determinar si un número es par o impar
        Console.Write("Ingrese un número para determinar si es par o impar: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(EsParOImpar(numero) + "\n");

        // Ejercicio 4: Cálculo del área de un rectángulo
        Console.Write("Ingrese la base del rectángulo: ");
        double baseRectangulo = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la altura del rectángulo: ");
        double alturaRectangulo = double.Parse(Console.ReadLine());

        double area = AreaRectangulo(baseRectangulo, alturaRectangulo);
        Console.WriteLine($"El área del rectángulo es: {area}");
    }

    // Método para sumar dos números
    static int Sumar(int a, int b)
    {
        return a + b;
    }

    // Método para invertir un texto
    static string InvertirTexto(string texto)
    {
        char[] array = texto.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    // Método para determinar si un número es par o impar
    static string EsParOImpar(int numero)
    {
        return (numero % 2 == 0) ? "El número es par." : "El número es impar.";
    }

    // Método para calcular el área de un rectángulo
    static double AreaRectangulo(double baseR, double alturaR)
    {
        return baseR * alturaR;
    }
}

