﻿using System;
using System.Collections.Generic;

namespace Zezoprice.Models
{
    public partial class ShippingordersStatus
    {
        public long Id { get; set; }
        public string? Comment { get; set; }
        public DateTime? CommentTime { get; set; }
        public string? Requestnumber { get; set; }
        public int IdShippingorder { get; set; }
        public int? Status { get; set; }
        public long? PrintStatus { get; set; }
        public DateOnly? PrintDate { get; set; }
        public long? Recert { get; set; }
        public DateOnly? Tofedex { get; set; }
        public DateOnly? StatusDate { get; set; }
        public long? Numberofcopies { get; set; }
        public string? EditorComment { get; set; }
    }
}
