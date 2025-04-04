using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccess
{
    public class StuffModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Eplanation { get; set; } = string.Empty;
        public string ProductId { get; set; } = string.Empty;
        public int SellPrice { get; set; }

        public int BuyPrice { get; set; }
    }
    
}
