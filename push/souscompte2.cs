using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace push
{
    public partial class souscompte2 : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public souscompte2()
        {
            InitializeComponent();
        }

        private void souscompte2_Load(object sender, EventArgs e)
        {
            actualiserdgv("");
            remplircbidcompt();
        }
        private void actualiserdgv(string recherche)
        {

            cmd = new MySqlCommand("select compte.IdCompt,compte.Numero,compte.Nom, souscompte.NomCpt, souscompte.IdSousCpt from compte, souscompte where compte.IdCompt=souscompte.IdCompt AND  souscompte.NomCpt LIKE '" + recherche + "%'", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            try
            {
               
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        private void remplircbidcompt()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT IdCompt, Nom FROM compte";
            cmd.Connection = con;
            try
            {
                con.Close();
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbidcompt.Items.Add(reader[0].ToString());
                    cbidcompt.Items.Add(reader[1].ToString());
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
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            imprimersouscompte frm = new imprimersouscompte();
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("INSERT INTO souscompte(NomCpt, IdCompt) values (@NomCpt, @IdCompt)", con);
            cmd.Parameters.Add("@NomCpt", MySqlDbType.VarChar).Value = txtnomsouscmpt.Text;
            cmd.Parameters.Add("@IdCompt", MySqlDbType.Int16).Value = cbidcompt.Text;

            try
            {
                con.Open();
                // MessageBox.Show(con.State.ToString());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Enregistrer avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnomsouscmpt.Text = "";
                    cbidcompt.Text = "";
                }
                actualiserdgv(dataGridView1.Text);
            }
            catch
            {
                MessageBox.Show("Echec d'enregistrement?", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE souscompte SET NomCpt='" + txtnomsouscmpt.Text + "', IdCompt='" + cbidcompt.Text + "' WHERE  IdSousCpt=" + textBox1.Text;
            cmd.Connection = con;

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Mis à jour effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    txtnomsouscmpt.Text = "";
                    cbidcompt.Text = "";
                }
                actualiserdgv(dataGridView1.Text);
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM souscompte WHERE IdSousCpt =@IdSousCpt";
            cmd.Parameters.Add("@IdSousCpt", MySqlDbType.Int16).Value = textBox1.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Supprimer avec succès...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actualiserdgv(dataGridView1.Text);
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["IdSousCpt"].Value.ToString();
            txtnomsouscmpt.Text = dataGridView1.SelectedRows[0].Cells["NomCpt"].Value.ToString();
            cbidcompt.Text = dataGridView1.SelectedRows[0].Cells["IdCompt"].Value.ToString();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            actualiserdgv(textBox2.Text);
        }
    }
}
