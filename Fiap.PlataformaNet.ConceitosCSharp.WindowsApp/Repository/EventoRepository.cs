using Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Repository
{
    class EventoRepository : IBaseRepository<EventoDomain, int>
    {
        private string _conn = ConfigurationManager.AppSettings.Get("BancoEventos");

        private static readonly Lazy<EventoRepository> lazy = new Lazy<EventoRepository>(() => new EventoRepository());

        public static EventoRepository Instance { get { return lazy.Value; } }

        private EventoRepository() { }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventoDomain> FindAll()
        {
            throw new NotImplementedException();
        }

        public EventoDomain FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(EventoDomain domain)
        {
            using (var conn = new SqlConnection(_conn))
            {
                conn.ExecuteScalar("insert", domain);
            }
                return true;
        }

        public bool Update(EventoDomain domain)
        {
            throw new NotImplementedException();
        }
    }
}
