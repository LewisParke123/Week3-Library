using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN; 

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }
}
