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
            bool prisijungimas;

            Adminas adm = new Adminas();
            prisijungimas = adm.Login(textBoxPavadinimas.Text, textBoxSlaptazodis.Text);

            if ( prisijungimas )
            {
                MessageBox.Show("Sėkmingai prisijungta");
            }
            else
            {
                MessageBox.Show("Blogai ivestas slaptazodis arba prisijungimo vardas");
            }

            
        }
    }
}
