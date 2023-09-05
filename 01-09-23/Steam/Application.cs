using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    internal class Application
    {
        private string name;
        private double price;
        private bool isInEarlyAccess;
        private double rate;
        private List<Review> reviews;

        public Application(string name, double price, bool earlyAcc, double rate, List<Review> reviews)
        {
            this.name = name;
            this.price = price;
            this.isInEarlyAccess = earlyAcc;
            this.rate = rate;
            this.reviews = reviews;
        }

        public Application(){}

    }
}