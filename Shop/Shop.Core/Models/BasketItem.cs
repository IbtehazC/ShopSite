using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Models
{
    public class BasketItem : BaseEnitity
    {
        public string BasketId { get; set; }
        public string ProductId { get; set; }
        public int Qunatity { get; set; }
    }
}
