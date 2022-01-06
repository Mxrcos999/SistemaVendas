using Order;
using projetoVendas.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoVendas.views
{
    public partial class Frm_CadastrarProduto : Form
    {
        public Product cadastrarProduto { get; set; }
        public Frm_CadastrarProduto()
        {
            InitializeComponent();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                cadastrarProduto = new Product(Txt_descricao.Text, Txt_valorUnitario.Text,Txt_quantidadeDisponivel.Text);
                var cadastra = new SQLServerClass();
                cadastra.conexao();
                var teste = new OrderItem(Convert.ToInt32(Txt_quantidadeDisponivel.Text));
                if (cadastra.SQLCommandInsert($"INSERT INTO produtos (descricao, valor, quantidade) VALUES ('{Txt_descricao.Text}', {Txt_valorUnitario.Text}, {Txt_quantidadeDisponivel.Text})"))
                {
                    MessageBox.Show("Cadastro feito com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
       


        }

        private void Txt_quantidadeDisponivel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Txt_valorUnitario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_descricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
