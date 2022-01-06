
namespace projetoVendas.views
{
    partial class Frm_CadastrarProduto
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
            this.Pnl_CadastrarPessoa = new System.Windows.Forms.Panel();
            this.Txt_valorUnitario = new System.Windows.Forms.MaskedTextBox();
            this.Txt_quantidadeDisponivel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_CadastrarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_CadastrarPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_CadastrarPessoa
            // 
            this.Pnl_CadastrarPessoa.BackColor = System.Drawing.Color.AliceBlue;
            this.Pnl_CadastrarPessoa.Controls.Add(this.Txt_valorUnitario);
            this.Pnl_CadastrarPessoa.Controls.Add(this.Txt_quantidadeDisponivel);
            this.Pnl_CadastrarPessoa.Controls.Add(this.label4);
            this.Pnl_CadastrarPessoa.Controls.Add(this.label3);
            this.Pnl_CadastrarPessoa.Controls.Add(this.Txt_descricao);
            this.Pnl_CadastrarPessoa.Controls.Add(this.label2);
            this.Pnl_CadastrarPessoa.Controls.Add(this.Btn_CadastrarProduto);
            this.Pnl_CadastrarPessoa.Controls.Add(this.label1);
            this.Pnl_CadastrarPessoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_CadastrarPessoa.Location = new System.Drawing.Point(0, 0);
            this.Pnl_CadastrarPessoa.Name = "Pnl_CadastrarPessoa";
            this.Pnl_CadastrarPessoa.Size = new System.Drawing.Size(477, 424);
            this.Pnl_CadastrarPessoa.TabIndex = 0;
            // 
            // Txt_valorUnitario
            // 
            this.Txt_valorUnitario.Location = new System.Drawing.Point(52, 255);
            this.Txt_valorUnitario.Name = "Txt_valorUnitario";
            this.Txt_valorUnitario.Size = new System.Drawing.Size(86, 20);
            this.Txt_valorUnitario.TabIndex = 20;
            this.Txt_valorUnitario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_valorUnitario_MaskInputRejected);
            // 
            // Txt_quantidadeDisponivel
            // 
            this.Txt_quantidadeDisponivel.Location = new System.Drawing.Point(308, 119);
            this.Txt_quantidadeDisponivel.Name = "Txt_quantidadeDisponivel";
            this.Txt_quantidadeDisponivel.Size = new System.Drawing.Size(109, 20);
            this.Txt_quantidadeDisponivel.TabIndex = 19;
            this.Txt_quantidadeDisponivel.ValidatingType = typeof(int);
            this.Txt_quantidadeDisponivel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_quantidadeDisponivel_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Valor unitário";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(308, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantidade disponível\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Txt_descricao
            // 
            this.Txt_descricao.Location = new System.Drawing.Point(52, 119);
            this.Txt_descricao.Multiline = true;
            this.Txt_descricao.Name = "Txt_descricao";
            this.Txt_descricao.Size = new System.Drawing.Size(123, 59);
            this.Txt_descricao.TabIndex = 12;
            this.Txt_descricao.TextChanged += new System.EventHandler(this.Txt_descricao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn_CadastrarProduto
            // 
            this.Btn_CadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_CadastrarProduto.ForeColor = System.Drawing.Color.Black;
            this.Btn_CadastrarProduto.Location = new System.Drawing.Point(192, 314);
            this.Btn_CadastrarProduto.Name = "Btn_CadastrarProduto";
            this.Btn_CadastrarProduto.Size = new System.Drawing.Size(98, 30);
            this.Btn_CadastrarProduto.TabIndex = 2;
            this.Btn_CadastrarProduto.Text = "Cadastrar";
            this.Btn_CadastrarProduto.UseVisualStyleBackColor = true;
            this.Btn_CadastrarProduto.Click += new System.EventHandler(this.Btn_CadastrarProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(103, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastre um produto";
            // 
            // Frm_CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(477, 424);
            this.Controls.Add(this.Pnl_CadastrarPessoa);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CadastrarProduto";
            this.Text = "Frm_CadastrarPessoa";
            this.Pnl_CadastrarPessoa.ResumeLayout(false);
            this.Pnl_CadastrarPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_CadastrarPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_CadastrarProduto;
        private System.Windows.Forms.MaskedTextBox Txt_valorUnitario;
        private System.Windows.Forms.MaskedTextBox Txt_quantidadeDisponivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_descricao;
        private System.Windows.Forms.Label label2;
    }
}