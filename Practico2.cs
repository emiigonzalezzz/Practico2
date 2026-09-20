using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2
{
    public class Practico2
    {
        public static void Ejercicio11()
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
        }
        public static void Ejercicio12()
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
        }
        public static void Ejercicio13()
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par ");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
        public static void Ejercicio14()
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 18)
            {
                Console.WriteLine("Es mayor");
            }
            else
            {
                Console.WriteLine("Es menor");
            }
        }
        public static void Ejercicio15()
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num > num2)
            {
                Console.WriteLine("El numero mayor es: " + num);
            }
            else
            {
                Console.WriteLine("El numero mayor es " + num2);
            }
        }
        public static void Ejercicio16()
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("El numero es multiplo de 5");
            }
            else
            {
                Console.WriteLine("El numero no es multiplo de 5");
            }
        }
        public static void Ejercicio17()
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 100)
            {
                Console.WriteLine("El numero es mayor a 100");
            }
            else
            {
                Console.WriteLine("El numero es menor a 100");
            }
        }
        public static void Ejercicio18()
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 6)
            {
                Console.WriteLine("Aprobaste");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
        }
        public static void Ejercicio19()
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 10 && num < 20)
            {
                Console.WriteLine("El numero esta entre 10 y 20");
            }
            else
            {
                Console.WriteLine("El numero no esta entre 10 y 20");
            }
        }
        public static void Ejercicio20()
        {
            Console.Write("Ingrese una letra: ");
            char letra = char.Parse(Console.ReadLine());
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Console.WriteLine("La letra es una vocal");
            }
            else
            {
                Console.WriteLine("La letra no es una vocal");
            }
    }   }
}
