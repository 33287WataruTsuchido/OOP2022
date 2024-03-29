﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {

    public class Song {
        //211 212
        //歌のタイトル
        public string Title { get; set; }
        //アーティスト名
        public string ArtistName { get; set; }
        //演奏時間、単位は秒
        public int Length { get; set; }

        //引数付きインストラクタ
        public Song(string title, string artistname, int length) {
            this.Title = title;
            this.ArtistName = artistname;
            this.Length = length;
        }
    }
}
