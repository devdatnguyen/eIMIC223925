using eIMIC2325.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eIMIC2325.Data.Entities
{
    public class Function
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
        public Status Status { get; set; }
        public string SortOrrder { get; set; }
    }
}
