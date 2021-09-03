using System;
using System.Collections.Generic;
//public Filme(int id, Genero genero, string titulo, string sinopse, int ano)
namespace CadastroFilmes
{
    class Program
    {
        static List<Filme> filmes = new List<Filme>();
        static void Main(string[] args)
        {
            string genero, titulo, sinopse;

            string continuar = "s";
            int opcao, id, ano;
            int qtde = 0;
            int idExc, idAtu, opAtu;
         

            while (continuar == "s")
            {
                Console.Clear();
                Console.WriteLine("\n[1] Listar filmes\n[2] Cadastrar filme\n[3] Excluir filme\n[4] Atualizar filme");
                Console.Write("\nOpção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Opção 1 selecionada!");
                        foreach (Filme f in filmes)
                        {

                            Console.WriteLine("\nTitulo: {0}\nID: {1}\nGenero: {2}\nAno: {3}\nSinopse: {4}\nExcluído: {5}\n", f.Titulo, f.Id, f.Genero, f.Ano, f.Sinopse, f.Excluido);
                          
                        }
                        Console.Write("Continuar? [s/n]: ");
                        continuar = Console.ReadLine();
                        break;
                    case 2:
                        qtde = filmes.Count;
                        id = qtde + 1;
                        Console.WriteLine("Opção 2 selecionada!");
                        Console.Write("Titulo: ");
                        titulo = Console.ReadLine();
                        Console.Write("Genero: ");
                        genero = Console.ReadLine();
                        Console.Write("Ano: ");
                        ano = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sinopse: ");
                        sinopse = Console.ReadLine();

                        filmes.Add(new Filme(id, genero, titulo, sinopse, ano));

                        Console.Write("Continuar? [s/n]: ");
                        continuar = Console.ReadLine();
                        break;

                    case 3:                       
                        Console.Write("ID de exclusão: ");
                        idExc = Convert.ToInt32(Console.ReadLine());
                        
                        

                        foreach (Filme f in filmes)
                        {
                            if (f.Id == idExc)
                            {
                                f.Excluido = true;
                            }
                                                      
                        }
                        Console.Write("Continuar? [s/n]: ");
                        continuar = Console.ReadLine();
                        break;

                    case 4:

                        Console.Write("ID de atualização: ");
                        idAtu = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n[1] Titulo\n[2] Genero\n[3] Ano\n[4] Sinopse\n");
                        Console.Write("O que você deseja atualizar? ");
                        opAtu = Convert.ToInt32(Console.ReadLine());


                        foreach (Filme f in filmes)
                        {
                            if (f.Id == idAtu)
                            {
                                switch (opAtu)
                                {
                                    case 1:
                                        Console.Write("Novo titulo: ");
                                        f.Titulo = Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.Write("Novo genero: ");
                                        f.Genero = Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.Write("Novo ano: ");
                                        f.Ano = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    case 4:
                                        Console.Write("Nova sinopse: ");
                                        f.Sinopse = Console.ReadLine();
                                        break;
                                }
                            }
                                                      
                        }
                        Console.Write("Continuar? [s/n]: ");
                        continuar = Console.ReadLine();
                        break;
                }

            }

            
          
            
        }
    }
}
