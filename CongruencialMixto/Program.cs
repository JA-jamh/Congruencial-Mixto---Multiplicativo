using System;

int n, a, c, m, x0, x1;

Console.WriteLine("                  METODO CONGRUENCIAL MIXTO\n");

n = entradaValida("Cual es la cantidad de numeros aleatorios que se desea generar: "); /*Console.Write("Cual es la cantidad de numeros aleatorios que se desea generar: ");
                                                                                            n = int.Parse(Console.ReadLine());*/

double[] x = new double[n + 1];

Console.Write("Proporciona el valor del parametro a: ");
a = int.Parse(Console.ReadLine());

Console.Write("Proporciona el valor del parametro c: ");
c = int.Parse(Console.ReadLine());

Console.Write("Proporciona el valor del parametro m: ");
m = int.Parse(Console.ReadLine());

Console.Write("Proporciona el valor del parametro X0: ");
x0 = int.Parse(Console.ReadLine());

Console.WriteLine("\n          n          Xn          Xn+1          Rn+1");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

// Proceso iterativo
for (int i = 0; i <= n; i++)
{
    x1 = (a * x0 + c) % m;
    double r = (double)x1 / m;
    x[i] = r;
    Console.WriteLine($"{i + 0,11} {x0,10} {x1,12} {r,16:F4}");
    x0 = x1;
}
double promedio = x.Average();
double varianza = x.Sum(val => Math.Pow(val - promedio, 2)) / n;

Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
Console.WriteLine($"Promedio (debe ser proximo a 1/2) = {promedio,8:F4}");
Console.WriteLine($"Varianza (debe ser próxima a 1/12) = {varianza,8:F4}");

static int entradaValida(string message)
{
int resultado;
while (true)
    {
        Console.Write(message);
        string entrada = Console.ReadLine();
        try
        {
            resultado = int.Parse(entrada);
            return resultado; //Si la conversión se realiza correctamente, devolvera el resultado
        }
        catch (FormatException)
        {
            Console.WriteLine("Letras, símbolos o espacios en blanco no son caracteres validos. Intentelo de nuevo.\n");
        }
    }
}
