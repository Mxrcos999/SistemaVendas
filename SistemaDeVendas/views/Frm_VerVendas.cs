using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoVendas.views
{
    public partial class Frm_VerVendas : Form
    {
        public Frm_VerVendas()
        {
            InitializeComponent();
        }

        private void vendasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaVendaDataSet);

        }

        private void Frm_VerVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaVendaDataSet.vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.sistemaVendaDataSet.vendas);

        }
    }
}
