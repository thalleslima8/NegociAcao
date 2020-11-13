using NegociAcao.Forms;
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
        int controleMinhasOrdens;
        public Principal()
        {
            InitializeComponent();
            novoToolStripMenuItem.Enabled = true;
            desconectarToolStripMenuItem.Enabled = false;
            exibirToolStripMenuItem.Enabled = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alerta alerta = new Frm_Alerta("Tem certeza que deseja sair?", "questoes");
            alerta.ShowDialog();

            if (alerta.DialogResult == DialogResult.OK)
            {
                Close();
            }
        }

        private void novaOrdemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrdemDeCompra ordem = new Frm_OrdemDeCompra();
            ordem.MdiParent = this;
            ordem.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void minhasOrdensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleMinhasOrdens++;
            Pn_Painel.Visible = true;
            UC_MinhasOrdens uc = new UC_MinhasOrdens();
            TabPage tp = new TabPage();
            tp.Name = "Ordens " + controleMinhasOrdens;
            tp.Text = "Minhas Ordens " + controleMinhasOrdens;
            tp.Controls.Add(uc);
            Tbc_Ordens.TabPages.Add(tp);
        }

        private void apagarAbasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Ordens.SelectedTab == null))
            {
                Tbc_Ordens.TabPages.Remove(Tbc_Ordens.SelectedTab);
            }
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.ShowDialog();

            if(login.DialogResult == DialogResult.OK)
            {
                novoToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = true;
                exibirToolStripMenuItem.Enabled = true;
                conectarToolStripMenuItem.Enabled = false;
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alerta alerta = new Frm_Alerta("Tem certeza que deseja sair?", "questoes");
            alerta.ShowDialog();

            if (alerta.DialogResult == DialogResult.OK)
            {
                novoToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                exibirToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
            }
        }
    }
}
