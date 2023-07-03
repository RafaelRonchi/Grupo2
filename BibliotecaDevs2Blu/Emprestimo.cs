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
        public List<Livro> Livros { get; set; }

        public Emprestimo(List<Leitor> leitores,List<Livro> livros)
        {
            Leitores = leitores;
            Livros = livros;
        }

        public void FazerEmprestimo(Livro livro,Leitor leitor)
        {
            Leitores.Add(leitor);
            Livros.Add(livro);
            leitor.EmprestarLivro(this);
        }

        public void EncerrarEmprestimo(Livro livro,Leitor leitor)
        {
            Leitores.Remove(leitor);
            Livros.Remove(livro);
            leitor.DevolverLivro(this);
        }
    }
}

