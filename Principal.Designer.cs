namespace NegociAcao
{
    partial class Principal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaOrdemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasOrdensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarJanelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pn_Painel = new System.Windows.Forms.Panel();
            this.Tbc_Ordens = new System.Windows.Forms.TabControl();
            this.apagarAbasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Pn_Painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logarToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // logarToolStripMenuItem
            // 
            this.logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            this.logarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.logarToolStripMenuItem.Text = "Logar";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaOrdemToolStripMenuItem,
            this.ordemDeVendaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // novaOrdemToolStripMenuItem
            // 
            this.novaOrdemToolStripMenuItem.Name = "novaOrdemToolStripMenuItem";
            this.novaOrdemToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.novaOrdemToolStripMenuItem.Text = "Ordem de Compra";
            this.novaOrdemToolStripMenuItem.Click += new System.EventHandler(this.novaOrdemToolStripMenuItem_Click);
            // 
            // ordemDeVendaToolStripMenuItem
            // 
            this.ordemDeVendaToolStripMenuItem.Name = "ordemDeVendaToolStripMenuItem";
            this.ordemDeVendaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ordemDeVendaToolStripMenuItem.Text = "Ordem de Venda";
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhasOrdensToolStripMenuItem,
            this.apagarAbasToolStripMenuItem,
            this.organizarJanelasToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // minhasOrdensToolStripMenuItem
            // 
            this.minhasOrdensToolStripMenuItem.Name = "minhasOrdensToolStripMenuItem";
            this.minhasOrdensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minhasOrdensToolStripMenuItem.Text = "Exibir Ordens";
            this.minhasOrdensToolStripMenuItem.Click += new System.EventHandler(this.minhasOrdensToolStripMenuItem_Click);
            // 
            // organizarJanelasToolStripMenuItem
            // 
            this.organizarJanelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascataToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.organizarJanelasToolStripMenuItem.Name = "organizarJanelasToolStripMenuItem";
            this.organizarJanelasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.organizarJanelasToolStripMenuItem.Text = "Organizar Janelas";
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascataToolStripMenuItem.Text = "Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.cascataToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // Pn_Painel
            // 
            this.Pn_Painel.Controls.Add(this.Tbc_Ordens);
            this.Pn_Painel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_Painel.Location = new System.Drawing.Point(0, 24);
            this.Pn_Painel.Name = "Pn_Painel";
            this.Pn_Painel.Size = new System.Drawing.Size(1184, 637);
            this.Pn_Painel.TabIndex = 2;
            this.Pn_Painel.Visible = false;
            // 
            // Tbc_Ordens
            // 
            this.Tbc_Ordens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Ordens.Location = new System.Drawing.Point(0, 0);
            this.Tbc_Ordens.Name = "Tbc_Ordens";
            this.Tbc_Ordens.SelectedIndex = 0;
            this.Tbc_Ordens.Size = new System.Drawing.Size(1184, 637);
            this.Tbc_Ordens.TabIndex = 0;
            // 
            // apagarAbasToolStripMenuItem
            // 
            this.apagarAbasToolStripMenuItem.Name = "apagarAbasToolStripMenuItem";
            this.apagarAbasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarAbasToolStripMenuItem.Text = "Apagar Aba";
            this.apagarAbasToolStripMenuItem.Click += new System.EventHandler(this.apagarAbasToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Pn_Painel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NegociAcão";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pn_Painel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaOrdemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarJanelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhasOrdensToolStripMenuItem;
        private System.Windows.Forms.Panel Pn_Painel;
        private System.Windows.Forms.TabControl Tbc_Ordens;
        private System.Windows.Forms.ToolStripMenuItem apagarAbasToolStripMenuItem;
    }
}

