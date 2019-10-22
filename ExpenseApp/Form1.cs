using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            //const string filename = @"C:\cplus\tutorials\c#\SQLite\MyDatabase.sqlite";
         
            try
            {
                DAL.Dbconn obj = new DAL.Dbconn();

                var conn=obj.dbconn();
                conn.Open();
                string sql = "select * from tbl_records";
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(sql, conn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
