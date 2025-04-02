namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario usuarios = new Usuario();
            usuarios.Id = 1;
            usuarios.Login = "Sem";
            usuarios.Senha = "Abc";
            usuarios.Nome = "Administrador";
            usuarios.DataCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(usuarios);

            usuarios = new Usuario();
            usuarios.Id = 2;
            usuarios.Login = "Com";
            usuarios.Senha = "Adc";
            usuarios.Nome = "Usuario";
            usuarios.DataCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(usuarios);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            foreach (Usuario us in Usuario.ListaUsuarios)
            {
                if (us.Login == txtLogin.Text && us.Senha == txtSenha.Text)
                {
                    FormMenu from = new FormMenu();
                    from.ShowDialog();
                    return;
                }
            }
            Erro("Usuario não autenticado");
        }
        private void Erro(string messagem)
        {
            MessageBox.Show(messagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogar_Click(sender, e);
        }
    }
}
