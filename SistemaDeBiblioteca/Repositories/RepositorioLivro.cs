using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeBiblioteca.Models;

namespace SistemaDeBiblioteca.Repositories
{
    public class RepositorioLivro
    {
        private static Dictionary<int, Livro> Livros = new Dictionary<int, Livro>();
        public static void Adicionar(int id, Livro livro)
        {
            Livros.Add(id, livro);
        }
        public static void Remover(int id)
        {
            Livros.Remove(id);
        }
        public static ReadOnlyCollection<Livro> BuscarPorTitulo(string titulo)
        {
            List<Livro> livros = new();

            foreach (var livro in Livros)
            {
                if (livro.Value.Titulo == titulo)
                    livros.Add(livro.Value);
            }
            return livros.AsReadOnly();
        }
        public static ReadOnlyCollection<Livro> BuscarPorAutor(string autor)
        {
            List<Livro> livros = new();

            foreach (var livro in Livros)
            {
                if (livro.Value.Autor == autor)
                    livros.Add(livro.Value);
            }
            return livros.AsReadOnly();
        }
        public static ReadOnlyCollection<Livro> BuscarPorISBN(string isbn)
        {
            List<Livro> livros = new();

            foreach (var livro in Livros)
            {
                if (livro.Value.Isbn == isbn)
                    livros.Add(livro.Value);
            }
            return livros.AsReadOnly();
        }
    }
}