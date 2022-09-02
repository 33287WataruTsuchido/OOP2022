﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Framework{
    public abstract class ConverterBase {

        public  abstract bool IsMyUnit(string name);

    
    //メートルからの率
    protected abstract double Ratio { get; }
    //距離の単位
    public abstract string UnitName { get; }
    //メートルからの返還
    public double FromMeter(double meter) {
        return meter / Ratio;
    }
    //メートルに変換
    public double ToMeter(double feet) {
        return feet * Ratio;
      }
    }
}
    

