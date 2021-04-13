using System;


namespace Proyecto1
{
    class Program
    {
        static Validaciones Validar = new Validaciones();
        static void Main(string[] args)
        {
            
            int opc;
            string aux;

            do
            {
                bool seguir = false;
                Console.Clear();
                Console.SetCursorPosition(40, 3); Console.Write("Menú principal");
                Console.SetCursorPosition(40, 6); Console.Write("1. punto 1");
                Console.SetCursorPosition(40, 8); Console.Write("2. punto 2");
                Console.SetCursorPosition(40, 10); Console.Write("3. punto 3");
                Console.SetCursorPosition(40, 12); Console.Write("4. punto 4");
                Console.SetCursorPosition(40, 14); Console.Write("5. punto 5");
                Console.SetCursorPosition(40, 16); Console.Write("6. punto 6");
                Console.SetCursorPosition(40, 18); Console.Write("7. punto 7");
                Console.SetCursorPosition(40, 20); Console.Write("8. punto 8");
                Console.SetCursorPosition(40, 22); Console.Write("0. Salir");

                do
                {
                    Console.SetCursorPosition(40, 24); Console.Write("Digite una opción: ");
                    aux = Console.ReadLine();
                    Console.SetCursorPosition(40, 20);
                    if (!Validar.Vacio(aux))
                        if (Validar.TipoNumero(aux))
                            seguir = true;
                } while (!seguir);

                opc = Convert.ToInt32(aux);

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        punto1();
                        break;
                    case 2:
                        Console.Clear();
                        punto2();
                        break;
                    case 3:
                        Console.Clear();
                        punto3();
                        break;
                    case 4:
                        Console.Clear();
                        punto4();
                        break;
                    case 5:
                        Console.Clear();
                        punto5();
                        break;
                    case 6:
                        Console.Clear();
                        punto6();
                        break;
                    case 7:
                        Console.Clear();
                        punto7();
                        break;
                    case 8:
                        Console.Clear();
                        punto8();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.SetCursorPosition(40, 20); Console.Write("opción no válida              ");
                        break;

                }

                Console.ReadKey();

            } while (opc != 0);



        }
        static void punto1()
        {
            Console.WriteLine("Punto #1");
            Console.WriteLine("Escriba un número cualquiera:");
            int punto1;

            punto1 = int.Parse(Console.ReadLine());

            if ((punto1 % 2) == 0)
            {
                Console.WriteLine("Es Par");
            }
            else
            {
                Console.WriteLine("Es Impar");
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        static void punto2()
        {
            Console.WriteLine("Punto #2");
            Console.WriteLine("Escriba un número cualquiera:");

            int punto2, i;

            punto2 = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(punto2 + "x" + i + "=" + punto2 * i);
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        static void punto3()
        {
            Console.WriteLine("Punto #3");

            int a, b;

            for (a = 2; a <= 9; a++)
            {
                for (b = 1; b <= 10; b++)
                {
                    Console.WriteLine(a + "x" + b + "=" + a * b);
                }
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        static void punto4()
        {
            Console.WriteLine("Punto #4");
            int a, i, c = 0;
            String afirmativo = "Es primo", negativo = "no es primo";

            Console.WriteLine("Escriba un número aleatorio:");

            a = int.Parse(Console.ReadLine());

            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    c++;
                }
            }
            if (c > 2)
            { Console.WriteLine(negativo); }
            else Console.WriteLine(afirmativo);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        static void punto5()
        {
            Console.WriteLine("5. Punto");
            int[] edad = new int[] { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };

            for (int k = 0; k < edad.Length; k++)
            {
                for (int f = 0; f < edad.Length - 1; f++)
                {
                    if (edad[f] > edad[f + 1])
                    {
                        int aux;
                        aux = edad[f];
                        edad[f] = edad[f + 1];
                        edad[f + 1] = aux;
                    }
                }
            }
            for (int f = 0; f < edad.Length; f++)
            {
                Console.Write(edad[f] + "»");
            }
        }

        static void punto6()
        {
            Console.WriteLine("6. Punto");
            Console.WriteLine("escriba el nombre a consultar:");
            int c = 0;
            int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            string nombre = Console.ReadLine();

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombre == nombres[i])
                {
                    Console.WriteLine("la edad de " + nombre + " es " + edad[i]);
                    c++;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("No se encontró el nombre " + nombre + " en la lista");
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        static void punto7()
        {
            Console.WriteLine("7. Punto");
            int mayor = 0, menor = 1000;
            string nma = "a", nme = "b";
            int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };

            for (int i = 0; i < edad.Length; i++)
            {
                if (edad[i] > mayor)
                {
                    mayor = edad[i];
                    nma = nombres[i];
                }
                if (edad[i] < menor)
                {
                    menor = edad[i];
                    nme = nombres[i];
                }
            }

            Console.WriteLine("El menor es " + nme + " con " + menor + " años.");
            Console.WriteLine("El mayor es " + nma + " con " + mayor + " años.");

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        static void punto8()
        {
            Console.WriteLine("Punto #8");

            string str = "";
            Console.Write("Introduce una palabra para determinar si es PALINDROME o no : ");
            string s = Console.ReadLine();
            int i = s.Length;
            for (int c = i - 1; c >= 0; c--)
            {
                str += s[c];
            }
            if (str == s)
            {
                Console.WriteLine(s + " es palindrome");
            }
            else
            {
                Console.WriteLine(s + " no es palindrome");
            }
            Console.WriteLine(str);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}








