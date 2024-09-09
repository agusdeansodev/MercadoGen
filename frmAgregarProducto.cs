﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class FrmAgregarProducto : Form
    {
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();

            articulo.nombre = textNombre.Text;
            articulo.marca = textMarca.Text;
            articulo.precio = float.Parse(textPrecio.Text);
            articulo.codigoArticulo=textCodigo.Text;
            articulo.URLimagen = textURLimagen.Text;

            try
            {
                ArticuloService ArticuloNuevo = new ArticuloService();
                
                ArticuloNuevo.agregarProducto(articulo);
                
                MessageBox.Show("PRODUCTO AGREGADA CON EXITO");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
            

            
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
