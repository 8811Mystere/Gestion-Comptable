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
    public partial class compte2 : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public compte2()
        {
            InitializeComponent();
        }

        private void compte2_Load(object sender, EventArgs e)
        {
            actualiserdgv("");
        }
        private void actualiserdgv(string recherche)
        {

            cmd = new MySqlCommand("SELECT compte.IdCompt,compte.Numero,compte.Nom from compte WHERE compte.Numero  LIKE '" + recherche + "%'", con);
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
            cmd = new MySqlCommand("INSERT INTO compte(Numero, Nom) values (@Numero, @Nom)", con);
            cmd.Parameters.Add("@Numero", MySqlDbType.Double).Value = txtnumero.Text;
            cmd.Parameters.Add("@Nom", MySqlDbType.VarChar).Value = txtnomcompte.Text;
            try
            { 
                con.Open();
               // MessageBox.Show(con.State.ToString());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Les comptes ont été enregistrer avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnumero.Text = "";
                    txtnomcompte.Text = "";

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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["IdCompt"].Value.ToString();
            txtnumero.Text = dataGridView1.SelectedRows[0].Cells["Numero"].Value.ToString();
            txtnomcompte.Text = dataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            actualiserdgv(textBox2.Text);
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE compte SET Numero='" + txtnumero.Text + "', Nom='" + txtnomcompte.Text + "' WHERE  IdCompt=" + textBox1.Text;
            cmd.Connection = con;

            try
            {

                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Mis à jour effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    txtnumero.Text = "";
                    txtnomcompte.Text = "";
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

        private void btnsupprim_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM compte WHERE IdCompt =" + textBox1.Text;
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

        private void btnactualis_Click(object sender, EventArgs e)
        {
            imprimercompte frm = new imprimercompte();
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }
    }
}
