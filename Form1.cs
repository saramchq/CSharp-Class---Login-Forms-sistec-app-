using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=11111");
                string querry = "select  * from  registoo.utilizador where utilizador =  '" + txtutilizador.Text.Trim() + "' and  palavrapasse='" + txtpalavrapasse.Text.Trim() + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    logado F3 = new logado();
                    F3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dados incorrectos!");
                }
            }
        }
    }
}
