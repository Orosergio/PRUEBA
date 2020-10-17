using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Navegador : UserControl
    {
        public string tbl;
        public string cmp;
        public TextBox txt;
        public string ruta;
        public Navegador()
        {
            InitializeComponent();
        }
        Controlador cn = new Controlador();
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            insertar(tbl, cmp, txt);
        }

        public void insertar(string tabla, string campo, TextBox txt)
        {
            string tbl = tabla;
            string cmp1 = campo;
            TextBox txt1 = txt;
            int codigo = cn.codigoMax(tbl, cmp1);
            txt1.Text = codigo.ToString();
            txt1.Enabled = false;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayuda/AyudaTaquilla.chm", ruta);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int code = 1;
            
        }
    }
}
