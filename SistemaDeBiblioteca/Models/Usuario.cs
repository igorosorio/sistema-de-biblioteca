using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeBiblioteca.Enums;

namespace SistemaDeBiblioteca.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF {  get; set; }
        public StatusUsuario Status { get; set; }
    }
}
