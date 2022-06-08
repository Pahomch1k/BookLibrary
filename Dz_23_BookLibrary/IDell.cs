using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_23_BookLibrary
{
    interface IDellLib
    {
        public void Dell(Library L);
    }

    interface IDellBshop
    {
        public void Dell(BooksShop B);
    }
}
