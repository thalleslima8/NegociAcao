namespace NegociAcao.Forms
{
    partial class Frm_Alert_Info
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
            this.Lbl_Informacao = new System.Windows.Forms.Label();
            this.Lbl_DadosOrdem = new System.Windows.Forms.Label();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Informacao
            // 
            this.Lbl_Informacao.AutoSize = true;
            this.Lbl_Informacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_Informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Informacao.Location = new System.Drawing.Point(30, 20);
            this.Lbl_Informacao.Name = "Lbl_Informacao";
            this.Lbl_Informacao.Size = new System.Drawing.Size(0, 16);
            this.Lbl_Informacao.TabIndex = 0;
            // 
            // Lbl_DadosOrdem
            // 
            this.Lbl_DadosOrdem.AutoSize = true;
            this.Lbl_DadosOrdem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DadosOrdem.Location = new System.Drawing.Point(30, 57);
            this.Lbl_DadosOrdem.Name = "Lbl_DadosOrdem";
            this.Lbl_DadosOrdem.Size = new System.Drawing.Size(0, 16);
            this.Lbl_DadosOrdem.TabIndex = 1;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(115, 248);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(113, 40);
            this.Btn_Ok.TabIndex = 2;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Frm_Alert_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 300);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Lbl_DadosOrdem);
            this.Controls.Add(this.Lbl_Informacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Alert_Info";
            this.Text = "Frm_Alert_Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Informacao;
        private System.Windows.Forms.Label Lbl_DadosOrdem;
        private System.Windows.Forms.Button Btn_Ok;
    }
}