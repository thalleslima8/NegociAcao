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
    public partial class Frm_Alerta : Form
    {
        public Frm_Alerta(string msg, string nomeImagem)
        {
            InitializeComponent();
            Lbl_Questao.Text = msg;
            Image Myimage = (Image)global::NegociAcao.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_Image.Image = Myimage;
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
