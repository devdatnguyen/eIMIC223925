using eIMIC2325.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eIMIC2325.Data.Entities
{
   public class Promotion
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool ApplyForAll { get; set; }
        public decimal DiscountPercent { get; set; }
        public int DiscountAmount { get; set; }
        public int ProductId { get; set; }
        public int ProductcategoryId { get; set; }
        public Status Status { get; set; }
        public string Name { get; set; }
    }
}
