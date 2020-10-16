using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public int codigoMax(string tabla, string campo)
        {
            int codigo = sn.procInsertar(tabla, campo);

            return codigo;


        }
    }
}
