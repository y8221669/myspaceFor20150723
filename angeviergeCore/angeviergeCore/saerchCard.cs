using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angeviergeCore
{
    class cardOperation
    {
        private sqliteHelper helper = new sqliteHelper();
        public List<Card> selectCard(int color, int level, int type, int single, string keyword)
        {
            List<Card> cardlist = new List<Card>(800);
            StringBuilder sb = new StringBuilder("select * from card where");
            if (color != -1) { sb.Append(" color=" + color + " and "); }
            if (level != -1) { sb.Append(" level=" + level + " and "); }
            if (type != -1) { sb.Append(" type=" + type + " and "); }
            if (single != -1) { sb.Append(" single=" + single + " and "); }
            if (keyword != "")
            {
                sb.Append(" name like '%" + keyword + "%' or introduction like '%" + keyword + "%' or effect like '%"
                            + keyword + "%' or number like '%" + keyword + "%'");
            }
            else
            {
                sb.Remove(sb.Length - 5, 5);
            }
            string sql = sb.ToString();
            helper.createSQL("card");
            List<Card> list = helper.selectCards(sql);
            helper.closeCon();
            return list;
        }
        public Card selectFromTag(int tag)
        {
            sqliteHelper helper = new sqliteHelper();
            helper.createSQL("card");
            string sql = "select * from card where id = " + tag;
            Card card = helper.selectCard(sql);
            helper.closeCon();
            return card;
        }
        public void saveDeck(List<Card> list, string deckName)
        {
            string dir = "../deck";
            if (Directory.Exists(@dir) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(@dir);
            }
            string path = "../deck/" + deckName + ".txt";
            FileStream fs = new FileStream(@path, FileMode.Create, FileAccess.ReadWrite);//创建写入文件 
            StreamWriter sw = new StreamWriter(fs);
            foreach(Card card in list)
            {
               sw.WriteLine(card.name);
            }
            sw.Close();
            fs.Close();
            path = "../deck/" + deckName + ".dec";
            fs = new FileStream(@path, FileMode.Create, FileAccess.Write);//创建写入文件 
            sw = new StreamWriter(fs);
            foreach (Card card in list)
            {
                sw.WriteLine(card.cardTag);
            }
            sw.Close();
            fs.Close();
        }
        public List<Card> openDeck(string deckName) {
            List<Card> list = new List<Card>(54);
            string path = "../deck/" + deckName + ".dec";
            if (!File.Exists(@path))
            {
                return null;
            }
            else
            {
                FileStream fs = new FileStream(@path, FileMode.Open, FileAccess.Read);//创建写入文件 
                StreamReader sr = new StreamReader(fs);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    Card card = selectFromTag(int.Parse(line));
                    list.Add(card);
                }
                sr.Close();
                fs.Close();
                return list;
            }
        }

        public List<string> GetFiles()
        {
            string dir = "../deck";
            List<string> decks = new List<string>(100);
            try
            {
                string[] files = Directory.GetFiles(@dir);
                foreach (string file in files)
                {
                    string exname = file.Substring(file.LastIndexOf(".") + 1);//得到后缀名
                                                                             
                    if (".dec".IndexOf(file.Substring(file.LastIndexOf(".") + 1)) > -1)
                    {
                        FileInfo fi = new FileInfo(file);//建立FileInfo对象
                        string name = fi.Name.Split('.')[0];
                        Console.WriteLine(name);
                        decks.Add(name);//把.txt文件全名加人到FileInfo对象
                    }
                }
            }
            catch
            {

            }
            return decks;
        }
    }
}
