using System;
using System.Collections.Generic;
using System.Linq;

namespace Concept.Linq.Lesson1 {
    class Product
    {
        public string Name { get; set; }
        public int? CategoryID { get; set; }
    }

    class Category
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
    class Main
    {
        private List<Category> categories = new List<Category>()
        { 
            new Category(){Name="Beverages", ID=001},
            new Category(){ Name="Condiments", ID=002},
            new Category(){ Name="Vegetables", ID=003},         
        };
        private List<Product> products = new List<Product>()
        {
            new Product{Name="Tea",  CategoryID=001},
            new Product{Name="Mustard", CategoryID=002},
            new Product{Name="Pickles", CategoryID=002},
            new Product{Name="Carrots", CategoryID=003},
            new Product{Name="Bok Choy", CategoryID=003},
            new Product{Name="Peaches", CategoryID=005},
            new Product{Name="Melons", CategoryID=005},
            new Product{Name="Ice Cream", CategoryID=007},
            new Product{Name="Mackerel", CategoryID=012},
        };
        public void Run()
        {
            Test1();
        }
        void Test1() {
            var query = from c in categories
                        join p in products on c.ID equals (int?)p.CategoryID
                        select new { Category = c.Name, Name = p.Name };
            Console.WriteLine("Lesson1:");
            foreach (var v in query)
            {
                Console.WriteLine($"{v.Category}, {v.Name}");
            }
        }
    }
}
