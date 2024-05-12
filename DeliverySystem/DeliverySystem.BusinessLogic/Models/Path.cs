using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Models
{
    public class Path
    {
        public IEnumerable<int> vertics { set; get; }
        public IEnumerable<int> importanceRates { set; get; }


    }
}
