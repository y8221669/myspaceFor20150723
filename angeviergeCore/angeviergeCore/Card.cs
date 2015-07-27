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
        public cardColor color;
        public cardType type;
        public cardSingle single;
        public string introduction;
        public string effect;
    }
}
