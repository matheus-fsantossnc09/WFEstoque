namespace WFCadastroProduto
{
    partial class FormCadProduto
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
            lblCodigo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            gpbStatus = new GroupBox();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblPreco = new Label();
            nudPreco = new NumericUpDown();
            nudQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            btnSalvar = new Button();
            mskCodido = new MaskedTextBox();
            gpbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 34);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 117);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 135);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(279, 23);
            txtNome.TabIndex = 2;
            // 
            // gpbStatus
            // 
            gpbStatus.Controls.Add(rdbInativo);
            gpbStatus.Controls.Add(rdbAtivo);
            gpbStatus.Location = new Point(330, 52);
            gpbStatus.Name = "gpbStatus";
            gpbStatus.Size = new Size(123, 118);
            gpbStatus.TabIndex = 4;
            gpbStatus.TabStop = false;
            gpbStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(6, 85);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(6, 41);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(12, 204);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(82, 15);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço Unitário";
            // 
            // nudPreco
            // 
            nudPreco.Location = new Point(12, 231);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(279, 23);
            nudPreco.TabIndex = 6;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(12, 305);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(279, 23);
            nudQuantidade.TabIndex = 8;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(12, 278);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 375);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(151, 46);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // mskCodido
            // 
            mskCodido.Location = new Point(12, 56);
            mskCodido.Mask = "9999";
            mskCodido.Name = "mskCodido";
            mskCodido.Size = new Size(286, 23);
            mskCodido.TabIndex = 10;
            // 
            // FormCadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(mskCodido);
            Controls.Add(btnSalvar);
            Controls.Add(nudQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(nudPreco);
            Controls.Add(lblPreco);
            Controls.Add(gpbStatus);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += FormCadProduto_Load;
            gpbStatus.ResumeLayout(false);
            gpbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private GroupBox gpbStatus;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblPreco;
        private NumericUpDown nudPreco;
        private NumericUpDown nudQuantidade;
        private Label lblQuantidade;
        private Button btnSalvar;
        private MaskedTextBox mskCodido;
    }
}