using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RECETAS
{
    public class DatosReceta
    {
        static int siguienteId = 0;
        public int IdReceta {get; set;}
        public string Nombre {  get; set; }
        public string Procedimiento { get; set; }
        public string Ingredientes { get; set; }

        public List<DatosReceta> IngresarReceta = new List<DatosReceta>();

        public DatosReceta(string nombre, string procedimiento, string ingredientes)
        {
            IdReceta = siguienteId++;
            Nombre = nombre;
            Procedimiento = procedimiento;
            Ingredientes = ingredientes;
        }

        public string NombreReceta()
        {
            string nombre;
            Console.Write("Ingresa el nombre de la receta: ");
            nombre = Console.ReadLine();
            return nombre;
        }

        public string ProcedimientoReceta()
        {
            string procedimiento;
            Console.Write("Ingresa la descripción de la receta: ");
            procedimiento = Console.ReadLine();
            return procedimiento;
        }
        public string IngredientesReceta()
        {
            string ingredientes;
            Console.WriteLine("Ingresa los ingredientes de la receta separados por comas: ");
            ingredientes = Console.ReadLine();
            return ingredientes;
        }

        public void AgregarReceta()
        {
            string nombre = NombreReceta();
            string descripcion = ProcedimientoReceta();
            string ingredientes = IngredientesReceta();
            DatosReceta nuevaReceta = new DatosReceta(nombre, descripcion, ingredientes);
            IngresarReceta.Add(nuevaReceta);
        }

        public void BuscarReceta()
        {
            string nombreParaBuscar;
            bool recetaEncontrada = false;
            Console.Write("Ingresa el nombre de la receta que quieras buscar: ");
            nombreParaBuscar = Console.ReadLine();
            foreach (var receta in IngresarReceta)
            {
                if (nombreParaBuscar.ToLower() == receta.Nombre.ToLower())
                {
                    recetaEncontrada = true;
                    Console.WriteLine("");
                    Console.WriteLine($"Receta #{receta.IdReceta}");
                    Console.WriteLine($"Nombre: {receta.Nombre}");
                    Console.WriteLine($"Procedimiento: {receta.Procedimiento}");
                    Console.WriteLine($"Ingredientes: {receta.Ingredientes}");
                    break;
                }
            }
            if(recetaEncontrada == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No existe una receta con ese nombre, intenta de nuevo");
                Console.WriteLine();
                Console.ResetColor();
            }
        }

        public void MostrarRecetas()
        {
            foreach(var receta in IngresarReceta)
            {
                Console.WriteLine(""); Console.ResetColor();
                Console.WriteLine($"Receta #{receta.IdReceta}");
                Console.WriteLine($"Nombre: {receta.Nombre}");
                Console.WriteLine($"Procedimiento: {receta.Procedimiento}");
                Console.WriteLine($"Ingredientes: {receta.Ingredientes}");
            }
        }

        public void MensajeParaContinuar()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Presiona cualquier tecla para continuar...");
            Console.ResetColor(); Console.ReadKey(); Console.Clear();
        }
    }

}
