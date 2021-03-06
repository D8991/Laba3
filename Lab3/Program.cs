﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Good> ListGood = new List<Good>();
            Sale book_Sale = new Sale(new DateTime(12 / 09 / 2017), "Book");
            Sale journal_Sale = new Sale(new DateTime(30 / 09 / 2017), "Journal");
            Sale notebook_Sale = new Sale(new DateTime(11 / 11 / 2017), "NoteBook");
            Sale book1_Sale = new Sale(new DateTime(15 / 09 / 2017), "Book");
            Sale journal1_Sale = new Sale(new DateTime(30 / 11 / 2017), "Journal");
            ListGood.Add(new Good(book_Sale, "Мастер и маргарита",  250));
            ListGood.Add(new Good(journal_Sale, "Вестник",  150));
            ListGood.Add(new Good(notebook_Sale, "Цветы", 60));
            ListGood.Add(new Good(book1_Sale, "Преступление и наказание", 300));
            ListGood.Add(new Good(journal1_Sale, "Наука", 160));

            foreach (Good g in ListGood)
            {
                g.GetInfo();
            }
            Console.ReadLine();
        }
    }
}
