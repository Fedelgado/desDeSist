using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawnShop
{
    internal class Article
    {
        private string name;
        private double price;
        private bool forSale;
        private Category category;
        private Status status;

        public string Name { get { return name; } }

        public Article() { }
        public Article(string name, double price, bool forSale, Category category, Status status)
        {
            this.name = name;
            this.price = price;
            this.forSale = forSale;
            this.category = category;
            this.status = status;
        }
    }
}
