using Microsoft.VisualBasic;
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
    public partial class Frm_CadastrarVenda : Form
    {
        public decimal valortotal { get; set; }
        public Frm_CadastrarVenda()
        {
            InitializeComponent();
        }
        public void recebevalor(decimal valor)
        {
            valortotal = valor;

        }
        private void Cmb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Customer clientes in Utils.lista())
            {
//                Cmb_Cliente.Items.Add(clientes);

            }
        }

        private void Pnl_CadastrarVenda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_CadastrarVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaVendaDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.sistemaVendaDataSet.produtos);
            // TODO: esta linha de código carrega dados na tabela 'sistemaVendaDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.sistemaVendaDataSet.clientes);
            
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaVendaDataSet);

        }

        private void clientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_CadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                var cadastra = new SQLServerClass();
                if (cadastra.SQLCommandSelectCliente(Convert.ToInt32(Txt_IdCliente.Text)) && cadastra.SQLCommandSelecProdutos(Convert.ToInt32(Txt_IdProduto.Text), Convert.ToInt32(Txt_Quantidade.Text)))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"erro, {cadastra.msg}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
            catch (FormatException)
            {
                MessageBox.Show("Preencha os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        

            


        }
    }
}
