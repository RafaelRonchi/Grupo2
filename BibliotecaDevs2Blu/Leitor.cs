using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDevs2Blu
{
    public class Leitor
    {
        public string Nome { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }
        public Leitor(string nome)
        {
            Nome = nome;
            Emprestimos = new List<Emprestimo>();
        }
        public void EmprestarLivro(Emprestimo livro)
        {
            Emprestimos.Add(livro);
        }
        public void DevolverLivro(Emprestimo livro)
        {
            Emprestimos.Remove(livro);
        }
    }
}
