
namespace projetoVendas.views
{
    partial class Frm_CadastrarCliente
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
            this.Pnl_CadastrarCliente = new System.Windows.Forms.Panel();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.Txt_data = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_sobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_CadastrarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_CadastrarCliente
            // 
            this.Pnl_CadastrarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.Pnl_CadastrarCliente.Controls.Add(this.Btn_Cadastrar);
            this.Pnl_CadastrarCliente.Controls.Add(this.Txt_cpf);
            this.Pnl_CadastrarCliente.Controls.Add(this.Txt_data);
            this.Pnl_CadastrarCliente.Controls.Add(this.label6);
            this.Pnl_CadastrarCliente.Controls.Add(this.Txt_email);
            this.Pnl_CadastrarCliente.Controls.Add(this.label5);
            this.Pnl_CadastrarCliente.Controls.Add(this.label4);
            this.Pnl_CadastrarCliente.Controls.Add(this.Txt_sobrenome);
            this.Pnl_CadastrarCliente.Controls.Add(this.label3);
            this.Pnl_CadastrarCliente.Controls.Add(this.Txt_nome);
            this.Pnl_CadastrarCliente.Controls.Add(this.label2);
            this.Pnl_CadastrarCliente.Controls.Add(this.label1);
            this.Pnl_CadastrarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_CadastrarCliente.Location = new System.Drawing.Point(0, 0);
            this.Pnl_CadastrarCliente.Name = "Pnl_CadastrarCliente";
            this.Pnl_CadastrarCliente.Size = new System.Drawing.Size(477, 424);
            this.Pnl_CadastrarCliente.TabIndex = 0;
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Cadastrar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(219, 346);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(100, 46);
            this.Btn_Cadastrar.TabIndex = 11;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // Txt_cpf
            // 
            this.Txt_cpf.Location = new System.Drawing.Point(327, 207);
            this.Txt_cpf.Mask = "000.000.000-00";
            this.Txt_cpf.Name = "Txt_cpf";
            this.Txt_cpf.Size = new System.Drawing.Size(86, 20);
            this.Txt_cpf.TabIndex = 10;
            // 
            // Txt_data
            // 
            this.Txt_data.Location = new System.Drawing.Point(98, 207);
            this.Txt_data.Name = "Txt_data";
            this.Txt_data.Size = new System.Drawing.Size(86, 20);
            this.Txt_data.TabIndex = 9;
            this.Txt_data.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(98, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data de nascimento";
            // 
            // Txt_email
            // 
            this.Txt_email.Location = new System.Drawing.Point(98, 281);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(86, 20);
            this.Txt_email.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(98, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(327, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF";
            // 
            // Txt_sobrenome
            // 
            this.Txt_sobrenome.Location = new System.Drawing.Point(327, 132);
            this.Txt_sobrenome.Name = "Txt_sobrenome";
            this.Txt_sobrenome.Size = new System.Drawing.Size(86, 20);
            this.Txt_sobrenome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(325, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sobrenome";
            // 
            // Txt_nome
            // 
            this.Txt_nome.Location = new System.Drawing.Point(98, 132);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(86, 20);
            this.Txt_nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(95, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastre um cliente";
            // 
            // Frm_CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 424);
            this.Controls.Add(this.Pnl_CadastrarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CadastrarCliente";
            this.Text = "Frm_CadastrarProduto";
            this.Pnl_CadastrarCliente.ResumeLayout(false);
            this.Pnl_CadastrarCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_CadastrarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.MaskedTextBox Txt_cpf;
        private System.Windows.Forms.MaskedTextBox Txt_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_sobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label label2;
    }
}