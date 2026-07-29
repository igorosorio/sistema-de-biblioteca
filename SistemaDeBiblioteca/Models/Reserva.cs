using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeBiblioteca.Enums;

namespace SistemaDeBiblioteca.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public Usuario Responsavel { get; set; }
        public Livro Titulo { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataEncerramento { get; set; }
        public StatusReserva Status { get; set; }
    }
}
