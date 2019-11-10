using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGasolina
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> cliente = new List<Cliente>()
            {

                new Cliente()
                {
                    Nombre="Sara Ivette",
                    Apellidos="Tauriz Solorzano",
                    Cedula= 1351208390,
                    Direccion="Leonidas Proaño"
                }
            };
            List<Gasolina> gasolina = new List<Gasolina>()
            {
                new Gasolina()
                {
                    Tipodegasolina="super",
                    Galon=3
                }
            };
            Console.WriteLine("------------------------------");
            Console.WriteLine("" + " " + "GASOLINERA TS" + " " + "");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            foreach (Cliente item in cliente)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------------------------------");

            foreach (Gasolina item in gasolina)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------------------------------");

            Console.ReadKey();


        }
    }
}
        
    

