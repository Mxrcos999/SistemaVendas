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
    public partial class Frm_CadastrarCliente : Form
    { 

        public Person cadastrarCliente { get; set; }
        
        public Frm_CadastrarCliente()
        {
            InitializeComponent();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                cadastrarCliente = new Person(Txt_nome.Text, Txt_sobrenome.Text, Txt_data.Text, Txt_cpf.Text, Txt_email.Text);
                var cadastra = new SQLServerClass();
                cadastra.conexao();
                if(cadastra.SQLVerificaUsuarioExistente(Txt_cpf.Text, Txt_email.Text))
                {
                    
                    MessageBox.Show("Cliente cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(cadastra.msg);
                }
                else
                {
                    MessageBox.Show("Usuario ja existe, insira um cpf ou email diferente");
                }
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(OrderException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         
        }
    }
}
