using CSVtoSQL.Context;
using CSVtoSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoSQL.Repositories
{
    public class TransferRepository : IRepository<TransferModel>
    {
        private CSVContext _context;

        public TransferRepository(CSVContext context)
        {
            _context = context;
        }

        public TransferModel Add(TransferModel item)
        {
            item = _context.Models.Add(item);
            _context.SaveChanges();
            return item;
        }

        public void AddRange(IEnumerable<TransferModel> items)
        {
            foreach(var item in items)
            {
                Add(item);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(TransferModel entity)
        {
            throw new NotImplementedException();
        }

        public TransferModel GetAll()
        {
            throw new NotImplementedException();
        }

        public TransferModel GetId(int id)
        {
            throw new NotImplementedException();
        }

        public TransferModel Update(TransferModel entity)
        {
            throw new NotImplementedException();
        }

        public TransferModel Update(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TransferModel> IRepository<TransferModel>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
