using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    internal class Game : Application
    {
        private int minAge;
        private CategoryGame category;

        public Game(string nom, double price, bool earlyAcc, double rate, List<Review> reviews, int minAge, CategoryGame category) : base(nom, price, earlyAcc, rate, reviews)
        {
            this.minAge = minAge;
            this.category = category;
        }

        public Game() { }
    }
}
