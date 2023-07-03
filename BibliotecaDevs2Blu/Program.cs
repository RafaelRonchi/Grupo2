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
            while (!flag)
            {
                Console.WriteLine("\n Bem vindo ao sistema Biblioteca");
                Biblioteca biblioteca = new Biblioteca("A");

                Console.WriteLine("\n O que desejas fazer: ");
                Console.WriteLine("\n 1 - Movimentação");
                Console.WriteLine("\n 2 - Cadastro");
                Console.WriteLine("\n 3 - Sair");

                string op = Console.ReadLine();

                switch (op)
                {

                    case "1":

                        Console.WriteLine("\n 1 - Realizar empréstimo: ");
                        Console.WriteLine("\n 2 - Finalizar empréstimo: ");
                        Console.WriteLine("\n 3 - Sair: ");
                        string op2 = Console.ReadLine();

                        switch (op2)
                        {

                            case "1":

                                Console.WriteLine("Nome Leitor: ");
                                string l = Console.ReadLine();
                                Leitor leit = new Leitor(l);
                                List<Leitor> listLeit = new List<Leitor>();
                                listLeit.Add(leit);
                                Console.WriteLine("\n Digite o código do livro: ");
                                int id2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("\n Digite o título do livro: ");
                                string nome2 = Console.ReadLine();

                                Livro liv = new Livro(id2, nome2);
                                List<Livro> listLivros = new List<Livro>();
                                listLivros.Add(liv);
                                Emprestimo emprestimo = new Emprestimo(listLeit, listLivros);
                                emprestimo.FazerEmprestimo(liv, leit);

                                break;

                            case "2":
                                Console.WriteLine("Encerrar Emprestimo");

                                Console.WriteLine("Nome do livro: ");
                                string l1 = Console.ReadLine();
                                Leitor leit1 = new Leitor(l1);
                                List<Leitor> listLeit1 = new List<Leitor>();

                                Console.WriteLine("\n Digite o código do livro: ");
                                int id1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n Digite o título do livro: ");
                                string nome1 = Console.ReadLine();
                                Livro liv1 = new Livro(id1, nome1);
                                List<Livro> listLivros1 = new List<Livro>();

                                Emprestimo emprestimo1 = new Emprestimo(listLeit1, listLivros1);
                                emprestimo1.EncerrarEmprestimo(liv1, leit1);
                                break;
                            case "3":
                                flag = true;
                                break;
                            default:
                                Console.WriteLine("Opção invalida");
                                break;
                        }
                        break;


                    case "2":

                        Console.WriteLine($"\n 1 - Adicionar livro" +
                                          $"\n 2 - Remover livro" +
                                          $"\n 3 - Listar livros" +
                                          $"\n 4 - Sair");



                        string opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1":


                                Console.WriteLine("\n Digite o código do livro: ");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n Digite o título do livro: ");
                                string nome = Console.ReadLine();
                                Livro livro1 = new Livro(id, nome);
                                biblioteca.AdicionarLivro(livro1);

                                break;
                            case "2":
                                Console.WriteLine("\n Digite o código do livro: ");
                                id = int.Parse(Console.ReadLine());
                                biblioteca.RemoverLivro(id);

                                break;
                            case "3":
                                biblioteca.ListarTodosLivros();
                                break;
                            case "4":
                                flag = true;
                                break;
                            default:
                                Console.WriteLine("Opção invalida");
                                break;
                        }
                        break;




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