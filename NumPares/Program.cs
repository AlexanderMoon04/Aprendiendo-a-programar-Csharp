using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace NumPares;

class Program
{
    /* Crear una funcion que imprime numeros pares de 2 hasta n 
    - En estructurado
    -En recursivo
     */
    static void Main(string[] args)
    {
        int Numero = 0;
        Console.Write("Salut, dame un numero: ");
        Numero = int.Parse(Console.ReadLine());
        Console.WriteLine(" Cantidad de numeros par: " + Pares(Numero));
        Console.WriteLine(" Cantidad de numeros par: " + ParesRecursivo(Numero));
    }

    static public int Pares(int Numero)
    {
        int par = 0, numpar = 0;
        for (int i = 2; i < Numero; i++)
        {
            if ((i % 2) == 0)
            {
                numpar += 2;
                par++;
                Console.Write(numpar + ",");
            }
        }
        return par;
    }

    static public int ParesRecursivo(int par)
    {
        if (par < 2)
        {
            return 0;
        }
        if (par % 2 == 0 && par >= 2)
            {
                Console.Write(par + ",");
                return ParesRecursivo(par - 2);
            }
            else
                return ParesRecursivo(par - 1);
    }
}
