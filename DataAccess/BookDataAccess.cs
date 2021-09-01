using Data.Models;
using System;
using System.Collections.Generic;


namespace DataAccess
{
    public class BookDataAccess
    {
        private static readonly List<Book> BookList = new List<Book>()
        {
                new Book { BookId = 1, BookName = "sefiller", BookShelf = "A1",
                Yazarlar= new List<Yazar>
                    {
                        new Yazar {Name="Victor Hugo", BirthDate=DateTime.Now}
                    }
                }
        };

        public void AddList(Book book)
        {
            BookList.Add(book);
        }

        public void RemoveList(int index)
        {
            BookList.RemoveAt(index);
        }

        public void Remove(Book book)
        {
            BookList.Remove(book);
        }



        //Yazar ismine gore kitap silme
        //yazarId/Index sine gore kitapları silme
        public List<Book> GetAll()
        {
            return BookList;
        }
        public Book Get(int index)
        {
            return BookList[index];
        }
    }
}
