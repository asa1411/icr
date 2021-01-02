using System;

namespace icr
{
    public class program{
        static void Main(string[] args)
        { 
            Book b1 = new Book ("poem", "soft");
            Book b2 = new Book ("comic", "hard");
            b1.publishYear = 2020;
            b2.publishYear = 1880;

            Console.WriteLine ("The genre of this book is {0}, and its cover is {1}, it was published in {2}.", b1.genre, b1.coverType, b1.publishYear);
            Console.WriteLine ("The genre of this book is {0}, and its cover is {1}, it was published in {2}.", b2.genre, b2.coverType, b2.publishYear);


        }
    }

   public class Book{
       public string genre;
       public int publishYear;

      public string coverType;

      public Book (string initialGenre, string initialCoverType){
          this.genre = initialGenre;
          this.coverType = initialCoverType;
      }
   }
}
