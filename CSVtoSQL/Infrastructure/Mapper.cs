using CSVtoSQL.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoSQL.Infrastructure
{
    public static class Mapper
    {
        public static TransferModel MapString(string data)
        {
            string[] columns = data.Split(',');
            if (data == "") return null;

            TransferModel transferModel = new TransferModel()
            {
                TpepPickupDateTime = DateTime.ParseExact(columns[1], "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                TpepDropoffDateTime = DateTime.ParseExact(columns[2], "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                PassengerCount = int.Parse((columns[3] != string.Empty ? columns[3] : "0")),
                TripDistance = double.Parse((columns[4] != string.Empty ? columns[4] : "0,0"), CultureInfo.InvariantCulture),
                StoreFwdFlag = char.Parse(columns[6] != string.Empty ? columns[6] : "N"),
                PULocationId = int.Parse((columns[7] != string.Empty ? columns[7] : "0")),
                DOLocationId = int.Parse((columns[8] != string.Empty ? columns[8] : "0")),
                FareAmount = double.Parse((columns[10] != string.Empty ? columns[10] : "0,0"), CultureInfo.InvariantCulture),
                TipAmount = double.Parse((columns[13] != string.Empty ? columns[13] : "0,0"), CultureInfo.InvariantCulture),
            };



            return transferModel;
        }
    }
}
