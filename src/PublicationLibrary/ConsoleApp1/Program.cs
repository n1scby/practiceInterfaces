using PublicationLibrary;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Book newBook = new Book
                {
                    Title = "The Jungle",
                    Author = "Upton Sinclair",
                    PubDate = DateTime.Now
                };

                PublicationHandler pubHandler1 = new PublicationHandler(newBook);
                Console.WriteLine(pubHandler1.GetPubFullName());
                Console.ReadLine();

                Magazine newMagazine = new Magazine
                {
                    Title = "Dogs and Gum",
                    Author = "Wiggly Wriggley",
                    PubDate = DateTime.Now,
                    IssueNum = 1
                };


                PublicationHandler pubHandler2 = new PublicationHandler(newMagazine);
                Console.WriteLine(pubHandler2.GetPubFullName());
                Console.ReadLine();

                Magazine newMagazine2 = new Magazine
                {
                    Title = "Whack-A-Mole",
                    Author = "Moles R Us",
                    PubDate = DateTime.Now,
                    IssueNum = 0
                };


                PublicationHandler pubHandler3 = new PublicationHandler(newMagazine);
                Console.WriteLine(pubHandler3.GetPubFullName());
                Console.ReadLine();



            }
            catch(Exception ex)
            {
                Console.WriteLine($"Rut Row!  Error: {ex}");
            }

            Console.WriteLine("Hello Publication World!");
            Console.ReadLine();
        }
    }
}
