using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Domain;
using Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Repository;

namespace Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Business
{
    public class EventoManager
    {
        internal static void SalvarEvento(EventoDomain evento)
        {
            EventoRepository.Instance.SalvarEvento(evento);
        }

        internal static List<EventoDomain> BuscarEvento()
        {
            var listaEvento = new List<EventoDomain>();

            listaEvento = EventoRepository.Instance.BuscarEvento();

            return listaEvento;
        }
    }
}
