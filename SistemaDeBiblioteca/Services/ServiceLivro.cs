using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeBiblioteca.Models;
using SistemaDeBiblioteca.Repositories;

namespace SistemaDeBiblioteca.Services
{
    public class ServiceLivro
    {
        public static bool CadastrarLivro(int id, string titulo, string autor, string isbn, int qtd)
        {
            // validar o formato do ISBN
            if (id <= 0 || string.IsNullOrWhiteSpace(titulo) || titulo is double || string.IsNullOrWhiteSpace(autor) || autor is double || string.IsNullOrWhiteSpace(isbn) || qtd <= 0)
                return false;
            else
            {
                //cria o objeto, adiciona ao repositório e serializa
                //obs.: depois, tornar automática a definição do id
                RepositorioLivro.Adicionar(id, new Livro(id, titulo, autor, isbn, qtd));
                return true;
            }
        }
        public static bool RemoverLivro(int id)
        {
            if (id <= 0)
                return false;
            else
            {
                RepositorioLivro.Remover(id);
                return true;
            }
        }
        public static ReadOnlyCollection<Livro>? BuscarLivro(string titulo, string autor, string isbn)
        {
            if (!string.IsNullOrWhiteSpace(titulo))
                return RepositorioLivro.BuscarPorTitulo(titulo);
            else if (!string.IsNullOrWhiteSpace(autor))
                return RepositorioLivro.BuscarPorAutor(autor);
            else if (string.IsNullOrWhiteSpace(isbn))
                return RepositorioLivro.BuscarPorISBN(isbn);
            else
                return null;

        }
    }
}
