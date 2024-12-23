using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoSQL.Models
{
    public class TransferModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime TpepPickupDateTime { get; set; }
        public DateTime TpepDropoffDateTime { get; set; }
        public int PassengerCount { get; set; }
        public double TripDistance { get; set; }
        public char StoreFwdFlag { get; set; }
        public int PULocationId { get; set; }
        public int DOLocationId { get; set; }
        public double FareAmount { get; set; }
        public double TipAmount { get; set; }
    }
}
