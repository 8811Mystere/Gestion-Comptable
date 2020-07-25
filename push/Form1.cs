using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;
namespace push
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Acceuil frm = new Acceuil();
            frm.Show();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //PREMIER METHODE POUR TESTER LE LOGIN
            //MySqlConnection con = new MySqlConnection();
            ////con.ConnectionString = "server=localhost;database=nteko; uid=root;pwd=''";
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnServer"].ConnectionString;
            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //MySqlCommand cmd = new MySqlCommand("SELECT  FROM 'utilisateur' WHERE 'Nom'=@Nom , 'Postnom'=@Postnom AND 'Password'=@Password" ,con);
            //cmd.Parameters.Add("@Nom", MySqlDbType.VarChar).Value = textBox3.Text;
            //cmd.Parameters.Add("@Postnom", MySqlDbType.VarChar).Value = textBox1.Text;
            //cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = textBox2.Text;
            //try
            //    {
            //con.Open();
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = con;
            //adapter.SelectCommand = cmd;
            //adapter.Fill(table);
            //if (table.Rows.Count > 0)
            //{
            //    Acceuil frm = new Acceuil();
            //    frm.Show();
            //}

            //}
            // catch (MySqlException ex)
            //{
            //    MessageBox.Show("Echec de la connection" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    textBox3.Text = "";
            //    textBox2.Text = "";
            //    textBox1.Text = "";

            //    con.Close();
            //}
            //------------------------------------------------------------------------------------------------------------------------

            //DEUXIEMME DETHODE POUR TESTER LE LOGIN: SEMPLE FACILE
            con.Open();
            cmd = new MySqlCommand("select* from administrateurs where 	PrenomAdmin= '" + textBox3.Text + "' AND Fonction ='" + textBox1.Text + "' AND PasswordAdmin= '" + textBox2.Text + "'", con);
            MySqlDataReader dtr;
            dtr = cmd.ExecuteReader();
           
            if (dtr.HasRows)
            {
                acceuilbon frm = new acceuilbon();
                frm.Show();
                
            }
            else
            {
                MessageBox.Show("Echec de la connection", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.Text = "";
            textBox2.PasswordChar = '*';
            textBox1.Text = "";

            con.Close();

            //Code pour ferme le formulaire principale seul
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

       
    }
}
