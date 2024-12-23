using CSVtoSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoSQL.Repositories
{
    public interface IRepository<T> where T : TransferModel
    {
        IEnumerable<T> GetAll();
        T GetId(int id);

        T Add(T item);
        void AddRange(IEnumerable<T> items);

        T Update(T entity);
        T Update(int id);
        void Delete(int id);
        void Delete(T entity);
    }
}
