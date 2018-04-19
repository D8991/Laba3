using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Good
    {
        public Sale ID { get; set; }
        public string Book_Title { get; set; }
    
        public double Price { get; set; }
        
        public Good (Sale ID, string Book_Title,  double Price)
        {
            this.ID = ID;
            this.Book_Title = Book_Title;
            this.Price = Price;
        }
        public void GetInfo()
        {
            Console.WriteLine(ID.ToString() + " " + Book_Title.ToString() + " "  + Price.ToString());

        }
    }
}
