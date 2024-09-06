using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class Mercado : Form
    {
        public Mercado()
        {
            InitializeComponent();
        }

        private void Mercado_Load(object sender, EventArgs e)
        {
           
                ArticuloService articulo = new ArticuloService();
                dgvArticulosLista.DataSource = articulo.listar(); 
            //dvgArticulosLista.DataSource = articulo.listar();
           
        }
    }
}
