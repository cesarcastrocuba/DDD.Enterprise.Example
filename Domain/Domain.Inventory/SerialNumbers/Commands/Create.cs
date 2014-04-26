﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventory.SerialNumbers.Commands
{
    public class Create : ICommand
    {
        public Guid SerialNumberId { get; set; }
        public String SerialNumber { get; set; }
        public Decimal Quantity { get; set; }
        public DateTime Effective { get; set; }
        public Guid ItemId { get; set; }
    }
}