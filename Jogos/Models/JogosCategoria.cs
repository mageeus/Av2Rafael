﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Jogos.Models;

public partial class JogosCategoria
{
    public int JogoCategoriaId { get; set; }

    public int? JogoId { get; set; }

    public int? CategoriaId { get; set; }

    public virtual Categoria Categoria { get; set; }

    public virtual Jogo Jogo { get; set; }
}