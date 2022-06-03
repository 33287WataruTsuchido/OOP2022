using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            

            Exercise03_1(text);
            Console.WriteLine("----------");

            Exercise03_2(text);
            Console.WriteLine("----------");

            Exercise03_3(text);
            Console.WriteLine("----------");

            Exercise03_4(text);
            Console.WriteLine("----------");

            Exercise03_5(text);
            Console.WriteLine("----------");
        }

        private static void Exercise03_1(string text) {
            int spaces = text.Count(c => c == ' ');
            Console.WriteLine("空白数:[0]", spaces);
          
        }

        private static void Exercise03_2(string text) {
            var replaced = text.Replace("big","small");
            Console.WriteLine(replaced);
        }

        private static void Exercise03_3(string text) {
            var split = text.Split(' ').Length;
            Console.WriteLine(split);

        }
        private static void Exercise03_4(string text) {
            text.Split(' ').Where(word => word.Length <= 4).ToList().ForEach(word => Console.WriteLine(word));
        }

        private static void Exercise03_5(string text) {
            var word = text.Split(' ');


        }
    }
}
