using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGasolina
{
    public class Gasolina
    {
        private string tipodegasolina;

        public string Tipodegasolina
        {
            get
            {
                if (tipodegasolina == "super")
                {
                    Precio = 1.80;
                }
                else
                {
                    Precio = 2.50;
                }
                return tipodegasolina;
            }
            set { tipodegasolina = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        private int galon;

        public int Galon
        {
            get { return galon; }
            set { galon = value; }
        }


        public double Subtotal
        {
            get { return Precio * Galon; }
        }
        public double IVA
        {
            get { return Subtotal * 12 / 100; }
        }
        public double Total
        {
            get { return Subtotal + IVA; }
        }
        public string mostrarGasolina()
        {
            return Tipodegasolina.ToString() + Galon + Precio + Subtotal.ToString();
        }
        public override string ToString()
        {


            return "Tipo de Gasolina: " + Tipodegasolina.ToString() + "\n" + "Precio de la Gasolina: " + Precio + "\n" +"Cuantos galones desea: " + Galon.ToString()+"\n"

                + "------------------------------" + "\n" + "Subtotal: " + Subtotal + "\n" + "IVA: " + IVA + "\n" + "Total a pagar: " + Total.ToString();

        }

    }
}