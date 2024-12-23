using CSVtoSQL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoSQL.Context
{
    public class CSVContext : DbContext
    {
        public DbSet<TransferModel> Models { get; set; }
    }
}
