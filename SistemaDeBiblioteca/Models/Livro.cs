using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeBiblioteca.Models
{
    public class Livro
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string Isbn { get; private set; } //ISBN = International Standard Book Number
        public int QtdTotal { get; set; }
        public int QtdDisponivel { get; set; }

        public Livro(int id, string titulo, string autor, string isbn, int qtdTotal)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Isbn = isbn;
            QtdTotal = qtdTotal;
            QtdDisponivel = qtdTotal;
        }
    }
}
