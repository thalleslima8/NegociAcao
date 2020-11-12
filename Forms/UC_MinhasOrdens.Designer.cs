namespace NegociAcao.Forms
{
    partial class UC_MinhasOrdens
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dtp_SelecioneData = new System.Windows.Forms.DateTimePicker();
            this.Lbl_SelecioneData = new System.Windows.Forms.Label();
            this.Btn_6Meses = new System.Windows.Forms.Button();
            this.Btn_90Dias = new System.Windows.Forms.Button();
            this.Btn_60Dias = new System.Windows.Forms.Button();
            this.Btn_30Dias = new System.Windows.Forms.Button();
            this.Btn_MesAtual = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtp_SelecioneData
            // 
            this.Dtp_SelecioneData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_SelecioneData.Location = new System.Drawing.Point(12, 37);
            this.Dtp_SelecioneData.Name = "Dtp_SelecioneData";
            this.Dtp_SelecioneData.Size = new System.Drawing.Size(96, 20);
            this.Dtp_SelecioneData.TabIndex = 0;
            this.Dtp_SelecioneData.Value = new System.DateTime(2020, 11, 12, 17, 8, 34, 0);
            // 
            // Lbl_SelecioneData
            // 
            this.Lbl_SelecioneData.AutoSize = true;
            this.Lbl_SelecioneData.Location = new System.Drawing.Point(9, 10);
            this.Lbl_SelecioneData.Name = "Lbl_SelecioneData";
            this.Lbl_SelecioneData.Size = new System.Drawing.Size(89, 13);
            this.Lbl_SelecioneData.TabIndex = 1;
            this.Lbl_SelecioneData.Text = "Selecione a Data";
            // 
            // Btn_6Meses
            // 
            this.Btn_6Meses.Location = new System.Drawing.Point(128, 37);
            this.Btn_6Meses.Name = "Btn_6Meses";
            this.Btn_6Meses.Size = new System.Drawing.Size(67, 20);
            this.Btn_6Meses.TabIndex = 2;
            this.Btn_6Meses.Text = "6 Meses";
            this.Btn_6Meses.UseVisualStyleBackColor = true;
            // 
            // Btn_90Dias
            // 
            this.Btn_90Dias.Location = new System.Drawing.Point(201, 37);
            this.Btn_90Dias.Name = "Btn_90Dias";
            this.Btn_90Dias.Size = new System.Drawing.Size(67, 20);
            this.Btn_90Dias.TabIndex = 3;
            this.Btn_90Dias.Text = "90 Dias";
            this.Btn_90Dias.UseVisualStyleBackColor = true;
            // 
            // Btn_60Dias
            // 
            this.Btn_60Dias.Location = new System.Drawing.Point(274, 37);
            this.Btn_60Dias.Name = "Btn_60Dias";
            this.Btn_60Dias.Size = new System.Drawing.Size(67, 20);
            this.Btn_60Dias.TabIndex = 4;
            this.Btn_60Dias.Text = "60 Dias";
            this.Btn_60Dias.UseVisualStyleBackColor = true;
            // 
            // Btn_30Dias
            // 
            this.Btn_30Dias.Location = new System.Drawing.Point(347, 37);
            this.Btn_30Dias.Name = "Btn_30Dias";
            this.Btn_30Dias.Size = new System.Drawing.Size(67, 20);
            this.Btn_30Dias.TabIndex = 5;
            this.Btn_30Dias.Text = "30 Dias";
            this.Btn_30Dias.UseVisualStyleBackColor = true;
            // 
            // Btn_MesAtual
            // 
            this.Btn_MesAtual.Location = new System.Drawing.Point(420, 37);
            this.Btn_MesAtual.Name = "Btn_MesAtual";
            this.Btn_MesAtual.Size = new System.Drawing.Size(67, 20);
            this.Btn_MesAtual.TabIndex = 6;
            this.Btn_MesAtual.Text = "Mês Atual";
            this.Btn_MesAtual.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Codigo,
            this.Valor,
            this.Quantidade,
            this.Total,
            this.Tipo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 222);
            this.dataGridView1.TabIndex = 7;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 80;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor Unit.";
            this.Valor.Name = "Valor";
            this.Valor.Width = 80;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Qtd";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 40;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 90;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 40;
            // 
            // UC_MinhasOrdens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_MesAtual);
            this.Controls.Add(this.Btn_30Dias);
            this.Controls.Add(this.Btn_60Dias);
            this.Controls.Add(this.Btn_90Dias);
            this.Controls.Add(this.Btn_6Meses);
            this.Controls.Add(this.Lbl_SelecioneData);
            this.Controls.Add(this.Dtp_SelecioneData);
            this.Name = "UC_MinhasOrdens";
            this.Size = new System.Drawing.Size(650, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtp_SelecioneData;
        private System.Windows.Forms.Label Lbl_SelecioneData;
        private System.Windows.Forms.Button Btn_6Meses;
        private System.Windows.Forms.Button Btn_90Dias;
        private System.Windows.Forms.Button Btn_60Dias;
        private System.Windows.Forms.Button Btn_30Dias;
        private System.Windows.Forms.Button Btn_MesAtual;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}
