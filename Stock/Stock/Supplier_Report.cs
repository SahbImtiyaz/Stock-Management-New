﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Supplier_Report : Form
    {
        public Supplier_Report()
        {
            InitializeComponent();
        }

        private void Supplier_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StockDataSet5.Supplier' table. You can move, or remove it, as needed.
            this.SupplierTableAdapter.Fill(this.StockDataSet5.Supplier);

            this.reportViewer1.RefreshReport();
        }
    }
}
