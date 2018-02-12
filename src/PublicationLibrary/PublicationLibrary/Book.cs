using System;
using System.Collections.Generic;
using System.Text;

namespace PublicationLibrary
{
    public class Book : IPublicationInterface
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PubDate { get; set; }
        private int _issueNum;

       
        public string GetFullName()
        {
            return $"Book Title: {Title}  Author: {Author}";
        }
    }
}
