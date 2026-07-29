using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeBiblioteca.Services;
using SistemaDeBiblioteca.Models;

namespace SistemaDeBiblioteca.Menus
{
    public class MenuLivro
    {
        public static void CadastrarLivro()
        {
            bool cadastro = false;

            do
            {
                Console.Clear();
                Console.WriteLine("== CADASTRO DE LIVRO ==\n");
                int id;
                do
                {
                    Console.Write("ID (Digite Um Valor Numérico): ");
                }
                while (!int.TryParse(Console.ReadLine(), out id));
                Console.Write("\nTítulo: ");
                string? titulo = Console.ReadLine(); //pode ser null ou numérico
                Console.Write("\nAutor: ");
                string? autor = Console.ReadLine(); //pode ser null ou numérico
                Console.Write("\nISBN: ");
                string? isbn = Console.ReadLine(); //pode ser null ou numérico
                int qtd;
                do
                {
                    Console.Write("\nQuantidade De Unidades (Digite Um Valor Numérico): ");
                }
                while (!int.TryParse(Console.ReadLine(), out qtd));

                cadastro = ServiceLivro.CadastrarLivro(id, titulo, autor, isbn, qtd);
                if (cadastro == true)
                    Console.WriteLine("Cadastro Concluído Com Sucesso!");
                else
                    Console.WriteLine("Algo Deu Errado. Tente novamente!");
            }
            while (cadastro == false);
        }
        public static void EditarLivro()
        {
            bool editar = false;

            do
            {
                Console.Clear();
                Console.WriteLine("== EDIÇÃO DE LIVRO ==\n");
            }
            while (editar == false);
        }
        public static void RemoverLivro()
        {
            bool remover = false;

            do
            {
                Console.Clear();
                Console.WriteLine("== REMOVER LIVRO ==\n");
                int id;
                do
                {
                    Console.Write("ID (Digite Um Valor Numérico): ");
                }
                while (!int.TryParse(Console.ReadLine(), out id));

                remover = ServiceLivro.RemoverLivro(id);
                if (remover == true)
                    Console.WriteLine("Remoção Concluída Com Sucesso!");
                else
                    Console.WriteLine("Algo Deu Errado. Tente novamente!");
            }
            while (remover == false);
        }
        public static void BuscarLivro()
        {
            Console.Clear();
            Console.WriteLine("== BUSCAR LIVRO ==\n");
            Console.Write("\nTítulo: ");
            string? titulo = Console.ReadLine(); //pode ser null ou numérico
            Console.Write("\nAutor: ");
            string? autor = Console.ReadLine(); //pode ser null ou numérico
            Console.Write("\nISBN: ");
            string? isbn = Console.ReadLine(); //pode ser null ou numérico

            ReadOnlyCollection<Livro>? livros = ServiceLivro.BuscarLivro(titulo, autor, isbn);

            if (livros == null || livros.Count == 0)
                Console.WriteLine("Não existem livros correspondentes para sua busca!");
            else
            {
                foreach (Livro livro in livros)
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                    Console.WriteLine($"{livro.Id} | {livro.Titulo} | {livro.Autor} | {livro.Isbn} | {livro.QtdDisponivel}");
                }
            }
        }
    }
}