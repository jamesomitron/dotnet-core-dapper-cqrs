﻿namespace CQRS.Dapper.Commands
{
    public class AddBook
    {
        public string Author { get; }
        public string Title { get; }

        public AddBook(string Author, string Title)
        {
            this.Author = Author;
            this.Title = Title;
        }
    }
}