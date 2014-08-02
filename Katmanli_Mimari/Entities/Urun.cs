using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Urun
    {
        public int ProductId { get; set; }
        public string  ProductName { get; set; }
        public int CategoryID { get; set; }
        public int SupplierId { get; set; }

    }
}
