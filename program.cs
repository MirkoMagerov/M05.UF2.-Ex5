using System;

namespace Program
{
    class MultiOptionalApp
    {
        static void Main()
        {
            const string MsgIndicateOption = "Escribe la letra que aparece al lado de cada opción para elegirla.";
            const string MsgOptions = "a. Validar si un nombre és senar\nb. Calcular la potència d'un nombre\nc. Retornar un valor aleatori\nd. Comptar el nombre de vocals o consonants en un text\ne. Sortir";
            const string MsgUserElection = "Tu elección: ";
            const string MsgOptionASelected = "Has elegido la opción 'a'. Introduce un número para validar si es impar: ";
            const string MsgIsOddNumber = "El {0} es un número impar.";
            const string MsgIsNotOddNumber = "El {0} no es un número impar";
            const string MsgOptionBSelected = "Has elegido la opción 'b', calcular la poténcia de un número.";
            const string MsgWriteBase = "Escribe la base: ";
            const string MsgWriteExp = "Escribe el exponente: ";
            const string MsgOptionCSelected = "Has elegido la opción 'c', devolver un número aleatorio dentro de un rango.";
            const string MsgMinValue = "Escribe el valor mínimo del valor aleatorio: ";
            const string MsgMaxvalue = "Escribe el valor máximo del valor aleatorio: ";
            const string MsgRandomNumber = "El número aleatorio escogido entre {0} y {1} es {2}.";
            const string MsgOptionDSelected = "Has elegido la opción 'd', contar el número de letras o consonantes en un texto.";
            const string MsgUserText = "Escribe un texto: ";
            const string MsgVocalesYConsonantes = "El texto tiene {0} vocales y {1} consonantes.";
            const string MsgOptionESelected = "Has elegido la opción 'e'. Salir del programa.";

            string userElection;

            Console.WriteLine(MsgIndicateOption);

            do
            {
                Console.WriteLine(MsgOptions);
                Console.Write(MsgUserElection);
                userElection = Console.ReadLine() ?? "".Trim();
                userElection = userElection.ToLower();

            } while (!IsUserValidElection(userElection));

            Console.WriteLine();

            switch (userElection)
            {
                case "a":
                    int number;

                    do
                    {
                        Console.Write(MsgOptionASelected);
                        number = Convert.ToInt32(Console.ReadLine());

                    } while (!IsNaturalNumber(number));

                    if (IsOddNumber(number))
                    {
                        Console.WriteLine(MsgIsOddNumber, number);
                    }
                    else
                    {
                        Console.WriteLine(MsgIsNotOddNumber, number);
                    }

                    break;

                case "b":
                    int baseNumber, expNumber;

                    Console.WriteLine(MsgOptionBSelected);
                    do
                    {
                        Console.Write(MsgWriteBase);
                        baseNumber = Convert.ToInt32(Console.ReadLine());

                    } while (!IsNaturalNumber(baseNumber));

                    do
                    {
                        Console.Write(MsgWriteExp);
                        expNumber = Convert.ToInt32(Console.ReadLine());

                    } while (!IsNaturalNumber(expNumber));

                    Console.WriteLine(CalculatePow(baseNumber, expNumber));

                    break;

                case "e":
                    Console.WriteLine(MsgOptionESelected);
                    break;
            }
        }

        public static bool IsUserValidElection(string userElection)
        {
            bool validElection;

            const string optionA = "a", optionB = "b", optionC = "c", optionD = "d", optionE = "e";

            if (userElection == optionA || userElection == optionB || userElection == optionC || userElection == optionD || userElection == optionE)
            {
                validElection = true;
            }
            else
            {
                validElection = false;
            }

            return validElection;
        }

        public static bool IsNaturalNumber(int number)
        {
            return number > 0;
        }

        public static bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        public static int CalculatePow(int baseNumber, int expNumber)
        {
            int pow = 1;

            for (int i = expNumber; i > 0; i--)
            {
                pow *= baseNumber;
            }

            return pow;
        }
    }
}