using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDevs2Blu
{
    public class Emprestimo
    {
        public List<Leitor> Leitores { get; set; }
        public List<Livro> livros { get; set; }

        public Emprestimo(List<Leitor> leitores, List<Livro> livros)
        {
            Leitores = leitores;
            this.livros = livros;
        }

        public void FazerEmprestimo(Livro livro, Leitor leitor)
        {
            Leitores.Add(leitor);
            this.livros.Add(livro);
            leitor.EmprestarLivro(this);
        }

        public void EncerrarEmprestimo(Livro livro, Leitor leitor)
        {
            Leitores.Remove(leitor);
            this.livros.Remove(livro);
            leitor.DevolverLivro(this);
        }
    }
}

