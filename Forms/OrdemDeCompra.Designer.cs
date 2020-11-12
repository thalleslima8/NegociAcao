namespace NegociAcao.Forms
{
    partial class OrdemDeCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Papel = new System.Windows.Forms.TextBox();
            this.Lbl_Papel = new System.Windows.Forms.Label();
            this.Dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Data = new System.Windows.Forms.Label();
            this.Btn_Adiciona = new System.Windows.Forms.Button();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Lbl_Qtd = new System.Windows.Forms.Label();
            this.Msk_Valor = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Volume = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Msk_Qtd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Txt_Papel
            // 
            this.Txt_Papel.Location = new System.Drawing.Point(10, 45);
            this.Txt_Papel.Name = "Txt_Papel";
            this.Txt_Papel.Size = new System.Drawing.Size(105, 20);
            this.Txt_Papel.TabIndex = 0;
            this.Txt_Papel.Text = "Digite a Ação";
            // 
            // Lbl_Papel
            // 
            this.Lbl_Papel.AutoSize = true;
            this.Lbl_Papel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Papel.Location = new System.Drawing.Point(10, 20);
            this.Lbl_Papel.Name = "Lbl_Papel";
            this.Lbl_Papel.Size = new System.Drawing.Size(49, 16);
            this.Lbl_Papel.TabIndex = 1;
            this.Lbl_Papel.Text = "Papel";
            this.Lbl_Papel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dtp_Data
            // 
            this.Dtp_Data.Location = new System.Drawing.Point(137, 45);
            this.Dtp_Data.Name = "Dtp_Data";
            this.Dtp_Data.Size = new System.Drawing.Size(216, 20);
            this.Dtp_Data.TabIndex = 2;
            this.Dtp_Data.Value = new System.DateTime(2020, 11, 12, 13, 46, 45, 0);
            // 
            // Lbl_Data
            // 
            this.Lbl_Data.AutoSize = true;
            this.Lbl_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Data.Location = new System.Drawing.Point(134, 23);
            this.Lbl_Data.Name = "Lbl_Data";
            this.Lbl_Data.Size = new System.Drawing.Size(41, 16);
            this.Lbl_Data.TabIndex = 3;
            this.Lbl_Data.Text = "Data";
            // 
            // Btn_Adiciona
            // 
            this.Btn_Adiciona.Location = new System.Drawing.Point(405, 42);
            this.Btn_Adiciona.Name = "Btn_Adiciona";
            this.Btn_Adiciona.Size = new System.Drawing.Size(117, 23);
            this.Btn_Adiciona.TabIndex = 4;
            this.Btn_Adiciona.Text = "Adicionar";
            this.Btn_Adiciona.UseVisualStyleBackColor = true;
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor.Location = new System.Drawing.Point(10, 82);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(68, 16);
            this.Lbl_Valor.TabIndex = 5;
            this.Lbl_Valor.Text = "Valor R$";
            // 
            // Lbl_Qtd
            // 
            this.Lbl_Qtd.AutoSize = true;
            this.Lbl_Qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Qtd.Location = new System.Drawing.Point(134, 85);
            this.Lbl_Qtd.Name = "Lbl_Qtd";
            this.Lbl_Qtd.Size = new System.Drawing.Size(88, 16);
            this.Lbl_Qtd.TabIndex = 7;
            this.Lbl_Qtd.Text = "Quantidade";
            // 
            // Msk_Valor
            // 
            this.Msk_Valor.Location = new System.Drawing.Point(10, 101);
            this.Msk_Valor.Mask = "$ 00.00";
            this.Msk_Valor.Name = "Msk_Valor";
            this.Msk_Valor.Size = new System.Drawing.Size(91, 20);
            this.Msk_Valor.TabIndex = 9;
            // 
            // Lbl_Volume
            // 
            this.Lbl_Volume.AutoSize = true;
            this.Lbl_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Volume.Location = new System.Drawing.Point(261, 85);
            this.Lbl_Volume.Name = "Lbl_Volume";
            this.Lbl_Volume.Size = new System.Drawing.Size(118, 16);
            this.Lbl_Volume.TabIndex = 10;
            this.Lbl_Volume.Text = "Total Da Ordem";
            this.Lbl_Volume.Visible = false;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(261, 108);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Total.TabIndex = 11;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(406, 87);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(115, 21);
            this.Btn_Limpar.TabIndex = 12;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Msk_Qtd
            // 
            this.Msk_Qtd.Location = new System.Drawing.Point(137, 101);
            this.Msk_Qtd.Mask = "000";
            this.Msk_Qtd.Name = "Msk_Qtd";
            this.Msk_Qtd.Size = new System.Drawing.Size(91, 20);
            this.Msk_Qtd.TabIndex = 13;
            this.Msk_Qtd.ValidatingType = typeof(int);
            this.Msk_Qtd.TextChanged += new System.EventHandler(this.Msk_Qtd_TextChanged);
            this.Msk_Qtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_Qtd_KeyDown);
            // 
            // OrdemDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.Msk_Qtd);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Lbl_Volume);
            this.Controls.Add(this.Msk_Valor);
            this.Controls.Add(this.Lbl_Qtd);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.Btn_Adiciona);
            this.Controls.Add(this.Lbl_Data);
            this.Controls.Add(this.Dtp_Data);
            this.Controls.Add(this.Lbl_Papel);
            this.Controls.Add(this.Txt_Papel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrdemDeCompra";
            this.Text = "Ordem De Compra";
            this.Load += new System.EventHandler(this.OrdemDeCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Papel;
        private System.Windows.Forms.Label Lbl_Papel;
        private System.Windows.Forms.DateTimePicker Dtp_Data;
        private System.Windows.Forms.Label Lbl_Data;
        private System.Windows.Forms.Button Btn_Adiciona;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Label Lbl_Qtd;
        private System.Windows.Forms.MaskedTextBox Msk_Valor;
        private System.Windows.Forms.Label Lbl_Volume;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.MaskedTextBox Msk_Qtd;
    }
}