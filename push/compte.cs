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
    public partial class compte : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public compte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("INSERT INTO compte(Numero, Nom) values (@Numero, @Nom)", con);
            cmd.Parameters.Add("@Numero", MySqlDbType.Double).Value = txtnumero.Text;
            cmd.Parameters.Add("@Nom", MySqlDbType.VarChar).Value = txtnomcompte.Text;
            con.Close();
            con.Open();
            MessageBox.Show(con.State.ToString());
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Les comptes ont été enregistrer avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnumero.Text = "";
                txtnomcompte.Text = "";
               
            }
            else
            {
                MessageBox.Show("Echec d'enregistrement?", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void compte_Load(object sender, EventArgs e)
        {
            actualiserdgv("");
        }
        private void actualiserdgv(string recherche)
        {
            
            cmd = new MySqlCommand("SELECT compte.IdCompt,compte.Numero,compte.Nom from compte WHERE compte.Numero  LIKE '"+ recherche +"%'",con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["IdCompt"].Value.ToString();
            txtnumero.Text = dataGridView1.SelectedRows[0].Cells["Numero"].Value.ToString();
            txtnomcompte.Text = dataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE compte SET Numero='" + txtnumero.Text + "', Nom='" + txtnomcompte.Text + "' WHERE  IdCompt="+ textBox1.Text;
            cmd.Connection = con;
            con.Close();
            con.Open();
            try
            {

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Mis à jour effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    txtnumero.Text = "";
                    txtnomcompte.Text = "";
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

        private void btnactualis_Click(object sender, EventArgs e)
        {
            actualiserdgv("");
        }

        private void btnsupprim_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM compte WHERE IdCompt =" + textBox1.Text;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
