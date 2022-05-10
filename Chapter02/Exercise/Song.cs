using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    
    public class Song {
        //歌のタイトル
        public string title { get; set; }
        //アーティスト名
        public string ArtistName { get; set; }
        //演奏時間、単位は秒
        public int Length { get; set; }
    }
}
