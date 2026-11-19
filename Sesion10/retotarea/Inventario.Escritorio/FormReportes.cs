using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Inventario.Modelos;
using Inventario.Servicios;
using System.Linq;

namespace Inventario.Escritorio_
{
    public partial class FormReportes : Form
    {
        private readonly ServicioInventario _servicio;
        public FormReportes(ServicioInventario servicio)
        {
            InitializeComponent();

            _servicio = servicio;

            CargarReportes();
        }

        private void CargarReportes()
        {
            var productos = _servicio.Listar();

            dgvMasValiosos.DataSource = productos
                .OrderByDescending(p => p.Precio * p.Stock)
                .Select(p => new
                {
                    p.Codigo,
                    p.Nombre,
                    p.Precio,
                    p.Stock,
                    ValorTotal = p.Precio * p.Stock
                })
                .ToList();

            dgvStockBajo.DataSource = _servicio.StockBajo();
        }

    }
}
