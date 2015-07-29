using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace angeviergeCore
{
    class sqliteHelper
    {
        private
       SQLiteConnection conn = null;
        string dbPath;

        public void createSQL(string dbName)
        {
            dbPath = "Data Source =" + Environment.CurrentDirectory + "/"+ dbName+ ".db";
            conn = new SQLiteConnection(dbPath);//创建数据库实例，指定文件位置  
            conn.Open();//打开数据库，若文件不存在会自动创建 
        }
        public void createcardTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS card(id integer primary key, name varchar(30), level INTERGER, power INTERGER,guard INTERGER,demage INTERGER,color INTERGER ,type INTERGER,single INTERGER,introduction  varchar(60),effect varchar(300),number varchar(10));";//建表语句  
            SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
            cmdCreateTable.ExecuteNonQuery();
           
        }
        public void insertCard(Card[] card) {
            SQLiteCommand cmdInsert = new SQLiteCommand(conn);
            for (int i = 0; i < card.Length; i++)
            {
                cmdInsert.CommandText = "INSERT INTO card VALUES(null, '"
                    + card[i].name + "', "
                    + card[i].level + ","
                    + card[i].power + ","
                    + card[i].guard + ","
                    + card[i].demage + ","
                    + card[i].color + ","
                    + card[i].type + ","
                    + card[i].single + ",'"
                    + card[i].introduction + "','"
                    + card[i].effect + "','"
                    +card[i].number+"')";//插入卡片信息  
                cmdInsert.ExecuteNonQuery();
            }
        }
        public List<Card> selectCards(string sql) {
            List<Card> cardlist = new List<Card>(800);
            SQLiteCommand cmdQ = new SQLiteCommand(sql, conn);
            try {
                SQLiteDataReader reader = cmdQ.ExecuteReader();
                while (reader.Read())
                {
                    Card card = new Card(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetString(9), reader.GetString(10), reader.GetString(11));
                    cardlist.Add(card);
                }
                return cardlist;
            }
            catch { return cardlist; }
            
        }
        public void closeCon() {
            conn.Close();
        }
        public Card selectCard(string sql)
        {
            SQLiteCommand cmdQ = new SQLiteCommand(sql, conn);

            SQLiteDataReader reader = cmdQ.ExecuteReader();
            while (reader.Read())
            {
                Card card = new Card(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetString(9), reader.GetString(10), reader.GetString(11));
                return card;
            }
            return null;
        }
    }
}
