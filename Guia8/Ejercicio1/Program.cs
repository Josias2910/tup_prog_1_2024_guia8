using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Program
    {
        static int contador = 0;
        static int cantidad = 0;
        static int[] lista;
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("\nSeleccione una opcion\n1 - Ingresar lista de numeros enteros\n2 - Mostrar orden del listado\n3 - Buscar un elemento\n4 - Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nIngrese cantidad total de numeros a ingresar");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        cantidadLista(cantidad);
                        Console.WriteLine("\nIngrese numeros a guardar en el vector");
                        guardarNumeros();                                    
                    break;

                    case 2:
                        Console.WriteLine("\n");
                        lista = burbuja(lista, contador);
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(lista[i]);
                        }
                    break;

                    case 3:
                        Console.WriteLine("\nIngrese numero a buscar");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        int pos = BusquedaSecuencial(lista, valor, contador);
                        if (pos == -1)
                        {
                            Console.WriteLine("\nNumero no encontrado");
                        }
                        else
                            Console.WriteLine("\nSe encontro el valor en la posicion {0}", pos);
                    break;
                        
                    case 4:
                        Console.WriteLine("\nSaliendo...");
                    break;

                    default:
                        Console.WriteLine("\nError");
                    break;
                }
            } while (opcion != 4);
        }

        static void cantidadLista(int cantidad) 
        {
            lista = new int[cantidad];
        }

        static void guardarNumeros()
        {
            for (int i = 0; i < cantidad; i++)
            {
                lista[i] = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
        }

        static int BusquedaSecuencial(int[] datos, int valor, int contador)
        {
            int i = 0;
            int pos = -1;

            while ((pos == -1) && (i < contador))
            {
                if (datos[i] == valor)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }
        
        static int [] burbuja(int[] valores, int contador)
        {
            int aux, i, j;
            for (i = 0; i < contador - 1; i++)
            {
                for (j = i + 1; j < contador; j++)
                {
                    if (valores[i] > valores[j])
                    {
                        aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux;
                    }
                }
            }
            return valores;
        }
    }
}
