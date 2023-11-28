using Jogos.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos.Model.Services
{
    public class ServiceJogo
    {
        public RepositoryJogo oRepositoryJogo { get; set; }
        public ServiceJogo()
        {
            oRepositoryJogo = new RepositoryJogo();
        }

    }
}
