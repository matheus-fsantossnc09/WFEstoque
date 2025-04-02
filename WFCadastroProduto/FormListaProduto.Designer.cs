namespace WFCadastroProduto
{
    partial class FormListaProduto
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
            dtgListaProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgListaProdutos).BeginInit();
            SuspendLayout();
            // 
            // dtgListaProdutos
            // 
            dtgListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaProdutos.Dock = DockStyle.Fill;
            dtgListaProdutos.Location = new Point(0, 0);
            dtgListaProdutos.Name = "dtgListaProdutos";
            dtgListaProdutos.Size = new Size(431, 373);
            dtgListaProdutos.TabIndex = 0;
            dtgListaProdutos.CellContentClick += dtgListaProdutos_CellContentClick;
            // 
            // FormListaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 373);
            Controls.Add(dtgListaProdutos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListaProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Produtos";
            ((System.ComponentModel.ISupportInitialize)dtgListaProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgListaProdutos;
    }
}