using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        int opcion=0;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("     R  E  C  E T  A  S");
            Console.WriteLine("-----------------------------"); Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("1. Agregar receta. ");
            Console.WriteLine("2. Buscar receta. ");
            Console.WriteLine("3. Mostrar receta. ");
            Console.WriteLine("4. Salir. ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Elige la opción: ");
            try
            {

            }
            catch (FormatException)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Error de formato. Intenta de nuevo");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Puilsa cualquier tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 4);
    }
}
