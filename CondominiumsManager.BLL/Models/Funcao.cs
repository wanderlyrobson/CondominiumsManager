﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumsManager.BLL.Models
{
    public class Funcao : IdentityRole<string>
    {
        public object Id { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
    }
}
