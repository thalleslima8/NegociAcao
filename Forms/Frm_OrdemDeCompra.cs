using NegociAcao.Models;
using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace NegociAcao.Forms
{
    public partial class Frm_OrdemDeCompra : Form
    {
        public Frm_OrdemDeCompra()
        {
            InitializeComponent();
            Msk_Papel.Focus();
        }

        private void OrdemDeCompra_Load(object sender, EventArgs e)
        { }


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
                var valor = decimal.Parse((Msk_Valor.Text).Replace("R$ ", ""));
                var total = valor * cod;
                Lbl_Volume.Visible = true;
                Lbl_Total.Text = $"{total.ToString("C")}";
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
            //Valida as infos do formulario
            if (!ValidaForm())
            {
                Frm_Alerta alerta = new Frm_Alerta("Dados Incompletos! Preencha novamente o Formulário", "erro", "pare1");
                alerta.ShowDialog();
                if (alerta.DialogResult == DialogResult.OK)
                {
                    LimpaForm();
                }
                return;
            }


            //Dtp_Data.Format = DateTimePickerFormat.Custom;
            //Dtp_Data.CustomFormat = "dd/MM/yyyy";

            //Instancia nova ordem de compra
            OrdemDeCompra oc = new OrdemDeCompra(Models.Enum.TipoOrdem.Compra);

            //Faz leitura dos arquivos existentes
            var ordens = LerOrdemCSV();

            //Instancia uma nova ordem de compra, para receber a ultima ordem no arquivo de dados
            OrdemDeCompra ultimaOrdem = new OrdemDeCompra(Models.Enum.TipoOrdem.Compra);

            //Pega a ultima ordem
            foreach (OrdemDeCompra ordem in ordens)
            {
                if (ordens.IndexOf(ordem) == ordens.Count - 1)
                {
                    ultimaOrdem = ordem;
                }
            }

            //verifico se a ultima ordem é nula
            if (ultimaOrdem == null)
            {
                oc.Id = 1;
            }

            oc.Id = ultimaOrdem.Id + 1;
            oc.Data = Dtp_Data.Value.Date;
            oc.Papel = Msk_Papel.Text;
            oc.Valor = decimal.Parse((Msk_Valor.Text).Replace("R$", ""));
            oc.Quantidade = int.Parse(Msk_Qtd.Text);


            //Faz a inclusão da ordem no arquivo Cliente.csv
            SalvarOrdemCsv(oc);

            //Mostra Alert com Dados da Ordem
            Frm_Alert_Info alert = new Frm_Alert_Info(oc, "Ordem adicionada com sucesso!");
            alert.ShowDialog();

            //Questiona se quer adicionar outra ordem
            Frm_Alerta mensagem = new Frm_Alerta("Deseja inclui uma nova ordem?", "questoes");
            mensagem.ShowDialog();
            if (mensagem.DialogResult == DialogResult.Cancel)
            {
                Close();
                return;
            }

            LimpaForm();

        }

        private void LimpaForm()
        {
            Msk_Papel.Text = "";
            Msk_Qtd.Text = "";
            Msk_Valor.Text = "";
            Lbl_Total.Text = "";
            Msk_Papel.Focus();
        }

        public bool ValidaForm()
        {
            var formValido = true;
            if (Msk_Papel.Text == "")
            {
                formValido = false;
            }
            else if (Msk_Qtd.Text == "")
            {
                formValido = false;
            }
            else if (Msk_Valor.Text.Replace("R$ ", "") == "")
            {
                formValido = false;
            }
            return formValido;
        }

        public void SalvarOrdemCsv(Ordem ordem)
        {
            var linha = ordem.ToCSV();
            var endereçoArquivo = @".\OrdensDeCompra.csv";

            using (StreamWriter escritor = new StreamWriter(endereçoArquivo, true))
            {
                escritor.WriteLine(linha);
                escritor.Flush();
            }
        }

        public List<Ordem> LerOrdemCSV()
        {
            var endereçoArquivo = @".\OrdensDeCompra.csv";
            string linha;
            string[] dados;
            List<Ordem> ordens = new List<Ordem>();

            using (var fs = new FileStream(endereçoArquivo, FileMode.Open))
            using (StreamReader csv = new StreamReader(fs))
            {
                while (!csv.EndOfStream)
                {
                    linha = csv.ReadLine();
                    dados = linha.Split(';');
                    ordens.Add(ConverteStringParaOrdem(dados));
                }
                csv.Dispose();
            }
            return ordens;
        }

        public OrdemDeCompra ConverteStringParaOrdem(string[] dados)
        {
            OrdemDeCompra ordem = new OrdemDeCompra(Models.Enum.TipoOrdem.Compra);
            ordem.Id = int.Parse(dados[0]);
            ordem.Data = DateTime.Parse(dados[1]);
            ordem.Papel = dados[2];
            ordem.Valor = decimal.Parse(dados[3]);
            ordem.Quantidade = int.Parse(dados[4]);
            return ordem;
        }
    }
}
