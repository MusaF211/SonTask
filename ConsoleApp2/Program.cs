using System;

namespace ConsoleApp2
{
    class Program
    {
        public static int Code { get; private set; }

        static void Main(string[] args)
        {
            Books books = new Books();
            books.Name = "programming";
            books.AuthorName = "Musa Dadasov";
            books.PageCount = 123;
            books.Code = 1;

            Console.WriteLine($"Code: {books.Code}\nName: {books.Name}\nAuthorName: {books.AuthorName}\nPageCount: {books.PageCount}");

        }
    }
}
