using System;

namespace Numeros
{
    class Numeros
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("HOLA MUNDO!!!");
            int num1 = 5;
            int num2 = 6;
            double num3 = 2.57;
            double suma;
            suma = num1 + num3;

            Console.WriteLine(suma);
            Console.WriteLine("Por favor escriba un numero:");

            string valor1 = Console.ReadLine();
            Console.WriteLine("El numero introducido es: " + valor1);

            try
            {
                int valorint = Convert.ToInt32(valor1);
                if (valorint < Int32.MaxValue)
                {
                    Console.WriteLine("El numero introducido convertido a entero es: {0}", valorint);
                }
                else
                {
                    Console.WriteLine("El numero que ingreso es demasiado grande");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lo que usted ha ingresado no es un numero entero.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Parece que el numero que ha ingresado es muy grande.");
            }

            Console.ReadKey();
        }
    }
}
