namespace Recursividad;

class Program
{
    static void Main(string[] args)
    {
        printRecursiva(3);
        imprimir(3);
        System.Console.WriteLine("Suma normal " + sumaNormal(4));
        System.Console.WriteLine("Suma recursiva " + sumaRecursiva(4));
        System.Console.WriteLine("Cantidad de digitos que tiene el numero: " + digitos(99));
        System.Console.WriteLine("Cantidad de digitos que tiene el numero (Recursivo): "+digitosRecursivo(99));
        System.Console.WriteLine("**********Pares normal**********");
        imprimirPares(10);
        System.Console.WriteLine("**********Pares recursivo**********"); 
        imprimirParesRecursivo(10);
        System.Console.WriteLine("**********Pares normal invertido**********");
        imprimirParesInverso(10);
       System.Console.WriteLine("**********Pares recursivo invertido**********"); 
        imprimirParesRecursivoInverso(2,10);
    }
    static void imprimir(int x)
    {
        for (int i = 0; i < x; i++)
        {
            System.Console.WriteLine("Bonjour");
        }
    }
    static void printRecursiva(int x) //Hay que poner un tope
    {
        if (x == 0)
            return;

        System.Console.WriteLine("Jelou every-Nyan");
        printRecursiva(x - 1);
    }
    static int sumaNormal(int x)
    {
        int suma = 0;
        for (int i = 0; i <= x; i++)
        {
            suma = suma + i;
        }
        return suma;
    }
    static int sumaRecursiva(int x)
    {
        if (x == 0)
        {
            return 0;
        }
        return x + sumaRecursiva(x - 1);
    }
    static int digitos(int x)
    {
        int contador = 0;
        while (x > 0)
        {
            contador++;
            x = x / 10;
        }
        return contador;
    }
    static int digitosRecursivo(int x)
    {
        if (x < 10)
            return 1;
        return 1 + digitosRecursivo(x/10);
    }
    static void imprimirParesRecursivo(int n)
    {
        if (n%2==0 && n>0)
        {
            System.Console.WriteLine(n);
            imprimirParesRecursivo(n-2);
        }
        else if (n>0)
            imprimirParesRecursivo(n-1);
    
        else
            return;
    }
    static void imprimirPares(int n)
    {
        while (n>=1){
            if (n%2==0){
                System.Console.WriteLine(n);
            }
            n--;
        }
        return;
    }
    static void imprimirParesInverso(int n)
    {
        int i=2;
        while(i<=n){
            if (i%2==0)
                System.Console.WriteLine(i);
            i++;
        }
    }
    static void imprimirParesRecursivoInverso(int i, int n)
    {
        if(i>n)
            return;

        if(i%2==0)
            System.Console.WriteLine(i);

        imprimirParesRecursivoInverso(i+2,n);
    }
}
