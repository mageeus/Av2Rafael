using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogos.Model.Repositories;

namespace Jogos.Model.Services
{
    public class ServiceJogoCategoria
    {
        public RepositoryJogoCategoria oRepositoryJogoCategoria { get; set; }
        public RepositoryCategoria oRepositoryCategoria { get; set; }
        public RepositoryJogo oRepositoryJogo { get; set; }

        public ServiceJogoCategoria()
        {
            oRepositoryJogoCategoria = new RepositoryJogoCategoria();
            oRepositoryCategoria = new RepositoryCategoria();
            oRepositoryJogo = new RepositoryJogo();
        }
    }
}
