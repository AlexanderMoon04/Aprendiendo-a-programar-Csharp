namespace DesplazarX;
class Program
{
    static void Main(string[] args)
    {
        int desplazamientoX = 0,desplazamientoY = 0;
         ConsoleKeyInfo tecla; //tipo de dato que almacena informacion de la tecla pulsada

        do //Este ciclo no se va a dejar de repetir hasta que se cumpla la condicion del while
        {
            Console.Clear(); //Limpia consola
            //Imprime instrucciones y muestra el lugar donde se encuentra X
            Console.WriteLine("Usa la tecla A para mover la X a la izquierda y tecla D para mover a la derecha, tecla ESC para salir"); 
            Console.WriteLine("X se encuentra en: (" + desplazamientoX + "," + desplazamientoY + ")");

            for(int i = 0; i < 10; i++) //Condicion pensada para mostrar x en una longitud de 10 espacios
            { 
                for(int j = 0; j < 10; j++)
                {
                    if (i == desplazamientoY && j == desplazamientoX) //Imprime X en el espacio que corresponda al valor de desplazamiento en X e Y
                    {
                        Console.Write("X");
                    }
                    else//Imprime _ en el resto de espacios que no correspondan al valor de desplazamiento en X e Y
                    {
                        Console.Write("_"); 
                    }
                }
                Console.WriteLine(); //Espacio para dar estética
            }

            tecla = Console.ReadKey(true); //El true hace que la tecla no se muestre en pantalla al pulsarla, solo la lee
            if (tecla.Key == ConsoleKey.A && desplazamientoX > 0) //Al pulsar la tecla A y con el valor de desplazamiento mayor a 0
                desplazamientoX --; //Reduce el contador para mover la X a la izquierda

            else if(tecla.Key == ConsoleKey.D && desplazamientoX < 9) //Al pulsar la tecla D y con el valor de desplazamiento menor a 9
                desplazamientoX++; //Aumenta el contador para mover la X a la derecha

            else if(tecla.Key == ConsoleKey.W && desplazamientoY > 0 )
                desplazamientoY --;

            else if(tecla.Key == ConsoleKey.S && desplazamientoY < 9)
                desplazamientoY ++;    

        }while (tecla.Key != ConsoleKey.Escape); //Termina el ciclo cuando se pulsa la tecla esc
    }
}
