namespace frmCadastroCliente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsbBuscaPorId = new System.Windows.Forms.Button();
            this.tsbExcluir = new System.Windows.Forms.Button();
            this.tsbCancelar = new System.Windows.Forms.Button();
            this.tsbSalvar = new System.Windows.Forms.Button();
            this.tsbNovo = new System.Windows.Forms.Button();
            this.BuscarPorId = new System.Windows.Forms.Label();
            this.tstId = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskCep = new System.Windows.Forms.TextBox();
            this.Uf = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.Label();
            this.Cep = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.Endereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tsbBuscaPorId
            // 
            this.tsbBuscaPorId.BackColor = System.Drawing.Color.Transparent;
            this.tsbBuscaPorId.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscaPorId.Image")));
            this.tsbBuscaPorId.Location = new System.Drawing.Point(536, 20);
            this.tsbBuscaPorId.Name = "tsbBuscaPorId";
            this.tsbBuscaPorId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbBuscaPorId.Size = new System.Drawing.Size(28, 30);
            this.tsbBuscaPorId.TabIndex = 77;
            this.tsbBuscaPorId.UseVisualStyleBackColor = false;
            this.tsbBuscaPorId.Click += new System.EventHandler(this.tsbBuscar_Click_1);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.Location = new System.Drawing.Point(134, 21);
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(28, 30);
            this.tsbExcluir.TabIndex = 76;
            this.tsbExcluir.UseVisualStyleBackColor = true;
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.Location = new System.Drawing.Point(95, 21);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(28, 30);
            this.tsbCancelar.TabIndex = 75;
            this.tsbCancelar.UseVisualStyleBackColor = true;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click_1);
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.Location = new System.Drawing.Point(59, 21);
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(28, 30);
            this.tsbSalvar.TabIndex = 74;
            this.tsbSalvar.UseVisualStyleBackColor = true;
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click_1);
            // 
            // tsbNovo
            // 
            this.tsbNovo.BackColor = System.Drawing.Color.Transparent;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.Location = new System.Drawing.Point(18, 21);
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbNovo.Size = new System.Drawing.Size(28, 30);
            this.tsbNovo.TabIndex = 73;
            this.tsbNovo.UseVisualStyleBackColor = false;
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click_1);
            // 
            // BuscarPorId
            // 
            this.BuscarPorId.AutoSize = true;
            this.BuscarPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPorId.Location = new System.Drawing.Point(176, 26);
            this.BuscarPorId.Name = "BuscarPorId";
            this.BuscarPorId.Size = new System.Drawing.Size(117, 20);
            this.BuscarPorId.TabIndex = 72;
            this.BuscarPorId.Text = "Buscar Por Id:";
            // 
            // tstId
            // 
            this.tstId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tstId.Location = new System.Drawing.Point(308, 21);
            this.tstId.MaxLength = 50;
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(222, 26);
            this.tstId.TabIndex = 71;
            this.tstId.TabStop = false;
            this.tstId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(429, 245);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(280, 27);
            this.txtCidade.TabIndex = 70;
            this.txtCidade.TabStop = false;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.Location = new System.Drawing.Point(430, 222);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(61, 20);
            this.Cidade.TabIndex = 69;
            this.Cidade.Text = "Cidade";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(19, 290);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(73, 20);
            this.Telefone.TabIndex = 68;
            this.Telefone.Text = "Telefone";
            // 
            // txtUf
            // 
            this.txtUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUf.Location = new System.Drawing.Point(725, 245);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(57, 26);
            this.txtUf.TabIndex = 67;
            this.txtUf.TabStop = false;
            this.txtUf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(18, 313);
            this.mskTelefone.MaxLength = 15;
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(151, 30);
            this.mskTelefone.TabIndex = 66;
            this.mskTelefone.TabStop = false;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(129, 245);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(280, 27);
            this.txtBairro.TabIndex = 65;
            this.txtBairro.TabStop = false;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskCep
            // 
            this.mskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.Location = new System.Drawing.Point(18, 245);
            this.mskCep.MaxLength = 9;
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(92, 27);
            this.mskCep.TabIndex = 64;
            this.mskCep.TabStop = false;
            this.mskCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Uf
            // 
            this.Uf.AutoSize = true;
            this.Uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uf.Location = new System.Drawing.Point(726, 222);
            this.Uf.Name = "Uf";
            this.Uf.Size = new System.Drawing.Size(31, 20);
            this.Uf.TabIndex = 63;
            this.Uf.Text = "UF";
            // 
            // Bairro
            // 
            this.Bairro.AutoSize = true;
            this.Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro.Location = new System.Drawing.Point(130, 222);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(55, 20);
            this.Bairro.TabIndex = 62;
            this.Bairro.Text = "Bairro";
            // 
            // Cep
            // 
            this.Cep.AutoSize = true;
            this.Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cep.Location = new System.Drawing.Point(19, 222);
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(43, 20);
            this.Cep.TabIndex = 61;
            this.Cep.Text = "CEP";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtId.Location = new System.Drawing.Point(18, 104);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(69, 26);
            this.txtId.TabIndex = 60;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(19, 80);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(22, 20);
            this.Id.TabIndex = 59;
            this.Id.Text = "Id";
            // 
            // Endereco
            // 
            this.Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.Location = new System.Drawing.Point(19, 148);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(100, 23);
            this.Endereco.TabIndex = 78;
            this.Endereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEndereco.Location = new System.Drawing.Point(18, 174);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(764, 26);
            this.txtEndereco.TabIndex = 58;
            this.txtEndereco.TabStop = false;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nome
            // 
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(118, 77);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 23);
            this.Nome.TabIndex = 79;
            this.Nome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.Location = new System.Drawing.Point(118, 104);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(664, 26);
            this.txtNome.TabIndex = 80;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.tsbBuscaPorId);
            this.Controls.Add(this.tsbExcluir);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbSalvar);
            this.Controls.Add(this.tsbNovo);
            this.Controls.Add(this.BuscarPorId);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.Uf);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.Cep);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tsbBuscaPorId;
        private System.Windows.Forms.Button tsbExcluir;
        private System.Windows.Forms.Button tsbCancelar;
        private System.Windows.Forms.Button tsbSalvar;
        private System.Windows.Forms.Button tsbNovo;
        private System.Windows.Forms.Label BuscarPorId;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox mskTelefone;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox mskCep;
        private System.Windows.Forms.Label Uf;
        private System.Windows.Forms.Label Bairro;
        private System.Windows.Forms.Label Cep;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
    }
}

