using Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Domain;
using System;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Repository
{
    public class EventoRepository
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["BancoEventos"].ConnectionString;

        private static readonly Lazy<EventoRepository> lazy = new Lazy<EventoRepository>(() => new EventoRepository());

        public static EventoRepository Instance { get { return lazy.Value; } }

        private EventoRepository() { }

        public void SalvarEvento(EventoDomain evento)
        {
            using (var conexao = new SqlConnection(_connectionString))
            {
                conexao.Execute("Insert into TBEventos values(@data, @descricao, @responsavel)", evento);
            }
        }

        public List<EventoDomain> BuscarEvento()
        {
            var query = @" Select * from TBEventos";

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var listaEventos = sqlConnection.Query<EventoDomain>(query);

                return listaEventos.ToList();
            }
        }
    }
}
