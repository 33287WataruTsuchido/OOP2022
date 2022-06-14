using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
        };
            Exercise02_1(names);
            Console.WriteLine();

            Exercise02_2(names);
            Console.WriteLine();

            Exercise02_3(names);
            Console.WriteLine();

            Exercise02_4(names);
            Console.WriteLine();


        }

        private static void Exercise02_1(List<string> names) {
            Console.WriteLine("都市名を入力");
            do {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;

                var index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
                

            } while (true);//無限ループ

        }

        private static void Exercise02_2(List<string> names) {
            var query = names.Count(n => n.Contains('o'));
            Console.WriteLine();
           }

            private static void Exercise02_3(List<string> names) {
            var selected = names.Where(s => s.Contains('o')).ToList();
                
                foreach(var name in selected) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise02_4(List<string> names) { 
            var selected = names.Where(s =>s.StartsWith("B")).Select(s=> new { s.Length , s });
          
            foreach (var name in selected) {
                Console.WriteLine(name.Length + name.s);

            }
        }
    }
}