using Jogos.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos.Model.Repositories
{
    public class RepositoryCategoria : RepositoryBase<Categoria>
    {
        public RepositoryCategoria(bool saveChanges = true) : base(saveChanges) 
        {

        }
    }
}
