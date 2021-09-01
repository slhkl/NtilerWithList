using System;
using System.Collections.Generic;
using Data.Models;
using DataAccess;
using System.Linq;
//select, seletmany, firstordefault, first, single, singleordefault, last, any, count, distinc, join, take

namespace Business
{
    public class BookBusiness
    {

        BookDataAccess bookDataAcces = new BookDataAccess();
        public string AddListCheck(Book book)
        {
            if (bookDataAcces.GetAll().Count < 10)
            {
                bookDataAcces.AddList(book);
                return "Basariyla eklendi";
            }
            else
                return "10'dan fazla kitap girilemez";
        }

        public string RemoveListCheck(int index)
        {
            if (index < bookDataAcces.GetAll().Count)
            {
                bookDataAcces.RemoveList(index);
                return "Basariyla Silindi.";
            }
            else
                return "Yanlis bir index girdiniz.";   
        }

        public string RemoveFromName(string name)
        {
            var kitaplar = bookDataAcces.GetAll();

            var kitap = kitaplar.FirstOrDefault(x => x.Yazarlar.Any(y => y.Name.Contains(name)));

            bookDataAcces.Remove(kitap);
            return "Basariyla Silindi.";
        }

        public string RemoveFromYazarId(int yazarId)
        {
            var kitaplar = bookDataAcces.GetAll();

            var kitap = kitaplar.FirstOrDefault(t => t.Yazarlar.Any(u => u.YazarId == yazarId));

            bookDataAcces.Remove(kitap);
            return "Basariyla kitap silindi.";
        }

        public string RemoveFromBookShelf(string bookShelf)
        {
            var kitaplar = bookDataAcces.GetAll();

            var kitap = kitaplar.Where(x => x.BookShelf == bookShelf).ToList();
            foreach (var item in kitap)
            {
                bookDataAcces.Remove(item);
            }
            return "raf basariyla kaldirildi.";
        }
        public Book GetCheck(int index)
        {
            if (index < bookDataAcces.GetAll().Count)
                return bookDataAcces.Get(index);
            else
                return new Book { BookId = -1, BookName="There isn't a book", BookShelf="This book isn't here" };
        }

        public List<Book> GetAllCheck()
        {
            return bookDataAcces.GetAll();
        }
    }
}
