using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegociAcao.Forms
{
    public partial class Frm_OrdemDeCompra : Form
    {
        public Frm_OrdemDeCompra()
        {
            InitializeComponent();
        }

        private void OrdemDeCompra_Load(object sender, EventArgs e)
        {
            Txt_Papel.Focus();
        }

 
        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Papel.Focus();
            Txt_Papel.Text = "Digite o Papel";
            Msk_Qtd.Text = "";
            Msk_Valor.Text = "";
            Lbl_Total.Text = "";
        }

        private void Msk_Qtd_KeyDown(object sender, KeyEventArgs e)
        {          
        }

        private void Msk_Qtd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cod = int.Parse(Msk_Qtd.Text);
                var valor = double.Parse((Msk_Valor.Text).Replace("R$ ", ""));
                var total = valor * cod;
                Lbl_Volume.Visible = true;
                Lbl_Total.Text = $"R$ {total}";
            }
            catch (FormatException)
            {
                Msk_Qtd.Text = "";
                Lbl_Total.Text = "R$ 0,00";
                Msk_Qtd.Focus();
            }
        }
    }
}
