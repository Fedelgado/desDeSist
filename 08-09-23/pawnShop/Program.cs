using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawnShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article("Cup", 100, true, Category.STUFF, Status.REGULAR);
            Article article2 = new Article("Ring", 1000, true, Category.JEWELRY, Status.GOOD);
            Article article3 = new Article("Vase", 523, true, Category.ANTIQUE, Status.BAD);
            Article article4 = new Article("Chair", 203, true, Category.STUFF, Status.GOOD);
            Article article5 = new Article("Glass", 105, true, Category.STUFF, Status.REGULAR);
            Article article6 = new Article("Necklace", 1065, true, Category.JEWELRY, Status.BAD);
            Article article7 = new Article("Jar", 119, true, Category.ANTIQUE, Status.GOOD);

            List<Article> listArt = new List<Article>();
            listArt.Add(article1);
            listArt.Add(article2);
            listArt.Add(article3);
            listArt.Add(article4);
            listArt.Add(article5);
            listArt.Add(article6);
            listArt.Add(article7);
            

            PawnShop pawnShop = new PawnShop("El Precio de la Historia", new Address("Jujuy", 255, 1083), listArt);

            Article artSearched = pawnShop.SearchArticleEleAt("Chair");
            Console.WriteLine(artSearched.Category);
            Console.ReadKey();

            Article article8 = new Article("Mouse", 53, true, Category.STUFF, Status.REGULAR);
            pawnShop.AddArticle(article8);

        }
    }
}
