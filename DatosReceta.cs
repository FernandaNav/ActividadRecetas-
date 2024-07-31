using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RECETAS
{
    internal class DatosReceta
    {
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }
        public string Ingredientes { get; set; }

        public List<DatosReceta> IngresarReceta = new List<DatosReceta>();

        public DatosReceta(string nombre, string descripcion, string ingredientes)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Ingredientes = ingredientes;
        }

        public string NombreReceta()
        {
            string nombre;
            Console.Write("Ingresa el nombre de la receta: ");
            nombre = Console.ReadLine();
            return nombre;
        }

        public string DescripcionReceta()
        {
            string descripcion;
            Console.Write("Ingresa la descripción de la receta: ");
            descripcion = Console.ReadLine();
            return descripcion;
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
            string descripcion = DescripcionReceta();
            string ingredientes = IngredientesReceta();

            DatosReceta nuevaReceta = new DatosReceta(nombre, descripcion, ingredientes);
            IngresarReceta.Add(nuevaReceta);
        }
    }

}
