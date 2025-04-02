﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormCadProduto : Form
    {
        public FormCadProduto()
        {
            InitializeComponent();
        }
        private void Erro(string messagem)
        {
            MessageBox.Show(messagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool NaoPreenchido()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
                return true;
            if (rdbAtivo.Checked == false && rdbInativo.Checked == false)
                return true;
            if (nudPreco.Value <= 0)
                return true;
            if (nudQuantidade.Value <= 0)
                return true;

            return false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (NaoPreenchido() == true)
            {
                Erro("Campos não preenchidos");
                return;
            }

        }

        private void FormCadProduto_Load(object sender, EventArgs e)
        {
            int totalLista = Produto.ListaProdutos.Count;
            int novoCodigo = totalLista + 1; 
            mskCodido.Text = novoCodigo.ToString("D4");
        }
    }
}
