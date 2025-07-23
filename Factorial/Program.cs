namespace Factorial;

class Program
{
    static void Main(string[] args)
    {
        int chiffre;
        Console.WriteLine("Salut monsieur/madame, ecrivez-vous le chiffre: ");
        chiffre = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Normal: " + FactosFactoria(chiffre));
        System.Console.WriteLine("Recursivo: " + FactosFactoriaRecursivo(chiffre));
    }    static int FactosFactoria(int x)
    {
        if (x < 0) {
            return -1; // Indicate an error for negative input
        }

        int chiffre = 1;
        for (int i = 1; i <= x; i++)
        {
            chiffre *= i;
        }
        return chiffre;
    }
    static int FactosFactoriaRecursivo(int x)
    {
        if (x < 0)
        {
            return -1; // Indicate an error for negative input
        }

        if (x == 0 || x == 1)
                return 1;
            else
                return x * FactosFactoriaRecursivo(x - 1);
    }
}
