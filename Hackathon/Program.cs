using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios e = new Ejercicios();
            Console.WriteLine("Seleccione el ejercicio a ejecutar: ");
            Console.WriteLine("1. Scramble");
            Console.WriteLine("2. Justificador de texto");
            Console.WriteLine("3. Cadenas subsecuentes");
            Console.WriteLine("4. Abuela binaria");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //Scramble
                    Console.Clear();
                    Console.WriteLine("Ingrese cadena 1: ");
                    string cadena1 = Console.ReadLine();
                    Console.WriteLine("Ingrese cadena 2: ");
                    string cadena2 = Console.ReadLine();

                    if (e.Scramble(cadena1, cadena2))
                    {
                        Console.WriteLine("Resultado: TRUE");                        
                    }
                    else
                    {
                        Console.WriteLine("Resultado: FALSE");                       
                    }                    
                    break;
                case 2:
                    //Justificador de texto
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad maxima de caracteres por linea");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el texto a justificar");
                    string texto = Console.ReadLine();
                    
                    Console.WriteLine(e.Justificador(texto, num));
                    break;
                case 3:
                    Console.WriteLine("Candena 1");
                    string cad1 = Console.ReadLine().ToLower();
                    Console.WriteLine("Candena 2");
                    string cad2 = Console.ReadLine();
                    string cad3 = cad2;
                    string iguales = "";
                    bool terminadoo = false;
                    while (terminadoo == false)
                    {
                        string com = cad1.Substring(0, 1).ToLower();
                        cad1 = cad1.Remove(0, 1);
                        for (int i = 0; i < cad3.Length; i++)
                        {
                            string comprador = cad2.Substring(0, 1);
                            cad2 = cad2.Remove(0, 1);
                            if (comprador == com)
                            {
                                iguales += com;
                            }
                        }
                        cad2 = cad3;
                        if (cad1 == "")
                        {
                            terminadoo = true;
                        }
                    }
                    // VERIFICAR QUE NO SEAN IGUALES
                    string ig = iguales.Trim();
                    Console.WriteLine(ig);


                    break;
                case 4:
                    //Abuela binaria
                    Console.Clear();
                    Console.WriteLine("Ingrese primer numero (N): ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese segundo numero (n1): ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese tercer numero (n2): ");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    if((num2+num3)==num1)
                    {
                        int resultado = e.AbuelaBinaria(num1, num2, num3);
                        Console.WriteLine("La abuela le dará a su nieta "+ resultado.ToString()+" avellana(s)");
                    }
                    else
                    {
                        Console.WriteLine("El número N debe ser resultado de la suma de n1 y n2");
                    }

                    break;

                default:
                    Console.WriteLine("Ingrese una opcion correcta");
                    break;
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();

        }
    }
}
