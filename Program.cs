using RECETAS;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        string nombre = "", descripcion = "", ingredientes = "";
        DatosReceta nuevaReceta = new DatosReceta(nombre, descripcion, ingredientes);
        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("     R  E  C  E T  A  S");
            Console.WriteLine("-----------------------------"); Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("1. Agregar receta. ");
            Console.WriteLine("2. Buscar receta. ");
            Console.WriteLine("3. Mostrar receta. ");
            Console.WriteLine("4. Salir. ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Elige la opción: ");
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("--------------");
                        Console.WriteLine("AGREGAR RECETA"); Console.WriteLine("--------------");
                        Console.ResetColor();
                        nuevaReceta.AgregarReceta();
                        nuevaReceta.MensajeParaContinuar();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("--------------");
                        Console.WriteLine("BUSCAR RECETA"); Console.WriteLine("--------------");
                        Console.ResetColor();
                        nuevaReceta.BuscarReceta();
                        nuevaReceta.MensajeParaContinuar();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("--------------");
                        Console.WriteLine("MOSTRAR RECETA"); Console.WriteLine("--------------");
                        nuevaReceta.MostrarRecetas();
                        nuevaReceta.MensajeParaContinuar();
                        break;
                    case 4:
                        Console.Clear(); 
                        Console.WriteLine("-----------------"); Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine(" Ten un buen día");
                        Console.WriteLine("-----------------");
                        break;
                    default:

                        nuevaReceta.MensajeParaContinuar();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error en el formato ingresado. Intenta de nuevo.");
                nuevaReceta.MensajeParaContinuar();
            }
            Console.ResetColor();
        } while (opcion != 4);
    }
}
