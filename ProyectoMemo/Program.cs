namespace ProyectoMemo;

/*
==========================================================================
Numero de veces que han ido al cine en el
ultimo en el ultimo mes los alumnos de una clase 
==========================================================================
2,3,0,1,5
3,2,3,0,0
2,1,2,1,0
2,1,1,1,3
4,0,0,2,1
==========================================================================
Num datos 25
F total 40
Media 1.6
Mediana 1
Moda 1
Varianza 1.76
Desviación estándar 1.33
==========================================================================
*/
class Program {
    static void Main(string[] args) {
        // double[] vecesIdasAlCine = [1, 2, 3, 6, 7, 1, 2, 3, 4, 5, 6, 9, 10, 10, 10];
        // double[] vecesIdasAlCine = [1, 1, 1, 1, 1, 1, 2, 2, 2, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4];
        double[] vecesIdasAlCine = [2, 3, 0, 1, 5, 3, 2, 3, 0, 0, 2, 1, 2, 1, 0, 2, 1, 1, 1, 3, 4, 0, 0, 2, 1];
        vecesIdasAlCine = ordenar(vecesIdasAlCine);
        Console.WriteLine("Media: "+media(vecesIdasAlCine));
        Console.WriteLine("Mediana: "+mediana(vecesIdasAlCine));
        Console.WriteLine("Moda: "+moda(vecesIdasAlCine));
        Console.WriteLine("Varianza1: "+varianza(vecesIdasAlCine));
        Console.WriteLine("Varianza2: "+varianza2(vecesIdasAlCine));
        Console.WriteLine("Desviacion estandar: "+desviacionEstandar(varianza(vecesIdasAlCine)));
    }
    static public double[] ordenar(double[] a) {
        /*
        Básicamente, el primer for es para los (25) valores que vamos a ordenar
        En el segundo for, se ordena por lo menos un numero, haciendo que con las (25x24) repeticiones
        sea suficiente para ordenar todos los números.
        En cada repetición del segundo for se compara cierto valor del arreglo con el que tiene
        enseguida a la "derecha", si es mayor que el, cambian de lugar, mandando al mayor a
        la "derecha" y el menor a la "izquierda", con suficientes repeticiones, los valores menores quedan
        a la izquierda y los mayores a la derecha, ordenando exitosamente el arreglo yey :D
       */
        double valorTemp;
        for (int i = 0; i < a.Length; i++) {
            for (int j = 0; j < a.Length - 1; j++) {
                valorTemp = a[j];
                if (a[j] > a[j + 1]) {
                    a[j] = a[j + 1];
                    a[j + 1] = valorTemp;
                }
            }
        }
        return a;
    }
    static public double media(double[] a) {
        double media = 0;
        for (int i = 0; i < a.Length; i++) {
            media += a[i];
        }
        media = media / a.Length;
        return media;
    }
    static public double mediana(double[] a) {
        double mediana;
        int val1, val2;
        if (a.Length % 2 == 0) {
            /*
            Encontrar los 2 valores de en medio si el arreglo es par, la mediana es el promedio de
            esos 2 valores 
            Es n/2 - 1, porque los arreglos empiezan desde el 0, no desde el 1 :P
            Si por ejemplo el length es de 10, los 2 indices de en medio serian los indices 4 y 5:
            0 1 2 3 4 5 6 7 8 9
            Un ejemplo mas cercano, si el length fuera de 26, los 2 indices de en medio serian 12 y 13
            */
            val1 = (a.Length / 2) - 1;
            val2 = a.Length / 2;
            mediana = (val1 + val2) / 2;
        } else {
            // Es n/2 - 1, porque los arreglos empiezan desde el 0, no desde el 1 :P
            mediana = a[(a.Length - 1) / 2];
        }
        return mediana;
    }
    static public double moda(double[] a)
    {
        /*
        Se revisa cada valor del arreglo con el primer for. Con el segundo for se revisa si ese valor aparece antes en el arreglo, esto se lleva a cabo hasta 
        que el valor no se repita, lo que permite entrar a la condicion donde se encuentra el tercer for, en este se cuenta cuantas veces aparece ese valor en el arreglo, se imprime el valor correspondiente y la cantidad de veces que se repite; si ese numero cuenta con mas repeticiones que el anterior, se toma como si fuera la moda y ese es el valor que regresa la funcion una vez terminado el ciclo principal.
        */
        int repeticiones = 0, repeticionesMax = 0;
        double moda = 0;
        bool numRepetido = false;
        for (int i = 0; i < a.Length; i++)
        {
            numRepetido = false; //Reinicio de variable cada que cambia el valor de i 
            for(int k =0; k < i; k++) //Ciclo para revisar si el numero está repetido
            {
                if (a[i] == a[k])
                {
                    numRepetido = true; 
                    break;
                }
            }
            if (!numRepetido) //Si el numero no está repetido, se cuenta el numero de repeticiones en el arreglo
            {
                repeticiones = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j]) 
                    {
                        repeticiones++;
                    }
                }
                Console.WriteLine("El numero " + a[i] + " aparece " + repeticiones + " veces en el arreglo"); 
                if (repeticiones > repeticionesMax) // Si el numero de repeticiones actual es mayor que el de repeticiones maximas, se toma como moda
                {
                    moda = a[i]; 
                    repeticionesMax = repeticiones; // Se actualiza el numero de repeticiones maximas
                }
            }   
        }
        return moda;
    }

    static public double varianza2(double[] a)
    {
        /*
        Se hace llamado a la funcion para obtener la media, pues este dato es necesario para calular la varianza.
        En el for se toma cada elemento del arreglo y se obtiene la diferencia al cuadrado entre el elemento y la media, ese valor se va acumulando en la variable
        "totalDiferencias" para ser dividido entre la cantidad de elementos del arreglo tras finalizar el ciclo y regresar el resultado de la varianza.
        */
        double varianza = 0, promedio = media(a), totalDiferencias = 0;

        for (int i = 0; i < a.Length; i++)
        {
            totalDiferencias += Math.Pow(a[i] - promedio, 2);
        }
        varianza = totalDiferencias / a.Length;
        return varianza;
    }

    static public double varianza(double[] a)
    {
        /*
        Funciona similar a la función de la moda, inmediatamente después de contar todas las frecuencias
        de X valor, se hacen los cálculos necesarios para conocer (Marca de clase - Media)^2 * Frecuencia,
        después de esto, se van agregando todos esos valores a varTotal y en la ultima instancia, donde es
        seguro que nuestro X valor es el ultimo (en este caso 5), se hace el ultimo calculo y suma de
        valores a varTotal, solo queda dividir lo que ha acumulado varTotal entre la cantidad de datos
        que hay, eso nos dará la varianza
        */
        double varianza = 0, varTotal = 0, num = a[0], mediaArr = media(a);
        int frecuencia = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (num == a[i])
            {
                frecuencia++;
                num = a[i];
            }
            else if (num != a[i])
            {
                // En la primera vuelta la operación sería:
                // varianza = (0-1.6)^2 * 6
                varianza = Math.Pow(num - mediaArr, 2) * frecuencia;
                varTotal += varianza;
                varianza = 0;
                frecuencia = 0;
                frecuencia++;
                num = a[i];
            }
        }
        // Como es obvio que num ya es el ultimo valor, no se presenta ninguna condición
        varianza = Math.Pow(num - mediaArr, 2) * frecuencia;
        varTotal += varianza;
        // Calcular 
        varTotal = varTotal / a.Length;
        return varTotal;
    }
    static public double desviacionEstandar(double a) {
        // Se explica solo :P
        a = Math.Sqrt(a);
        return a;
    }
}