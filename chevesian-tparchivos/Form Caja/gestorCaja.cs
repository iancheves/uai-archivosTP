using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chevesian_tparchivos
{
    class gestorCaja
    {
        private String Ruta;
        public gestorCaja(String Ruta)
        {
            this.Ruta = Ruta; 
        }

        //Agregar Caja
        public void AgregarCaja(Caja caja)
        {
            FileStream fsWrite = new FileStream(Ruta, FileMode.Append, FileAccess.Write);

            using (StreamWriter write = new StreamWriter(fsWrite))
            {
                write.WriteLine(caja.generarCaja());
            }
            fsWrite.Close();
        }

        //Eliminar Caja
        public void EliminarCaja(int numCaja, String Nombre)
        {
            FileStream fsRead = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);
            String output = String.Empty;

            using (StreamReader reader = new StreamReader(fsRead))
            {
                String linea = reader.ReadLine();

                while (linea != null)
                {
                    Caja miCaja = new Caja(linea);

                    if (miCaja.getNumeroCaja() == numCaja && miCaja.getNombre() == Nombre) 
                    {
                    }
                    else
                    {
                        output += linea + Environment.NewLine;
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

        //Modificar Datos
        public bool ModificarDatos(int numCajaSelect, String nombreSelect, int nuevoNumCaja, String nuevoNombre)
        {
            FileStream fsRead = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);
            String output = String.Empty;
            bool Resultado = false;

            using (StreamReader reader = new StreamReader(fsRead))
            {
                String linea = reader.ReadLine();

                while (linea != null)
                {
                    Caja miCaja = new Caja(linea);

                    if (miCaja.getNumeroCaja() == numCajaSelect && miCaja.getNombre() == nombreSelect)
                    {
                        miCaja.setNombre(nuevoNombre);
                        miCaja.setNumCaja(nuevoNumCaja);

                        output += miCaja.generarCaja() + "\r\n";
                        Resultado = true;
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

            return Resultado;
        }

        //Lista Caja
        public List<Caja> listarCaja()
        {
            List<Caja> miCajalst = new List<Caja>();

            FileStream fsRead = new FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fsRead))
            {
                String linea = reader.ReadLine();

                while (linea != null)
                {
                    Caja miCajaObject = new Caja(linea);
                    miCajalst.Add(miCajaObject);

                    linea = reader.ReadLine();
                }
            }
            fsRead.Close();

            return miCajalst;
        }

        //boool Elementos en Caja
        public bool CheckListCaja()
        {
            if (listarCaja().Count > 0) return true;
            else return false;
        }
    }
}
