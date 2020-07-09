using System;
using System.Collections.Generic;
using bookapi.FAKEDB;
using bookapi.Models;

namespace libraryapi.Services
{
    public class BookService
    {
        internal IEnumerable<Book>  Get()
        {
            return FAKEDB.Books;
        }

        internal Book GetById(string id)
        {
            var found = FAKEDB.Books.Find(b => b.Id == id);
            if(found == null){
                throw new Exception("Bad Id");
            }
            return found;
        }

        internal Book Create(Book newBook)
        {
            FAKEDB.Books.Add(newBook);
            return newBook;
        }

        internal Book Delete(string id)
        {
            var found = FAKEDB.Books.Find(b => b.Id == id);
            if (found == null) { throw new Exception("bad id"); }
            FAKEDB.Books.Remove(found);
            return found;
        }

        internal Book Edit(Book editBook, string id)
        {
            var original = FAKEDB.Books.Find(b => b.Id == id);
            if (original == null) { throw new Exception("bad id"); }
            editBook.Id = original.Id;
            FAKEDB.Books.Remove(original);
            FAKEDB.Books.Add(editBook);
            return editBook;

        }
    }
}