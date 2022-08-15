using System;
using System.Collections.Generic;
using System.Linq;

namespace BookApi
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books;

        public BookService()
        {
            _books = new List<Book>()
            {
                new Book()
                {
                    Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                    Title="Managing Oneself",
                    Description="We live in an age of unprecedented opportunity: with ambition, drive, and talent, you can rise to the top of your chosen profession, regardless of where you started out...",
                    Author= "Peter Ducker",
                },
                new Book()
                {
                    Id= new Guid("117366b8-3541-4ac5-8732-860d698e26a2"),
                    Title="Evolutionary Psychology",
                    Description="Evolutionary Psychology: The New Science of the Mind, 5th edition provides students with the conceptual tools of evolutionary psychology, and applies them to empirical research on the human mind...",
                    Author= "David Buss",
                },
                new Book()
                {
                    Id= new Guid("66ff5116-bcaa-4061-85b2-6f58fbb6db25"),
                    Title="How to Win Friends & Influence People",
                    Description="Millions of people around the world have improved their lives based on the teachings of Dale Carnegie. In How to Win Friends and Influence People, he offers practical advice and techniques for how to get out of a mental rut and make life more rewarding...",
                    Author= "Dale Carnegie"
                },
                new Book()
                {
                    Id =  new Guid("cd5089dd-9754-4ed2-b44c-488f533243ef"),
                    Title = "The Selfish Gene",
                    Description = "Professor Dawkins articulates a gene’s eye view of evolution. A view giving center stage to these persistent units of information, and in which organisms can be seen as vehicles for their replication. This imaginative, powerful, and stylistically brilliant work not only brought the insights of Neo-Darwinism to a wide audience. But galvanized the biology community, generating much debate and stimulating whole new areas of research...",
                    Author = "Richard Dawkins"
                },
                new Book()
                {
                    Id =  new Guid("d81e0829-55fa-4c37-b62f-f578c692af78"),
                    Title = "The Lessons of History",
                    Description = "Will and Ariel Durant have succeeded in distilling for the reader the accumulated store of knowledge and experience from their five decades of work on the eleven monumental volumes of The Story of Civilization...",
                    Author = "Will & Ariel Durant"
                }
            };
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public Book Add(Book newBook)
        {
            newBook.Id = Guid.NewGuid();
            _books.Add(newBook);
            return newBook;
        }

        public Book GetById(Guid id) => _books.Where(a => a.Id == id).FirstOrDefault();

        public void Remove(Guid id)
        {
            var existing = _books.First(a => a.Id == id);
            _books.Remove(existing);
        }
    }
}
