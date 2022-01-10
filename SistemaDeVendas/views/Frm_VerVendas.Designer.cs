
namespace projetoVendas.views
{
    partial class Frm_VerVendas
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
            this.Pnl_VerVendas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vendasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaVendaDataSet = new SistemaDeVendas.SistemaVendaDataSet();
            this.vendasTableAdapter = new SistemaDeVendas.SistemaVendaDataSetTableAdapters.vendasTableAdapter();
            this.tableAdapterManager = new SistemaDeVendas.SistemaVendaDataSetTableAdapters.TableAdapterManager();
            this.Pnl_VerVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_VerVendas
            // 
            this.Pnl_VerVendas.BackColor = System.Drawing.Color.AliceBlue;
            this.Pnl_VerVendas.Controls.Add(this.label1);
            this.Pnl_VerVendas.Controls.Add(this.vendasDataGridView);
            this.Pnl_VerVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_VerVendas.Location = new System.Drawing.Point(0, 0);
            this.Pnl_VerVendas.Name = "Pnl_VerVendas";
            this.Pnl_VerVendas.Size = new System.Drawing.Size(488, 424);
            this.Pnl_VerVendas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendas cadastradas";
            // 
            // vendasDataGridView
            // 
            this.vendasDataGridView.AutoGenerateColumns = false;
            this.vendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vendasDataGridView.DataSource = this.vendasBindingSource;
            this.vendasDataGridView.Location = new System.Drawing.Point(12, 50);
            this.vendasDataGridView.Name = "vendasDataGridView";
            this.vendasDataGridView.Size = new System.Drawing.Size(456, 220);
            this.vendasDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "idCliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "idProduto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuantidadeProduto";
            this.dataGridViewTextBoxColumn4.HeaderText = "QuantidadeProduto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ValorTotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "ValorTotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.sistemaVendaDataSet;
            // 
            // sistemaVendaDataSet
            // 
            this.sistemaVendaDataSet.DataSetName = "SistemaVendaDataSet";
            this.sistemaVendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaDeVendas.SistemaVendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendasTableAdapter = this.vendasTableAdapter;
            // 
            // Frm_VerVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 424);
            this.Controls.Add(this.Pnl_VerVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_VerVendas";
            this.Text = "Frm_VerVendas";
            this.Load += new System.EventHandler(this.Frm_VerVendas_Load);
            this.Pnl_VerVendas.ResumeLayout(false);
            this.Pnl_VerVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVendaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_VerVendas;
        private SistemaDeVendas.SistemaVendaDataSet sistemaVendaDataSet;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private SistemaDeVendas.SistemaVendaDataSetTableAdapters.vendasTableAdapter vendasTableAdapter;
        private SistemaDeVendas.SistemaVendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vendasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
    }
}