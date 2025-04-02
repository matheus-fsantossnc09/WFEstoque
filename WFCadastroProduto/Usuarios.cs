﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public string? Login { get; set; }
        public string? Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        public static List<Usuario>
            ListaUsuarios = new List<Usuario>();

       
    }
}
