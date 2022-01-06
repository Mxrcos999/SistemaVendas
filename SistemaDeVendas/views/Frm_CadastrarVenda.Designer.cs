
namespace projetoVendas.views
{
    partial class Frm_CadastrarVenda
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
            this.components = new System.ComponentModel.Container();
            this.Pnl_CadastrarVenda = new System.Windows.Forms.Panel();
            this.Btn_CadastrarProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Quantidade = new System.Windows.Forms.TextBox();
            this.Txt_IdProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_IdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaVendaDataSet = new SistemaDeVendas.SistemaVendaDataSet();
            this.clientesTableAdapter = new SistemaDeVendas.SistemaVendaDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new SistemaDeVendas.SistemaVendaDataSetTableAdapters.TableAdapterManager();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new SistemaDeVendas.SistemaVendaDataSetTableAdapters.produtosTableAdapter();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_CadastrarVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_CadastrarVenda
            // 
            this.Pnl_CadastrarVenda.BackColor = System.Drawing.Color.AliceBlue;
            this.Pnl_CadastrarVenda.Controls.Add(this.produtosDataGridView);
            this.Pnl_CadastrarVenda.Controls.Add(this.clientesDataGridView);
            this.Pnl_CadastrarVenda.Controls.Add(this.Btn_CadastrarProduto);
            this.Pnl_CadastrarVenda.Controls.Add(this.label4);
            this.Pnl_CadastrarVenda.Controls.Add(this.Txt_Quantidade);
            this.Pnl_CadastrarVenda.Controls.Add(this.Txt_IdProduto);
            this.Pnl_CadastrarVenda.Controls.Add(this.label3);
            this.Pnl_CadastrarVenda.Controls.Add(this.Txt_IdCliente);
            this.Pnl_CadastrarVenda.Controls.Add(this.label2);
            this.Pnl_CadastrarVenda.Controls.Add(this.label1);
            this.Pnl_CadastrarVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_CadastrarVenda.Location = new System.Drawing.Point(0, 0);
            this.Pnl_CadastrarVenda.Name = "Pnl_CadastrarVenda";
            this.Pnl_CadastrarVenda.Size = new System.Drawing.Size(477, 424);
            this.Pnl_CadastrarVenda.TabIndex = 0;
            this.Pnl_CadastrarVenda.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_CadastrarVenda_Paint);
            // 
            // Btn_CadastrarProduto
            // 
            this.Btn_CadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_CadastrarProduto.ForeColor = System.Drawing.Color.Black;
            this.Btn_CadastrarProduto.Location = new System.Drawing.Point(169, 271);
            this.Btn_CadastrarProduto.Name = "Btn_CadastrarProduto";
            this.Btn_CadastrarProduto.Size = new System.Drawing.Size(98, 30);
            this.Btn_CadastrarProduto.TabIndex = 9;
            this.Btn_CadastrarProduto.Text = "Cadastrar";
            this.Btn_CadastrarProduto.UseVisualStyleBackColor = true;
            this.Btn_CadastrarProduto.Click += new System.EventHandler(this.Btn_CadastrarProduto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Escolha uma quantidade de produtos valida";
            // 
            // Txt_Quantidade
            // 
            this.Txt_Quantidade.Location = new System.Drawing.Point(250, 219);
            this.Txt_Quantidade.Name = "Txt_Quantidade";
            this.Txt_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.Txt_Quantidade.TabIndex = 7;
            // 
            // Txt_IdProduto
            // 
            this.Txt_IdProduto.Location = new System.Drawing.Point(250, 166);
            this.Txt_IdProduto.Name = "Txt_IdProduto";
            this.Txt_IdProduto.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdProduto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite um codigo de um produto valido";
            // 
            // Txt_IdCliente
            // 
            this.Txt_IdCliente.Location = new System.Drawing.Point(12, 166);
            this.Txt_IdCliente.Name = "Txt_IdCliente";
            this.Txt_IdCliente.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite um codigo de cliente valido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastre uma venda";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.sistemaVendaDataSet;
            // 
            // sistemaVendaDataSet
            // 
            this.sistemaVendaDataSet.DataSetName = "SistemaVendaDataSet";
            this.sistemaVendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaDeVendas.SistemaVendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AutoGenerateColumns = false;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.clientesDataGridView.DataSource = this.clientesBindingSource;
            this.clientesDataGridView.Location = new System.Drawing.Point(12, 62);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(232, 98);
            this.clientesDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.sistemaVendaDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AutoGenerateColumns = false;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.produtosDataGridView.DataSource = this.produtosBindingSource;
            this.produtosDataGridView.Location = new System.Drawing.Point(250, 62);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.Size = new System.Drawing.Size(224, 98);
            this.produtosDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Frm_CadastrarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 424);
            this.Controls.Add(this.Pnl_CadastrarVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CadastrarVenda";
            this.Text = "Frm_CadastrarVenda";
            this.Load += new System.EventHandler(this.Frm_CadastrarVenda_Load);
            this.Pnl_CadastrarVenda.ResumeLayout(false);
            this.Pnl_CadastrarVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_CadastrarVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SistemaDeVendas.SistemaVendaDataSet sistemaVendaDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private SistemaDeVendas.SistemaVendaDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private SistemaDeVendas.SistemaVendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox Txt_IdProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_IdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Quantidade;
        private System.Windows.Forms.Button Btn_CadastrarProduto;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private SistemaDeVendas.SistemaVendaDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}