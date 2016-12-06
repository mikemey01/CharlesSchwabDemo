using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoServiceLayer.Models
{
    public class FundCollectionDTO
    {
        public int ID { get; set; }
        public string FundName { get; set; }
        public DateTime? FundInceptionDate { get; set; }
        public double? FundExpenseRatio { get; set; }

        public FundCollectionDTO()
        {

        }
    }
}
