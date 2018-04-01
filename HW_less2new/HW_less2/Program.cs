using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_less2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        
        [STAThread]
        
        static void Main()
        {
            SqlConnection conn = null;
            conn = new SqlConnection();
            conn.ConnectionString = @"Server=tcp:tanyatyshkovetc.database.windows.net,1433;Initial Catalog=Tanya;Persist Security Info=False;User ID=Tanya;Password=0939215150NFyz";




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
