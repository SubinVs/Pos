﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Utilities.Model.POS
{
    public class TableModel
    {
        public int Id { get; set; }
        public string TableNo { get; set; }
        public bool Occupied { get; set; }
        public bool Active { get; set; }
    }
}
