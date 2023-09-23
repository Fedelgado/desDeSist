using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawnShop
{
    internal class Address
    {
        private string street;
        private int number;
        private int postalCode;

        public Address() { }

        public Address(string street, int number, int postalCode) { 
            this.street = street;
            this.number = number;
            this.postalCode = postalCode;
        }
    }
}
