using System;
using System.Collections.Generic;
using Restaurantes.Classes;

namespace Restaurantes
{
    class Program
    {
        private static List<Restaurante> Restaurantes = new List<Restaurante>();
        static void Main(string[] args)
        {
            string opcao = "";

            while (opcao != "X")
            {
                opcao = OpcaoUsuario();
                switch (opcao)
                {
                    case "1":
                        ListarRestaurantes();
                        continue;
                        case "2":
                        CriarRestaurante();
                        continue;
                        case "3":
                        AdicionarPrato();
                        continue;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        continue;
                }

                Console.WriteLine("Até a próxima!");
            }
        }

        private static string OpcaoUsuario()
        {
            Console.WriteLine("Cadastro de restaurantes");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Listar restaurantes");
            Console.WriteLine("2. Criar restaurante");
            Console.WriteLine("3. Criar prato");
            Console.WriteLine("X. Sair");
            return Console.ReadLine().ToUpper();
        }

        private static void ListarRestaurantes()
        {
            if (Restaurantes.Count == 0)
            {
                Console.WriteLine("Nenhum restaurante cadastrado");
                return;
            }

            Console.WriteLine("Lista de restaurantes:");
            int idRestaurante = 0;
            foreach (var restaurante in Restaurantes)
            {
                Console.WriteLine("ID: {0} - {1}", idRestaurante, restaurante);
                idRestaurante++;
            }
        }

private static void CriarRestaurante()
{
    Console.Write("Informe o nome do restaurante a criar: ");
string nomeRestaurante = Console.ReadLine();
Console.Write("Informe a hora de abertura: ");
int horaAbertura = int.Parse(Console.ReadLine());
Console.Write("Informe a hora de fechamento: ");
int horaFechamento = int.Parse(Console.ReadLine());
Restaurante restaurante = new Restaurante(nomeRestaurante);
restaurante.DefinirHorarioFuncionamento(horaAbertura, horaFechamento);
Restaurantes.Add(restaurante);
Console.WriteLine("Restaurante criado com sucesso!");
}

        private static void AdicionarPrato()
        {
            Console.Write("Qual é o nome do prato?");
            string nomePrato = Console.ReadLine();
            Prato prato = new Prato(nomePrato);
            Console.WriteLine("Informe os ingredientes, X para finalizar");

            while (true)
            {
                Console.Write("Nome do ingrediente: ");
                string nomeIngrediente = Console.ReadLine();
                if (nomeIngrediente.ToUpper() == "X") break;
                Console.Write("Qquantidad do ingrediente: ");
                int quantidadeIngrediente = int.Parse(Console.ReadLine());
                Ingrediente ingrediente = new Ingrediente(nomeIngrediente, quantidadeIngrediente);
                prato.AdicionarIngrediente(ingrediente);
            }

            Console.Write("Informe o id do restaurante: ");
            int idRestaurante = int.Parse(Console.ReadLine());
var restaurante = Restaurantes[idRestaurante];
restaurante.DefinirPratoPrincipal(prato);
Console.WriteLine("Prato adicionado com sucesso!");
        }
    }
}