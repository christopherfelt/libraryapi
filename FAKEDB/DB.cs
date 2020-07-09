using System.Collections.Generic;
using bookapi.Models;

namespace bookapi.FAKEDB
{
    public static class FAKEDB
    {
        public static List<Book> Books { get; set; } = new List<Book>(){
            new Book("Fight Club", "Chuck Palahniuk", true),
            new Book("The Earth Is the Sky", "Moth Gatherer", true),
            new Book("Dark Stone", "Holy Fawn", false)
        };
    }
}