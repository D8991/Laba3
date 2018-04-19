using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Sale
    {
        public DateTime Sale_Time { get; set; }
        public string Good_Name { get; set; }
        public Sale(DateTime Sale_Time, string Good_Name)
        {
            this.Sale_Time = Sale_Time;
            this.Good_Name = Good_Name;
        }
        public override string ToString()
        {
            return Good_Name;
        }
    }

}