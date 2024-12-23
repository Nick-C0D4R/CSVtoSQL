using CSVtoSQL.Context;
using CSVtoSQL.Infrastructure;
using CSVtoSQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSVtoSQL
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\sample-cab-data.csv";
            Console.CursorVisible = false;
            Console.Write("Wait a bit...File is being read. \r");


            var models = CSVReader.ReadCSV(path);

            Console.Clear();
            Console.Write("File reading is completed! \n");

            Console.Write($"{models.Count} models are transfering to the database");

            TransferRepository repository = new TransferRepository(new CSVContext());
            repository.AddRange(models);

            Console.WriteLine("Transfering are complete!");
            Console.ReadLine();
        }
    }
}
