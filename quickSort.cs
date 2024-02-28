/* using System;
using System.Collections.Generic;

class Programa
{

    static List<int> QuickSort(List<int> lista)
    {
        if (lista.Count <= 1)
        {
            return lista;
        }
        int pivote = lista[0];
        List<int> izquierda = new List<int>();
        List<int> derecha = new List<int>();
        for (int i = 1; i < lista.Count; i++)
        {
            if (lista[i] < pivote)
            {
                izquierda.Add(lista[i]);
            }
            else
            {
                derecha.Add(lista[i]);
            }
        }

        List<int> primero = QuickSort(izquierda);
        
        List<int> segundo = QuickSort(derecha);
        primero.Add(pivote);
        primero.AddRange(segundo);
        
        return primero;
    }
    static void Main(string[] args)
    {

        List<int> numeros = new List<int> { 23, 45, 16, 37, 3, 99 };
        List<int> listaOrdenada = QuickSort(numeros);
        Console.WriteLine(string.Join(",", listaOrdenada));
    }
}
 */