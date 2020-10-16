using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();
        public int procInsertar(string tabla, string campo)
        {
            int codigo = 0;
            string sql = "SELECT MAX(" + campo + ") FROM " + tabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    codigo = reader.GetInt16(0);
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo); }
            codigo++;

            return codigo;
        }
    }
}
