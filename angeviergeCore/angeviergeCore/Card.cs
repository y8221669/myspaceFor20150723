using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angeviergeCore
{
    enum cardColor {red = 0,blue ,white ,black ,green  };
    enum cardType {PG =0,AC };
    enum cardSingle {omege ,sigma ,turnA ,noSingle };
    class Card
    {
        public string name;
        public int level;
        public int power;
        public int grand;
        public int demage;
        public int color;
        public int type;
        public int single;
        public string introduction;
        public string effect;
        public string number;
        public Card(string name,int level,int power,int grand,int demage,int color,int type,int single,string introduction,string effect,string number) {
            this.name = name;
            this.level = level;
            this.power = power;
            this.grand = grand;
            this.demage = demage;
            this.color = color;
            this.type = type;
            this.single = single;
            this.introduction = introduction;
            this.effect = effect;
            this.number = number;
            }
    }
}
