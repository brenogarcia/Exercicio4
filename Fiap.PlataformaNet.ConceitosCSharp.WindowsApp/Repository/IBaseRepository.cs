using Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.ConceitosCSharp.WindowsApp.Repository
{
    public interface IBaseRepository<T, K> where T : BaseDomain<K>
    {
        T FindById(K id);
        IEnumerable<T> FindAll();
        bool Update(T domain);
        bool Delete(K id);
        bool Insert(T domain);
    }
}
