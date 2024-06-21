using ControleDeVinil.Shared.Modelos;

namespace ControleDeVinil.Shared.Dados
{
    public class DAL
    {
        private readonly Contexto context;

        public List<Artista> Listar()
        {
            var lista = new List<Artista>
            {
                new Artista {Id = 1, Nome = "Luiz Felipe", Bio = "Autor de livro infantil", FotoPerfil = ""}
            };
            return lista;

        }

    }
}
