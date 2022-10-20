﻿using eIMIC2325.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eIMIC2325.Data.Entities
{
   public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShownOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
    }
}
