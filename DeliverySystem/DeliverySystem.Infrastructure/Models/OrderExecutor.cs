﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.Models
{
    public class OrderExecutor
    {
        public int OrderExecutorId { get; set; }
        public string ExecutorName { get; set; }
        public string ExecutorSurname { get; set; }
        public string OrganizationName { get; set; }
    }
}
