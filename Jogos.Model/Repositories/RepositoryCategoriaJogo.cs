using Jogos.Model.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jogos.Model.Repositories
{
    public class RepositoryJogoCategoria : RepositoryBase<JogosCategoria>
    {
        public RepositoryJogoCategoria(bool saveChanges = true) : base(saveChanges)
        {

        }

    }
}
