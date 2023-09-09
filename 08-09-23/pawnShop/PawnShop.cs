using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pawnShop
{
    internal class PawnShop
    {
        private string name;
        private Address adress;
        private List<Article> expList;

        public PawnShop()
        { }

        public PawnShop(string name, Address address, List<Article> listArt){
            this.name = name;
            this.adress = address;
            this.expList = listArt;
        }

        public bool AddArticle(Article article) { 
            if(article == null)
            {
                return false;
            }
            else
            {
                expList.Add(article);  
                return true;
            }
        }
        public Article SearchArticleEleAt(string artName)
        {
            int i = 0;
            Article art = new Article();
            while(art.Name == null)
            {
                Article listArt = expList.ElementAt(i);

                if(listArt.Name == artName)
                {
                    art = listArt;
                }
                
                i++;
            }
            return art;
        }


        public int SearchArticleIndOf(string artName)
        {
            int index = 0;
            foreach (Article article in expList)
            {
                if (article.Name == artName)
                {
                    index = expList.IndexOf(article);
                }
            }
            return index;
        }
        public bool RemoveArticle(string artName) {
            int index;


        }
    }
}
