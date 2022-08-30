using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise1 {
    class ToHankakuProcessor : TextProcessor{
  

        protected override void Initialize(string fname) {
            
        }

        protected override void Execute(string line) {
            string s = Regex.Replace(line, "[０-９]", p => ((char)(p.Value[0] - '０' + '0')).ToString());
        }

        protected override void Terminate() {
        
        }
    }
}
