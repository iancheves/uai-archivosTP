using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chevesian_tparchivos
{
    class Caja
    {
        private String nombre;
        private int numCaja;

        public Caja(String Nombre, int NumCaja)
        {
            this.nombre = Nombre;
            this.numCaja = NumCaja;
        }
        public Caja(String Linea)
        {
            String[] datos = Linea.Split(';');
            this.numCaja = Convert.ToInt32(datos[0]);
            this.nombre = datos[1];
        }

        public String getNombre()
        {
            return this.nombre;
        }
        public int getNumeroCaja()
        {
            return this.numCaja;
        }

        public void setNombre(String Nombre)
        {
            this.nombre = Nombre;
        }

        public void setNumCaja(int NumCaja)
        {
            if (NumCaja > 0)
            {
                this.numCaja = NumCaja;
            }
        }

        public String generarCaja()
        {
            return $"{this.numCaja};{this.nombre}";
        }

        public override string ToString()
        {
            return $"{this.numCaja} | {this.nombre}";
        }
    }
}
