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
    public partial class Frm_Alert_Info : Form
    {
        public Frm_Alert_Info(Ordem ordem, string msg)
        {
            InitializeComponent();
            Lbl_Informacao.Text = "Informações da Ordem: " + ordem.Id;
            Lbl_DadosOrdem.Text = ordem.ToString();
            Lbl_Sucesso.Text = msg;
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
