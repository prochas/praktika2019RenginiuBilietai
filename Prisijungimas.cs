using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenginiuBilietai2
{
    abstract class Prisijungimas
    { 
        private int PrisijungimoID;
        private string VartotojoVardas;
        private string Slaptazodis;
        private bool Ijungtas;
        abstract public string LoginTable { get; }



       
        

        public bool Login(string username, string password)
        {

            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; password=Lego3356; database=newdatabase");

            int i = 0;
            con.Open();
           

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from " + LoginTable + " where user='" + username + "' and password='" + password + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                return false;
                //

            }
            else
            {
                //MessageBox.Show("Sėkmingai prisijungta");
                return true;
            }

            con.Close();


            return false;
        }
        public bool Logout()
        {
            return true;
        }

    }


}
