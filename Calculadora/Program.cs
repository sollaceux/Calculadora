using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operação que deseja fazer: ");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão \n");

            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = 0;

            switch (operation)
            {
                case 1:
                    {
                        result = Addition(number1, number2);
                        break;
                    }

                case 2:
                    {
                        result = Subtraction(number1, number2);
                        break;
                    }

                case 3:
                    {
                        result = Multiplication(number1, number2);
                        break;
                    }
                case 4:
                    {
                        result = Division(number1, number2);
                        break;
                    }

                default:
                    Console.WriteLine("Número inválido, digite outro número. ");
                    break;
            }

            Console.WriteLine(" O resultado da operação com os números {0} e {1} é: {2}", number1, number2, result);

            Console.ReadLine();

        }


        // criando variável local apenas para armazenar nas condições acima. s
        public static int Addition(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        public static int Subtraction(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }

        public static int Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }

        public static int Division(int number1, int number2)
        {
            int result = number1 / number2;
            return result;
        }
    }
}

