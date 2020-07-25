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
    public partial class structure2 : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public structure2()
        {
            InitializeComponent();
        }

        private void structure2_Load(object sender, EventArgs e)
        {
            actualiserdgv("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void actualiserdgv(string recherche)
        {

            cmd = new MySqlCommand("select structure.MatriculeStrict, structure.NomStructure from structure WHERE structure.NomStructure LIKE '" + recherche + "%'", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            try
            { 
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Erreur?", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            imprimerstructure frm = new imprimerstructure();
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("INSERT INTO  typeop(Designation) values (@Designation)", con);
            cmd.Parameters.Add("@Designation", MySqlDbType.VarChar).Value = cbdesignation.Text;

            cmd = new MySqlCommand("INSERT INTO  structure(MatriculeStrict,NomStructure) values (@MatriculeStrict,@NomStructure)", con);
            cmd.Parameters.Add("@MatriculeStrict", MySqlDbType.VarChar).Value = txtmatricule.Text;
            cmd.Parameters.Add("@NomStructure", MySqlDbType.VarChar).Value = cbnomstruct.Text;
            try
            {
                con.Open();
                MessageBox.Show(con.State.ToString());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("L'enregistrement est éffectuer avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cbdesignation.Text = "";
                    txtmatricule.Text = "";
                    cbnomstruct.Text = "";

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
            cmd.CommandText = "UPDATE structure SET MatriculeStrict=@MatriculeStrict, NomStructure=@NomStructure WHERE  MatriculeStrict=@MatriculeStrict";
            cmd.Parameters.Add("@MatriculeStrict", MySqlDbType.VarChar).Value = txtmatricule.Text;
            cmd.Parameters.Add("@NomStructure", MySqlDbType.VarChar).Value = cbnomstruct.Text;
            cmd.Connection = con;

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Mise à jour effectuée avec succès ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmatricule.Text = "";
                    cbnomstruct.Text = "";
                }
                actualiserdgv(dataGridView1.Text);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur s'est produite   " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            txtmatricule.Text = dataGridView1.SelectedRows[0].Cells["MatriculeStrict"].Value.ToString();
            cbnomstruct.Text = dataGridView1.SelectedRows[0].Cells["NomStructure"].Value.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM structure WHERE MatriculeStrict =@MatriculeStrict";
            cmd.Parameters.Add("@MatriculeStrict", MySqlDbType.VarChar).Value = txtmatricule.Text;
            cmd.Connection = con;
            try
            {
                con.Close();
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Supprimer avec succès...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actualiserdgv(dataGridView1.Text);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de suppression " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            actualiserdgv(textBox1.Text);
        }
    }
}
