using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            // 4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),    //最後のカンマは付けておく(P103)
            };

            // 4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("----");

            // 4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("----");

            // 4.2.5
            Exercise2_5(ymCollection);


            Exercise2_6(ymCollection);
        }

        private static void Exercise2_6(YearMonth[] ymCollection) {
            //①月で昇順出力　②偶数年のみ昇順に出力 ③閏年のみを出力　④すべての年から１２月に一番近い年を出力
            foreach (var ym in ymCollection.Where(ym => DateTime.IsLeapYear(ym.Year))) {
                Console.WriteLine(ym);
            }
            var date = ymCollection.Max(ym => ym.Month);
            Console.WriteLine(date);
        }


         

        // 4.2.3
        //最初に見つかった21世紀のオブジェクトを返す
        //見つからない場合はnullを返す
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century) {
                    return ym;
                }
            }

            
            return null;
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }
        } 
        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yearmouth = FindFirst21C(ymCollection);

            if (yearmouth != null) {
            }
            else {
                Console.WriteLine(yearmouth);
            }
            Console.WriteLine("21世紀のデータはありません");
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMounth()).ToArray();
            foreach (var ym in array ) {
                Console.WriteLine(ym);

            } 


        }
    }
}
