﻿using NegociAcao.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegociAcao
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void novaOrdemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdemDeCompra ordem = new OrdemDeCompra();
            ordem.ShowDialog();
        }
    }
}
