﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPFTest.Domain.Models
{
    public class AssetTransaction
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public bool IsPurchase { get; set; }
        public Stock Stock { get; set; }
        public int Shares { get; set; }

        //after adding
        public DateTime DateProcessed { get; set; }
    }
}
