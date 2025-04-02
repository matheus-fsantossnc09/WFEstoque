namespace WFCadastroProduto
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            menuStrip = new MenuStrip();
            menuCadastrar = new ToolStripMenuItem();
            menuListar = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            pctImagem = new PictureBox();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctImagem).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { menuCadastrar, menuListar, menuSair });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuCadastrar
            // 
            menuCadastrar.Name = "menuCadastrar";
            menuCadastrar.Size = new Size(69, 20);
            menuCadastrar.Text = "Cadastrar";
            menuCadastrar.Click += menuCadastrar_Click;
            // 
            // menuListar
            // 
            menuListar.Name = "menuListar";
            menuListar.Size = new Size(47, 20);
            menuListar.Text = "Listar";
            // 
            // menuSair
            // 
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(38, 20);
            menuSair.Text = "Sair";
            // 
            // pctImagem
            // 
            pctImagem.Dock = DockStyle.Fill;
            pctImagem.Image = (Image)resources.GetObject("pctImagem.Image");
            pctImagem.Location = new Point(0, 24);
            pctImagem.Name = "pctImagem";
            pctImagem.Size = new Size(800, 426);
            pctImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pctImagem.TabIndex = 1;
            pctImagem.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pctImagem);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuCadastrar;
        private ToolStripMenuItem menuListar;
        private ToolStripMenuItem menuSair;
        private PictureBox pctImagem;
    }
}