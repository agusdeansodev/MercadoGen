﻿using System;
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
        private List<Articulo> listaArticulos;

        public Mercado()
        {
            InitializeComponent();
        }

        private void Mercado_Load(object sender, EventArgs e)
        {
           
                ArticuloService articulo = new ArticuloService();
                listaArticulos = articulo.listar();
                dgvArticulosLista.DataSource = listaArticulos;
                cargarImagen(listaArticulos[0].URLimagen);
         
           
        }

        private void dgvArticulosLista_SelectionChanged(object sender, EventArgs e)
        {
           Articulo seleccionado = (Articulo)dgvArticulosLista.CurrentRow.DataBoundItem; //DAME EL OBJ ENLAZADO //DEVUELVE UN OBJ 
           cargarImagen(seleccionado.URLimagen);

        }
        private void cargarImagen (string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);

            }
            catch(Exception ex) {
               
                pbxArticulo.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");

            }
        }
    }
}
