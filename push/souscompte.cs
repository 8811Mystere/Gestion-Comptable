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

namespace push
{
    public partial class souscompte : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public souscompte()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void compte_Load(object sender, EventArgs e)
        {
            actualiserdgv("");
            remplircbidcompt();
        }
        private void actualiserdgv(string recherche)
        {
            
            cmd = new MySqlCommand("select compte.IdCompt,compte.Numero,compte.Nom, souscompte.NomCpt, souscompte.IdSousCpt from compte, souscompte where compte.IdCompt=souscompte.IdCompt AND  souscompte.NomCpt LIKE '"+ recherche+"%'", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cmd = new MySqlCommand("INSERT INTO souscompte(NomCpt, IdCompt) values (@NomCpt, @IdCompt)", con);
            cmd.Parameters.Add("@NomCpt", MySqlDbType.VarChar).Value = txtnomsouscmpt.Text;
            cmd.Parameters.Add("@IdCompt", MySqlDbType.Int16).Value = cbidcompt.Text;

            con.Close();
            con.Open();
            MessageBox.Show(con.State.ToString());
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Les sous comptes ont été enregistrer avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnomsouscmpt.Text="";
                cbidcompt.Text = "";
            }
            else
            {
                MessageBox.Show("Echec d'enregistrement?", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void remplircbidcompt()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT IdCompt FROM compte";
            cmd.Connection = con;
            try
            {
                con.Close();
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbidcompt.Items.Add(reader[0].ToString());
                }
            }
            catch (MySqlException)
            {
            }
            finally
            {
                con.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            actualiserdgv("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE souscompte SET NomCpt='" + txtnomsouscmpt.Text + "', IdCompt='" + cbidcompt.Text + "' WHERE  IdSousCpt=" + textBox1.Text;
            cmd.Connection = con;
            con.Close();
            con.Open();
            try
            {

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Mis à jour effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    txtnomsouscmpt.Text = "";
                    cbidcompt.Text = "";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur s'est produite" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["IdSousCpt"].Value.ToString();
            txtnomsouscmpt.Text = dataGridView1.SelectedRows[0].Cells["NomCpt"].Value.ToString();
            cbidcompt.Text = dataGridView1.SelectedRows[0].Cells["IdCompt"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM souscompte WHERE IdSousCpt =" + textBox1.Text;
            cmd.Connection = con;
            try
            {
                con.Close();
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Supprimer avec succès...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            actualiserdgv(textBox2.Text);
        }
    }
}
