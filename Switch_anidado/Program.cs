using System;
//recuerden que esta es mi version de como hacer el switch anidado
// el profesor lo hizo on do while por eso el proceso mio y el ede el son diferentes
namespace Switch_anidado
{
    class program
    {
        static void Main(string[] args)
        {
            bool atras = true;
            Console.WriteLine("Bienvenido a mi programa para captura de nombre o suma de numeros");

            while (atras)
            {
                Console.WriteLine("Este es el menu principal");
                Console.WriteLine("elige el numero 1 si tenemos que hacer una captura de nombre");
                Console.WriteLine("elige el numero 2 si haremos una suma de dos numeros");
                Console.WriteLine("elige el numero 3 si deseas salir del programa");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        int opcion_2;
                        Console.WriteLine("Estas seguro que quieres hacer una captura de nombres? presiona (1) para seguir o presiona (2) para volver al menu principal");
                        opcion_2 = int.Parse(Console.ReadLine());
                        switch (opcion_2)
                        {
                            case 1:
                                Console.WriteLine("Captura de nombres");
                                Console.WriteLine("ingrese el primer nombre");
                                string nombre = (Console.ReadLine());
                                Console.WriteLine("ingrese el segundo nombre");
                                string apellido = (Console.ReadLine());
                                Console.WriteLine("tu nombre y apellido es: " + nombre + " " + apellido);
                                Console.WriteLine("volveras al menu principal, presiona una tecla");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine("Volveras al menu principal dando clic a cualquier tecla");
                                Console.ReadKey();
                                break;
                            default: Console.WriteLine("no elegiste una opcion valida");
                                break;
                        }
                        break;

                    case 2:
                        int opcion_3;
                        Console.WriteLine("Estas seguro que quieres hacer una suma de numeros? presiona 1 para seguir o presiona 2 para volver al menu principal");
                        opcion_3 = int.Parse(Console.ReadLine());
                        switch (opcion_3)
                        {
                            case 1:
                                Console.WriteLine("ingrese dos numeros de su preferencia");
                                Console.WriteLine("ingrese el primer numero");
                                int a = int.Parse(Console.ReadLine());
                                Console.WriteLine("ingrese el segundo numero");
                                int b = int.Parse(Console.ReadLine());
                                int resultado = a + b;
                                Console.WriteLine("la suma es " + resultado);
                                Console.WriteLine("volveras al menu principal, presiona una tecla");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine("Volveras al menu principal dando clic a cualquier tecla");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("no elegiste una opcion valida");
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saldras del programa presionando una tecla");
                        Console.ReadKey();
                        atras = false;
                        break;
                    default: Console.WriteLine("No elegiste ninguna de las opciones disponibles");
                        break;
                }

            }
           
        }
    }
}