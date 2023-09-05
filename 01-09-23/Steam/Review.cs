using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    internal class Review
    {
        private string title;
        private string text;
        private bool isPositive;
        private User author;
        private Date date;

        public Review() {}

        public Review(string tit, string text, bool isPos, User author, Date date) { 
            title = tit;
            this.text = text;
            this.isPositive = isPos;
            this.author = author;
            this.date = date;
        }
    }
}
