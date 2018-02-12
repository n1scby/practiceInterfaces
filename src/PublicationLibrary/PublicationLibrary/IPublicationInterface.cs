using System;

namespace PublicationLibrary
{
    public interface IPublicationInterface
    {
        string Title { get; set; }
        string Author { get; set; }
        DateTime PubDate { get; set; }

        string GetFullName();

    }
}
