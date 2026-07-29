using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeBiblioteca.Enums;

namespace SistemaDeBiblioteca.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public Usuario Responsavel { get; set; }
        public Livro Titulo { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public StatusEmprestimo Status { get; set; }
    }
}
