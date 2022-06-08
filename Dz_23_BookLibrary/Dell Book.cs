using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Dz_23_BookLibrary
{
    class DellBookName : IDellLib, IDellBshop
    {
        public void Dell(Library L)
        {
            string n;
            Write("Название? ");
            n = ReadLine();
            int flag = 0;
            for (int i = 0; i < L.book.Count; i++)
            {
                if (L.book[i].name == n)
                {
                    L.book.RemoveAt(i);
                    flag++;
                }
                if (flag > 0) WriteLine("Удалили");
                else WriteLine("не Удалили");
            }
        }

        public void Dell(BooksShop B)
        {
            string n;
            Write("Название? ");
            n = ReadLine();
            int flag = 0;
            for (int i = 0; i < B.book.Count; i++)
            {
                if (B.book[i].name == n)
                {
                    B.book.RemoveAt(i);
                    flag++;
                } 
            }
            if (flag > 0) WriteLine("Удалили");
            else WriteLine("не Удалили");
        }
    }
}
