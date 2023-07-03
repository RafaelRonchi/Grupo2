using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDevs2Blu
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        public List<Livro> Acervo { get; set; }



        public Biblioteca(string nome)
        {
            Nome = nome;
            Acervo = new List<Livro>();
        }

        public Biblioteca()
        {
        }

        public void AdicionarLivro(Livro livro)
        {
            Acervo.Add(livro);
        }

        public void RemoverLivro(int id)
        {
            Acervo.RemoveAll(l => l.Id == id);
        }

        public void ListarTodosLivros()
        {
            foreach (Livro L in Acervo)
            {
                Console.WriteLine(L.Titulo);
            }
        }

    }
}
