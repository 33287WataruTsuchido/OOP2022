using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);



        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {

            




    }

        //メソッドの概要： 点数を集計する
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<String, int>();
            foreach (var sale in _sales) {
              if (dict.ContainsKey(sale.ShopName))
                dict[sale.ShopName] += sale.Amount;

             else

                dict[sale.ShopName] = sale.Amount;
        }

        return dict;
    }





}
    }
}
