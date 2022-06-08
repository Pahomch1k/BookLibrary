using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz_23_BookLibrary
{
    interface ISearchLib
    {
        public void Search(Library L);
    }

    interface ISearchBshop
    {
        public void Search(BooksShop B);
    }
}
