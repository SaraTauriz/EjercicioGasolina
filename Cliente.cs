using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGasolina
{
    public class Cliente
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private int cedula;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string mostrarCli()
        {
            return Nombre.ToString() + Apellidos + Cedula + Direccion.ToString();
        }
        public override string ToString()
        {
            return "Nombres: " + Nombre.ToString() + "\n" + "Apellidos: " +
                Apellidos + "\n" + "Cédula: " + Cedula + "\n" + "Dirección: " + Direccion.ToString() + "\n";

        }
    }
}