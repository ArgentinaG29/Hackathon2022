using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    public class Ejercicios
    {
        public bool Scramble(string cadena1, string cadena2)
        {
            List<string> caracteres1 = new List<string>();
            List<string> caracteres2 = new List<string>();

            for (int i = 0; i < cadena1.Length; i++)
            {
                caracteres1.Add(cadena1.Substring(i, 1).ToLower());
                caracteres2.Add(cadena2.Substring(i, 1).ToLower());
            }
            
            for (int i = 0; i < caracteres2.Count; i++)
            {                                
                for (int j = 0; j < caracteres1.Count; j++)
                {
                    if(caracteres2[i] == caracteres1[j])
                    {
                        caracteres1.RemoveAt(j);                        
                        break;
                    }
                }
            }

            if(caracteres1.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public string Justificador(string texto, int num)
        {
            //VER PASO A PASO
            string mostrar = "";

            string buscador = "";
            int contador = 0;
            int cadena = 0;
            mostrar = "\"";
            bool terminado = false;
            string letra = "";
            //contar cuantas letras tiene la palabra
            while (terminado == false)
            {
                if (texto == "")
                {
                    terminado = true;
                    letra = "";
                }
                else
                {
                    letra = texto.Substring(0, 1);
                    texto = texto.Remove(0, 1);
                }
                if (letra == " ")
                {
                    string prueba = mostrar + buscador;
                    if (prueba.Length <= num)
                    {
                        if (prueba.Length == 8)
                                {
                            mostrar += " " + buscador + "\"";
                            buscador = "";
                            Console.WriteLine(mostrar);
                            mostrar = "\"";
                        }
                        else
                        {
                            mostrar += buscador + " ";
                            buscador = "";
                        }

                    }
                    else
                    {
                        //devolver la palabra
                        texto = buscador + " " + texto;
                        //BUSCAR CUADRAR LA CADENA
                        int faltante = num - mostrar.Length;
                        string[] oracion = mostrar.Split(' ');
                        int cant = oracion.Length;
                        int veri = 0;
                        int repartido = 0;
                        if(cant != 0)
                        {
                            repartido = faltante / (cant);
                            veri = faltante - (repartido * cant) - 1;
                        }
                        
                        string espacios = "";
                        if (veri != 0)
                        {
                            for (int i = 0; i < veri; i++)
                            {
                                espacios += " ";
                            };
                            mostrar = oracion[0] + " " + espacios;
                            for (int i = 1; i < cant; i++)
                            {
                                for (int j = 0; j < repartido; j++)
                                {
                                    espacios += " ";
                                };
                                mostrar += oracion[i] + " " + espacios;
                            }
                            Console.WriteLine(mostrar + "\"");
                            mostrar = "\"";
                            buscador = "";
                        }
                        else
                        {
                            for (int i = 0; i < cant; i++)
                            {
                                for (int j = 0; j < repartido; j++)
                                {
                                    espacios += " ";
                                };
                                if (i == cant - 1)
                                {
                                    mostrar += oracion[i] + espacios;
                                }
                                else
                                {
                                    mostrar += oracion[i] + " " + espacios;
                                }
                            }
                            Console.WriteLine(mostrar + "\"");
                            mostrar = "\"";
                            buscador = "";
                        }

                    }
                }
                else
                {
                    buscador += letra;
                }
            }
            string espaciosA = "";
            texto = buscador + texto;
            for (int j = 0; j < (num - texto.Length); j++)
            {
                espaciosA += " ";
            };

            mostrar = "\"" + texto + espaciosA;
            return mostrar + "\"";            
        }

        public int AbuelaBinaria(int total, int n1, int n2)
        {
            string binario1, binario2;
            int cantidad = 0;
            binario1 = Binario(n1);
            binario2 = Binario(n2);

            for (int i = 0; i < binario1.Length; i++)
            {
                if(binario1.Substring(i,1) == "1")
                {
                    cantidad++;
                }                
            }

            for (int i = 0; i < binario2.Length; i++)
            {
                if (binario2.Substring(i, 1) == "1")
                {
                    cantidad++;
                }
            }

            return cantidad;

        }

        string Binario(int n)
        {
            string binario = "";
            if(n != 0)
            {
                while (n > 0)
                {
                    if (n % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    n = n / 2;
                }
                return binario;
            }
            else
            {
                return "0";
            }
            
        }

    }
}
