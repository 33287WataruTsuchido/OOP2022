using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books
                           .Max(b => b.Price);
            var book = Library.Books.First((b => b.Price == max));

            Console.WriteLine(book);

        }


        private static void Exercise1_3() {
           // var query = Library.Books
                                 //  .OrderBy(x => x.PublishedYear)
                                 //  .Select();
   

          //  foreach (var book in query) {
            //    Console.WriteLine($"");

          //  }
        }
        private static void Exercise1_4() {
          //  var selected = Library.Books
                                  // .Join(Library.Categories,
                                  // book => book.CategoryId,
                                  // (book,category) =
                                  
                                   
           // foreach (var book in selected) {
             //   Console.WriteLine($"");

           // }
        }

        private static void Exercise1_5() {
            var query = Library.Books
                                .Where(b => b.PublishedYear == 2016)
                                .Join(
                                         Library.Categories,
                                          book => book.CategoryId,
                                         catergory => catergory.Id,
                                         (book, category) => category.Name)
                                .Distinct();
            foreach (var name in query) {
                Console.WriteLine(name);
            }
    }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
          
        }
    }
}
