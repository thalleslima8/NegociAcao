using NegociAcao.Models;
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
        int id;
        public Frm_OrdemDeCompra()
        {
            InitializeComponent();
        }

        private void OrdemDeCompra_Load(object sender, EventArgs e)
        {
            Msk_Papel.Focus();
        }

 
        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Msk_Papel.Focus();
            Msk_Papel.Text = "Digite o Papel";
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

        private void Btn_Adiciona_Click(object sender, EventArgs e)
        {
            OrdemDeCompra oc = new OrdemDeCompra(Models.Enum.TipoOrdem.Compra);
            oc.Id = id++;
            oc.Data = Dtp_Data.Value;
            oc.Papel = Msk_Papel.Text;
            oc.Valor = double.Parse((Msk_Valor.Text).Replace("R$ ", ""));
            oc.Quantidade = int.Parse(Msk_Qtd.Text);

            //Faz a inclusão da ordem no DB

            Frm_Alert_Info alert = new Frm_Alert_Info(oc);
            alert.ShowDialog();
            Close();
        }
    }
}
