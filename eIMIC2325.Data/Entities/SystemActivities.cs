using System;
using System.Collections.Generic;
using System.Text;

namespace eIMIC2325.Data.Entities
{
     public class SystemActivities
    {
        public int Id { get; set; }
        public string ActionName { get; set; }
        public string ActionDate { get; set; }
        public int FunctonId { get; set; }
        public int UserId { get; set; }
        public int ClientIP { get; set; }
    }
}
