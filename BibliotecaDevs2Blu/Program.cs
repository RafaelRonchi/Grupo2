using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDevs2Blu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            while (flag)
            {
                Console.WriteLine("\n Bem vindo ao sistema Biblioteca");
                Biblioteca biblioteca = new Biblioteca();

                Console.WriteLine("\n O que desejas fazer: ");
                Console.WriteLine("\n 1 - Movimentação");
                Console.WriteLine("\n 2 - Cadastro");

                string op = Console.ReadLine();

                switch (op)
                {

                    case "1":

                        Console.WriteLine("\n 1 - Realizar empréstimo: ");
                        Console.WriteLine("\n 2 - Finalizar empréstimo: ");
                        string op2 = Console.ReadLine();

                        switch (op2)
                        {

                            case "1":
                            
                                
                                Emprestimo emprestimo = new Emprestimo();
                            
                            
                            default:
                        break;
                }

                Livro livro1 = new Livro(id,nome);
                biblioteca.Acervo.Add(livro1);
                break;

                    case "2":

                Console.WriteLine($"\n 1 - Adicionar livro" +
                                  $"\n 2 - Remover livro" +
                                  $"\n 3 - Listar livros");



                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\n Digite o código do livro: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n Digite o título do livro: ");
                        string nome = Console.ReadLine();
                        Livro livro1 = new Livro(id,nome);
                        biblioteca.Acervo.Add(livro1);

                        break;
                    case "2":
                        Console.WriteLine("\n Digite o código do livro: ");
                        id = int.Parse(Console.ReadLine());
                        biblioteca.RemoverLivro(id);

                        break;
                    case "3":
                        biblioteca.ListarTodosLivros();
                        break;
                    default:
                        break;
                }
                break;



                default:
                }











        }
        Console.ReadKey();
        }
}
}

/*Adicionar um novo livro à biblioteca;
Excluir um livro da biblioteca;
Listar todos os livros da biblioteca;
Realizar o empréstimo de um livro para um usuário;
Registrar a devolução de um livro.
*/