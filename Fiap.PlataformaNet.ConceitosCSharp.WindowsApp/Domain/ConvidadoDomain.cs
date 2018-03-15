using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Domain
{
    public class ConvidadoDomain
    {
        public int Id { get; private set; }

        public int IdEvento { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public ConvidadoDomain() { }

        public ConvidadoDomain(int id)
        {
            Id = id;
        }
    }
}
