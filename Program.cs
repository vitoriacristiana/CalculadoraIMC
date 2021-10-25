using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)

        {
     Console.Clear();
     Double peso, altura, imc;

     Console.WriteLine("- - - Calculadora de massa corporal - - -\n");
     Console.WriteLine("--Digite a baixo seu peso e sua altura, por favor.\n");

     Console.Write("digite seu peso em Kg.:");
     peso = Convert.ToDouble(Console.ReadLine());

     Console.Write("digite sau altura em M: ");
     altura = Convert.ToDouble(Console.ReadLine());

     imc = (peso / Math.Pow(altura, 2));

     Console.WriteLine($"\nSeu IMC é {imc:N2} Kg/m²");
     Console.WriteLine(TipoObsidade(peso, altura, imc));
    }
    static string TipoObsidade(double peso, double altura, double imc)
     {
    imc = (peso / Math.Pow(altura, 2));
        
    if (imc < 17)
    {
     return "Diagnóstico: Muito abaixo do peso";
    }
    if (imc > 16 && imc < 18.50)

     {
     return "Diagnóstico: Abaixo do peso";
        }
     if (imc > 18.4 && imc < 25)
        {
    return "Diagnóstico: peso normal";

     }
    if (imc > 24 && imc < 30)
     {
    return "Diagnóstico: Acima do peso";
    }
    if (imc > 29 && imc < 35)

    {
    return "Diagnóstico: Obesidade I";
     }
    if (imc > 34 && imc < 40)
     {
     return "Diagnóstico: Obesidade II(severa)";
     }
    if (imc > 39 )

     {
    return "Diagnóstico: Obesidade III(mórbida)";
     }
    return "true";

     }
   }
}
    
