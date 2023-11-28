using Jogos.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos.Model.Repositories
{
    public class RepositoryJogo : RepositoryBase<Jogo>
    {
        public RepositoryJogo(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}
