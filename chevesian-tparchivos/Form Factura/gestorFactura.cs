using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chevesian_tparchivos
{
    class gestorFactura
    {
        public String Ruta;

        public gestorFactura(String ruta)
        {
            Ruta = ruta;
        }

        public void AgregarFactura(Factura factura)
        {
            FileStream fsWrite = new FileStream(Ruta, FileMode.Append, FileAccess.Write);

            using (StreamWriter writer = new StreamWriter(fsWrite))
            {
                writer.WriteLine(factura.generarFactura());
            }
            fsWrite.Close();
        }

        public void EliminarFactura(int numeroFactura, int numeroCaja, double monto)
        {
            FileStream fsRead = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);
            String output = String.Empty;

            using (StreamReader reader = new StreamReader(fsRead))
            {
                String linea = reader.ReadLine();

                while (linea != null)
                {
                    Factura miFactura = new Factura(linea);

                    if (miFactura.getNumFactura() == numeroFactura && miFactura.getNumCaja() == numeroCaja && miFactura.getMonto() == monto)
                    {
                    }
                    else
                    {
                        output+=linea+Environment.NewLine;
                    }

                    linea = reader.ReadLine();
                }
            }
            fsRead.Close();

            FileStream fsWrite = new FileStream(Ruta, FileMode.Truncate, FileAccess.Write);

            using (StreamWriter writer = new StreamWriter(fsWrite))
            {
                writer.Write(output);
            }

            fsWrite.Close();
        }

        public bool ModificarDatos(int numFacturaSelect, int numCajaSelect, double montoSelect, int numFacturaNew, int numCajaNew, double montoNew)
        {
            bool resultado = false;
            String output = String.Empty;
            FileStream fsRead = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fsRead))
            {
                String linea = reader.ReadLine();

                while (linea != null)
                {
                    Factura miFactura = new Factura(linea);

                    if (miFactura.getNumFactura() == numFacturaSelect && miFactura.getNumCaja() == numCajaSelect && miFactura.getMonto() == montoSelect)
                    {
                        miFactura.setNumFactura(numFacturaNew);
                        miFactura.setNumCaja(numCajaNew);
                        miFactura.setMonto(montoNew);
                        resultado = true;

                        output += miFactura.generarFactura() + "\r\n";
                    }
                    else output += linea + Environment.NewLine;

                    linea = reader.ReadLine();
                }
            }
            fsRead.Close();

            FileStream fsWrite = new FileStream(Ruta, FileMode.Truncate, FileAccess.Write);

            using (StreamWriter writer = new StreamWriter(fsWrite))
            {
                writer.Write(output);
            }
            fsWrite.Close();

            return resultado;
        }

        public List<Factura> listarFactura()
        {
            List<Factura> miFacturalst = new List<Factura>();
            FileStream fsRead = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader reader = new StreamReader(fsRead))
            {
                String datos = reader.ReadLine();

                while (datos != null)
                {
                    Factura miFactura = new Factura(datos);
                    miFacturalst.Add(miFactura);
                    datos = reader.ReadLine();
                }
            }
            fsRead.Close();

            return miFacturalst;
        }

        public bool CheckListFactura()
        {
            if (listarFactura().Count > 0) return true;
            else return false;
        }
    }
}
