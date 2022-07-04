using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {

            var xdoc = XDocument.Load("Sample.xml");
            var novelists = xdoc.Root.Elements()
                                    .Select(x => new {
                                        Name = (string)x.Element("name"),
                                        Teammember = (int)x.Element("teammembers")
                                    });   
                                        

            foreach (var novelist in novelists) {
                Console.WriteLine("{0} {1}人",novelist.Name,novelist.Teammember);
            }
        }

        private static void Exercise1_2(string file) {
           
            var xdoc = XDocument.Load("Sample.xml");
            var novelists = xdoc.Root.Elements()
                                   .OrderBy(x =>(string)(x.Element("ballsport").Attribute("firstplayed")));
            
            foreach (var item in novelists) {
                var xfirstplayed = item.Element("firstplayed");
                var xballsport = item.Element("ballsport");
                
                Console.WriteLine("{0}{1}",xballsport.Value,xfirstplayed.Value);


            }

        }

        private static void Exercise1_3(string file) {
            throw new NotImplementedException();
        }

        private static void Exercise1_4(string file, string newfile) {
            throw new NotImplementedException();
        }
    }
}
