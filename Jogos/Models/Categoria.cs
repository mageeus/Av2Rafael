﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Jogos.Models;

public partial class Categoria
{
    public int CategoriaId { get; set; }

    public string Nome { get; set; }

    public virtual ICollection<JogosCategoria> JogosCategoria { get; set; } = new List<JogosCategoria>();
}