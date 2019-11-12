using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RenginiuBilietai2
{
    public partial class Form1 : Form
    {

        MySqlConnection con = new MySqlConnection("server = localhost; user id = root; password=Lego3356; database=newdatabase");
        int i;

        public Form1()
        {
            InitializeComponent();

            //this.textBoxSlaptazodis.AutoSize = false;
            //this.textBoxSlaptazodis.Size = new Size(this.textBoxSlaptazodis.Size.Width, 50);

        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrisijungimas_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from logininfo where user='" + textBoxPavadinimas.Text + "' and password='" + textBoxSlaptazodis.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Neteisingas slaptažodis arba prisijungimo vardas");

            }
            else
            {
                MessageBox.Show("Sėkmingai prisijungta");
            }

            con.Close();
        }
    }
}
