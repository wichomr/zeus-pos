﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeus
{
    public struct SalesDataStruct
    {
        public User User { get; set; }
        public Customer Customer { get; set; }
        public ObservableCollection<IProduct> Products { get; set; }
        public ReceiptType ReceiptType { get; set; }
        public double PointsObtained { get; set; }

    }
}