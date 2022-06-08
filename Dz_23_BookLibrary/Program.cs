using System;
using static System.Console;


namespace Dz_23_BookLibrary
{
    class Program
    {
        public static void AddSearchBshop(ISearchBshop S, BooksShop a)
        {
            a.SetAdd(S);
            a.Search(a);
        }
        public static void AddSearchLib(ISearchLib S, Library a)
        {
            a.SetAdd(S);
            a.Search(a);
        }  

        static void Main(string[] args)
        {
            Library Lib = new Library();
            BooksShop Bshp = new BooksShop();
            ISearchLib Lsearch = new SearchBookName();
            ISearchBshop Bsearch = new SearchBookName();

            int flag1 = 0;
            while (flag1 == 0)
            {
                WriteLine("1. Библиотека\n2. Магазин\n3. Выход");
                int choise1;
                choise1 = Convert.ToInt32(ReadLine());

                switch (choise1)
                {
                    case 1:
                        {
                            int flag2 = 0;
                            while (flag2 == 0)
                            {
                                WriteLine("1. Добавить\n2. Поиск\n3. Удалить\n4. Выход");
                                int choise2;
                                choise2 = Convert.ToInt32(ReadLine());

                                switch (choise2)
                                {
                                    case 1: Lib.Init(); break;
                                    case 2: AddSearchLib(Lsearch, Lib); break;
                                    case 3:
                                        break;
                                    case 4: flag2++; break;
                                    default: WriteLine("Try again"); break;
                                }
                            }
                        } 
                        break;
                    case 2:
                        {
                            int flag2 = 0;
                            while (flag2 == 0)
                            {
                                WriteLine("1. Добавить\n2. Поиск\n3. Удалить\n4. Выход");
                                int choise2;
                                choise2 = Convert.ToInt32(ReadLine());

                                switch (choise2)
                                {
                                    case 1: Bshp.Init(); break;
                                    case 2: AddSearchBshop(Bsearch, Bshp); break;
                                    case 3:
                                        break;
                                    case 4: flag2++; break;
                                    default: WriteLine("Try again"); break;
                                }
                            }
                        }
                        break; 
                    case 3: flag1++; break;
                    default: WriteLine("Try again"); break;
                }
            } 
        }
    }
}

