using Jogos.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos.Model.Repositories
{
    public class RepositoryCategoriaJogo : RepositoryBase<JogosCategoria>
    {
        public RepositoryCategoriaJogo(bool saveChanges = true) : base(saveChanges) 
        {
        
        }

    }
}
