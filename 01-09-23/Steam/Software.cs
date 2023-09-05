using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    internal class Software : Application
    {
        private CategorySoftware category;

        public Software(){}

        public Software(string nom, double price, bool earlyAcc, double rate, List<Review> reviews, CategorySoftware category) : base(nom, price, earlyAcc, rate, reviews)
        {
            this.category = category;
        }
    }
}
