﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpScoutNet.Model.Report.Common
{
    public class DateAndCount
    {
        public DateTime? Date { get; set; }
        public int Count { get; set; }
        public int Replies { get; set; }
    }

    public class CustomerDateAndCount
    {
        public DateTime? Date { get; set; }
        public int Customers { get; set; }
    }
}
