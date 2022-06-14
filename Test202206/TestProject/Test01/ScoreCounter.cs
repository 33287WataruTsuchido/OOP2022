using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);



        }


        //メソッドの概要：集計データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> scores = new List<Student>();
            string[]lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');
                Student score = new Student {
                    Name = items[1],
                    Subject = items[2],
                    Score = int.Parse(items[2])
                };
                scores.Add(score);
            }
             return scores;

        }

        //メソッドの概要： 点数を集計して求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var score in _score) {
              if (dict.ContainsKey(score.Name))
                dict[score.Name] += score.Score;

             else

                dict[score.Name] = score.Score;
        }

        return dict;
    }

    }
}
