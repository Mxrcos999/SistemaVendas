using projetoVendas.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoVendas
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Pnl_Conteudo.Controls.Clear();
            var frmProduto_vrb = new Frm_CadastrarProduto { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_Conteudo.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void Btn_Cadastrar_Produto_Click(object sender, EventArgs e)
        {
            this.Pnl_Conteudo.Controls.Clear();
            var frmProduto_vrb = new Frm_CadastrarCliente { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_Conteudo.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void Btn_Venda_Click(object sender, EventArgs e)
        {
            this.Pnl_Conteudo.Controls.Clear();
            Frm_CadastrarVenda frmProduto_vrb = new Frm_CadastrarVenda { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_Conteudo.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void Btn_VerProdutos_Click(object sender, EventArgs e)
        { 
            this.Pnl_Conteudo.Controls.Clear();
            Frm_VerProduto frmProduto_vrb = new Frm_VerProduto { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_Conteudo.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void Btn_VerCliente_Click(object sender, EventArgs e)
        {
            this.Pnl_Conteudo.Controls.Clear();
            Frm_VerPessoa frmPessoa_vrb = new Frm_VerPessoa { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPessoa_vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_Conteudo.Controls.Add(frmPessoa_vrb);
            frmPessoa_vrb.Show();
        }

        private void Btn_VerVenda_Click(object sender, EventArgs e)
        {
            this.Pnl_Conteudo.Controls.Clear();
            Frm_VerVendas frmVendas_vrb = new Frm_VerVendas { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmVendas_vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_Conteudo.Controls.Add(frmVendas_vrb);
            frmVendas_vrb.Show();
        }

      
    }
}
