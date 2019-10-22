using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseApp.DAL
{
    class Dbconn
    {
        public SQLiteConnection dbconn()
        {
            string[] paths = { @"" + Application.StartupPath + "", "expensedb.sqllite.db" };
            string dbfilepath = Path.Combine(paths);

            var conn = new SQLiteConnection("Data Source=" + dbfilepath + ";Version=3;");

            return conn;
        }
    }
}
