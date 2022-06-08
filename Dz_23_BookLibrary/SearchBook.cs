using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz_23_BookLibrary
{
    class SearchBookName: ISearchLib, ISearchBshop
    {
        public void Search(Library L)
        {
            string n;
            Write("Название? ");
            n = ReadLine();

            for (int i = 0; i < L.book.Count; i++)
            {
                if (L.book[i].name == n)
                {
                    Write("Есть книга " + n);
                }
                else Write("нет книги " + n);
            } 
        }

        public void Search(BooksShop B)
        {
            string n;
            Write("Название? ");
            n = ReadLine();

            for (int i = 0; i < B.book.Count; i++)
            {
                if (B.book[i].name == n)
                {
                    Write("Есть книга " + n);
                }
                else Write("нет книги " + n);
            }
        } 
    }
}
