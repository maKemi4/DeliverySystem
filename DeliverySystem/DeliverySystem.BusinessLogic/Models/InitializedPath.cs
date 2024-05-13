using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Models
{
    public class InitializedPath
    {
        public IEnumerable<int> Vertics { set; get; }           //Вершини, тобто міста
        public double[,] Matrix { set; get; }                          //Матриця суміжності, тобто час між містами
        public IEnumerable<decimal> ImportanceRates { set; get; }       //Важливості міст
    }       
}
