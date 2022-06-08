using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz_23_BookLibrary
{
    class BooksShop
    {
        ISearchBshop Isb;

        public List<Book> book = new List<Book>();

        public BooksShop() { }

        public void SetAdd(ISearchBshop B)
        {
            Isb = B;
        }
        public void Search(BooksShop B)
        {
            Isb.Search(B);
        }

        public void Init()
        {
            int x;
            string n;
            Write("Сколько книг добавить? ");
            x = Convert.ToInt32(ReadLine());

            for (int i = 0; i < x; i++)
            {
                int y = 0;
                Book b = new Book();
                Write("Название? "); n = ReadLine();
                b.name = n;
                Write("Автор? "); n = ReadLine();
                b.avtor = n;
                Write("Категория? "); n = ReadLine();
                b.kategory = n;
                Write("Цена? "); y = Convert.ToInt32(ReadLine());
                b.price = y;
                book.Add(b);
            }
        }

    }
}
