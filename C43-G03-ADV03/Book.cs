using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_ADV03
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string title { get; set; }
        public string []author { get; set; }
        public DateTime publictiontime { get; set; }
        public decimal price { get; set; }

        public Book(string _ISBN, string _title, string[] _author, DateTime  date , decimal _price)
        {
            ISBN = _ISBN;
            title = _title;
            author = _author;
            publictiontime = date;
            price = _price;

                



        }
        public override string ToString()
        {
            return $"{ISBN},{title}, {author},{publictiontime},{price}";
        }


    }
}
