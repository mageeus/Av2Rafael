using Jogos.Model.Models;
using Jogos.Models;

namespace Jogos.ViewModel
{
    public class JogoCategoriaVM
    {
        public int JogoCategoriaId { get; set; }

        public int JogoId { get; set; }
        
        public string Jogo { get; set; }

        public int CategoriaId { get; set; }

        public string Categoria { get; set; }

        public List<Model.Models.JogosCategoria> ListaJogoCategoria { get; set; }

        public JogoCategoriaVM() 
        { 
            
        }
        /*
        public static JogoCategoriaVM SelecionarJogo(int jogoCategoriaId)
        {
            var db = new JogosDBContext();
            var jogoCategoria = db.JogosCategoria.Find(jogoCategoriaId);

            return new JogoCategoriaVM
            {
                Jogo = db.Jogos.Find(jogoCategoria.JogoId)!.Nome,
                Categoria = db.Categoria.Find(jogoCategoria.CategoriaId)!.Nome


            };
        }
        */
        
        public static List<JogoCategoriaVM> SelecionarJogo(int jogoId)
        {
            var db = new Model.Models.JogosDBContext();
            var jogoCategorias = db.JogosCategoria.Where(jc => jc.JogoId == jogoId).ToList();

            var categoriasDoJogo = new List<JogoCategoriaVM>();

            foreach (var jogoCategoria in jogoCategorias)
            {
                categoriasDoJogo.Add(new JogoCategoriaVM
                {
                    JogoCategoriaId = jogoCategoria.JogoCategoriaId,
                    JogoId = db.Jogos.Find(jogoCategoria.JogoId)!.JogoId,
                    Jogo = db.Jogos.Find(jogoCategoria.JogoId)!.Nome,
                    CategoriaId = db.Categoria.Find(jogoCategoria.CategoriaId)!.CategoriaId,
                    Categoria = db.Categoria.Find(jogoCategoria.CategoriaId)!.Nome
                });
            }

            return categoriasDoJogo;
        }
        
        /*
        internal static List<JogoCategoriaVM> ListarTodos()
        {
            var db = new JogosDBContext();

            var jogosCategorias = db.JogosCategoria.ToList();
            var listaRetorno = new List<JogoCategoriaVM>();

            foreach(var item in jogosCategorias)
            {
                var listaJogos = new List<Jogo>();
                listaJogos = Jogo.
            }
        }*/
        
    }
}