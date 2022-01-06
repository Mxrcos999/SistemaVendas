
namespace projetoVendas
{
    partial class Frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_CadastrarProduto = new System.Windows.Forms.Button();
            this.Btn_Cadastrar_Cliente = new System.Windows.Forms.Button();
            this.Btn_VerProdutos = new System.Windows.Forms.Button();
            this.Btn_Venda = new System.Windows.Forms.Button();
            this.Btn_VerVenda = new System.Windows.Forms.Button();
            this.Btn_VerCliente = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Pnl_menu = new System.Windows.Forms.Panel();
            this.Pnl_Conteudo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_menu.SuspendLayout();
            this.Pnl_Conteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_CadastrarProduto
            // 
            this.Btn_CadastrarProduto.FlatAppearance.BorderSize = 0;
            this.Btn_CadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CadastrarProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Btn_CadastrarProduto.ForeColor = System.Drawing.Color.Black;
            this.Btn_CadastrarProduto.Location = new System.Drawing.Point(0, 163);
            this.Btn_CadastrarProduto.Name = "Btn_CadastrarProduto";
            this.Btn_CadastrarProduto.Size = new System.Drawing.Size(162, 36);
            this.Btn_CadastrarProduto.TabIndex = 1;
            this.Btn_CadastrarProduto.Text = "Cadastrar produto";
            this.Btn_CadastrarProduto.UseVisualStyleBackColor = true;
            this.Btn_CadastrarProduto.Click += new System.EventHandler(this.Btn_CadastrarCliente_Click);
            // 
            // Btn_Cadastrar_Cliente
            // 
            this.Btn_Cadastrar_Cliente.FlatAppearance.BorderSize = 0;
            this.Btn_Cadastrar_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cadastrar_Cliente.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Btn_Cadastrar_Cliente.ForeColor = System.Drawing.Color.Black;
            this.Btn_Cadastrar_Cliente.Location = new System.Drawing.Point(3, 122);
            this.Btn_Cadastrar_Cliente.Name = "Btn_Cadastrar_Cliente";
            this.Btn_Cadastrar_Cliente.Size = new System.Drawing.Size(162, 36);
            this.Btn_Cadastrar_Cliente.TabIndex = 2;
            this.Btn_Cadastrar_Cliente.Text = "Cadastrar cliente";
            this.Btn_Cadastrar_Cliente.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar_Cliente.Click += new System.EventHandler(this.Btn_Cadastrar_Produto_Click);
            // 
            // Btn_VerProdutos
            // 
            this.Btn_VerProdutos.FlatAppearance.BorderSize = 0;
            this.Btn_VerProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_VerProdutos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Btn_VerProdutos.ForeColor = System.Drawing.Color.Black;
            this.Btn_VerProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_VerProdutos.Location = new System.Drawing.Point(0, 0);
            this.Btn_VerProdutos.Name = "Btn_VerProdutos";
            this.Btn_VerProdutos.Size = new System.Drawing.Size(162, 36);
            this.Btn_VerProdutos.TabIndex = 4;
            this.Btn_VerProdutos.Text = "Visualizar produto";
            this.Btn_VerProdutos.UseVisualStyleBackColor = true;
            this.Btn_VerProdutos.Click += new System.EventHandler(this.Btn_VerProdutos_Click);
            // 
            // Btn_Venda
            // 
            this.Btn_Venda.FlatAppearance.BorderSize = 0;
            this.Btn_Venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Venda.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Btn_Venda.ForeColor = System.Drawing.Color.Black;
            this.Btn_Venda.Location = new System.Drawing.Point(3, 204);
            this.Btn_Venda.Name = "Btn_Venda";
            this.Btn_Venda.Size = new System.Drawing.Size(162, 36);
            this.Btn_Venda.TabIndex = 3;
            this.Btn_Venda.Text = "Cadastrar venda";
            this.Btn_Venda.UseVisualStyleBackColor = true;
            this.Btn_Venda.Click += new System.EventHandler(this.Btn_Venda_Click);
            // 
            // Btn_VerVenda
            // 
            this.Btn_VerVenda.FlatAppearance.BorderSize = 0;
            this.Btn_VerVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_VerVenda.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Btn_VerVenda.ForeColor = System.Drawing.Color.Black;
            this.Btn_VerVenda.Location = new System.Drawing.Point(0, 81);
            this.Btn_VerVenda.Name = "Btn_VerVenda";
            this.Btn_VerVenda.Size = new System.Drawing.Size(162, 36);
            this.Btn_VerVenda.TabIndex = 6;
            this.Btn_VerVenda.Text = "Visualizar venda";
            this.Btn_VerVenda.UseVisualStyleBackColor = true;
            this.Btn_VerVenda.Click += new System.EventHandler(this.Btn_VerVenda_Click);
            // 
            // Btn_VerCliente
            // 
            this.Btn_VerCliente.FlatAppearance.BorderSize = 0;
            this.Btn_VerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_VerCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Btn_VerCliente.ForeColor = System.Drawing.Color.Black;
            this.Btn_VerCliente.Location = new System.Drawing.Point(3, 41);
            this.Btn_VerCliente.Name = "Btn_VerCliente";
            this.Btn_VerCliente.Size = new System.Drawing.Size(162, 36);
            this.Btn_VerCliente.TabIndex = 5;
            this.Btn_VerCliente.Text = "Visualizar cliente";
            this.Btn_VerCliente.UseVisualStyleBackColor = true;
            this.Btn_VerCliente.Click += new System.EventHandler(this.Btn_VerCliente_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Sair.ForeColor = System.Drawing.Color.Black;
            this.Btn_Sair.Location = new System.Drawing.Point(0, 395);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(162, 29);
            this.Btn_Sair.TabIndex = 8;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Pnl_menu
            // 
            this.Pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(114)))));
            this.Pnl_menu.Controls.Add(this.Btn_CadastrarProduto);
            this.Pnl_menu.Controls.Add(this.Btn_Sair);
            this.Pnl_menu.Controls.Add(this.Btn_Cadastrar_Cliente);
            this.Pnl_menu.Controls.Add(this.Btn_VerVenda);
            this.Pnl_menu.Controls.Add(this.Btn_Venda);
            this.Pnl_menu.Controls.Add(this.Btn_VerCliente);
            this.Pnl_menu.Controls.Add(this.Btn_VerProdutos);
            this.Pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.Pnl_menu.Name = "Pnl_menu";
            this.Pnl_menu.Size = new System.Drawing.Size(162, 424);
            this.Pnl_menu.TabIndex = 9;
            // 
            // Pnl_Conteudo
            // 
            this.Pnl_Conteudo.Controls.Add(this.pictureBox1);
            this.Pnl_Conteudo.Controls.Add(this.label1);
            this.Pnl_Conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Conteudo.Location = new System.Drawing.Point(162, 0);
            this.Pnl_Conteudo.Name = "Pnl_Conteudo";
            this.Pnl_Conteudo.Size = new System.Drawing.Size(477, 424);
            this.Pnl_Conteudo.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaDeVendas.Properties.Resources.produtos;
            this.pictureBox1.Location = new System.Drawing.Point(170, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(150, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projeto de vendas";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 424);
            this.Controls.Add(this.Pnl_Conteudo);
            this.Controls.Add(this.Pnl_menu);
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.Pnl_menu.ResumeLayout(false);
            this.Pnl_Conteudo.ResumeLayout(false);
            this.Pnl_Conteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_CadastrarProduto;
        private System.Windows.Forms.Button Btn_Cadastrar_Cliente;
        private System.Windows.Forms.Button Btn_VerProdutos;
        private System.Windows.Forms.Button Btn_Venda;
        private System.Windows.Forms.Button Btn_VerVenda;
        private System.Windows.Forms.Button Btn_VerCliente;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Panel Pnl_menu;
        private System.Windows.Forms.Panel Pnl_Conteudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

