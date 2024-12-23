using CSVtoSQL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoSQL.Infrastructure
{
    public class CSVReader
    {
        public static List<TransferModel> ReadCSV(string path)
        {
            if (path == string.Empty) return null;
            int count = 0;
            List<TransferModel> models = new List<TransferModel>();

            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string row = reader.ReadLine();
                        if (count != 0)
                        {
                            var model = Mapper.MapString(row);
                            if (model != null)
                                models.Add(model);
                        }
                        count++;
                    }
                }
            }

            return models;
        }
    }
}
