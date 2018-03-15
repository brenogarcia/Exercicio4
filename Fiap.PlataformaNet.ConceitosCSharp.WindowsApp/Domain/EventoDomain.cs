using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Domain
{
    public class EventoDomain
    {
        public int Id { get; private set; }

        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public string Responsavel { get; set; }

        public EventoDomain() { }

        public EventoDomain(int id)
        {
            Id = id;
        }
    }
}
