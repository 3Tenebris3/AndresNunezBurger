using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndresNunezBurger.Models;
using AndresNunezBurger.Views;
using SQLite;

namespace AndresNunezBurger.Data
{
    public class ANBurgerDataBase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public ANBurgerDataBase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<ANBurger>();
        }
        public int AddNewBurger(ANBurger burger)
        {
            if (burger.Id != 0)
                return conn.Update(burger);
            else
                return conn.Insert(burger);
        }

        public int DeleteBurger(ANBurger burger)
        {
            Init();
            return conn.Delete(burger);
        }
        public List<ANBurger> GetAllBurgers()
        {
            Init();
            List<ANBurger> burgers = conn.Table<ANBurger>().ToList();
            return burgers;
        }
    }
}
