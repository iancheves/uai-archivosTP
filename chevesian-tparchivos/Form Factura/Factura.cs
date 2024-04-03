using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace chevesian_tparchivos
{
    class Factura
    {
        private double monto;
        private int numeroCaja;
        private int numeroFactura;

        public Factura(int numeroFactura, int numeroCaja, double monto)
        {
            this.numeroFactura = numeroFactura;
            this.numeroCaja = numeroCaja;
            this.monto = monto;
        }

        public Factura(String Linea)
        {
            string[] datos = Linea.Split(';');
            this.numeroFactura = Convert.ToInt32(datos[0]);
            this.numeroCaja = Convert.ToInt32(datos[1]);
            this.monto = Convert.ToDouble(datos[2]);
        }

        public int getNumFactura()
        {
            return this.numeroFactura;
        }

        public int getNumCaja()
        {
            return this.numeroCaja;
        }

        public double getMonto()
        {
            return this.monto;
        }

        public void setNumFactura(int numeroFactura)
        {
            if (numeroFactura > 0) this.numeroFactura = numeroFactura;
        }

        public void setNumCaja(int numeroCaja)
        {
            if (numeroCaja > 0) this.numeroCaja = numeroCaja;
        }

        public void setMonto(double monto)
        {
            if (monto > 0) this.monto = monto;
        }

        public String generarFactura()
        {
            return $"{this.numeroFactura};{this.numeroCaja};{this.monto}";
        }

        public override string ToString()
        {
            return $"{this.numeroFactura} | {this.numeroCaja} | ${this.monto}";
        }
    }
}
