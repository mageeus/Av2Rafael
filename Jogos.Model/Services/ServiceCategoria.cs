using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogos.Model.Repositories;

namespace Jogos.Model.Services
{
    public class ServiceCategoria
    {
        public RepositoryCategoria oRepositoryCategoria { get; set; }

        public ServiceCategoria()
        {
            oRepositoryCategoria = new RepositoryCategoria();
        }
    }
}
