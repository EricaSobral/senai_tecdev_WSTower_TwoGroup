﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webApiWDTower.Domains
{
    public partial class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        //[Required(ErrorMessage = "O e-mail do usuário é obrigatório!")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Apelido { get; set; }
        public byte[] Foto { get; set; }

        //[Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        //[DataType(DataType.Password)]
        //[StringLength(60, MinimumLength = 8, ErrorMessage = "A senha deve ter no mínimo 8 caracteres!")]
        public string Senha { get; set; }

        public Usuario UsuarioNavigation { get; set; }
    }
}