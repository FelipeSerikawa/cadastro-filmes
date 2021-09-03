using System;

namespace CadastroFilmes

{
    public class Filme: EntidadeBase
    {
        public string Genero { get; set; }
		public string Titulo { get; set; }
		public string Sinopse { get; set; }
		public int Ano { get; set; }
        public bool Excluido {get; set;}

        public Filme(int id, string genero, string titulo, string sinopse, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Sinopse = sinopse;
            this.Ano = ano;
        }



    }

}