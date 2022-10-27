using System;
using System.Collections.Generic;
using System.Text;

namespace eIMIC2325.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }
    }
}
