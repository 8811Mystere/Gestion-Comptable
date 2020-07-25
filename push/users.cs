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
    public partial class users : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public users()
        {
            InitializeComponent();
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Controls.Clear();
        }
        private void actualiser_dgvUsers(string recherche)
        {
            cmd = new MySqlCommand("SELECT MatriculeUt,Nom,Postnom,Sexe,Password,Tel,MatriculeStrict from utilisateur WHERE Postnom LIKE '" + recherche + "%'", con);
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            actualiser_dgvUsers(txtrecherche.Text);
        }

        private void users_Load(object sender, EventArgs e)
        {
            actualiser_dgvUsers("");
            remplir_matriculeStructure();
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("INSERT INTO utilisateur(MatriculeUt,Nom,Postnom,Sexe,Password,Tel,MatriculeStrict) values (@MatriculeUt,@Nom,@Postnom,@Sexe,@Password,@Tel,@MatriculeStrict)", con);
            cmd.Parameters.Add("@MatriculeUt", MySqlDbType.VarChar).Value = txtmatricule.Text;
            cmd.Parameters.Add("@Nom", MySqlDbType.VarChar).Value = txtnom.Text;
            cmd.Parameters.Add("@Postnom", MySqlDbType.VarChar).Value = txtpostnom.Text;
            cmd.Parameters.Add("@Sexe", MySqlDbType.VarChar).Value = cbxsexe.Text;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = txtpassword.Text;
            cmd.Parameters.Add("@Tel", MySqlDbType.VarChar).Value = txttel.Text;
            cmd.Parameters.Add("@MatriculeStrict", MySqlDbType.VarChar).Value = cbxmatriculestricture.Text;
            try
            { 
                con.Open();
               // MessageBox.Show(con.State.ToString());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Enregistrer avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmatricule.Text = "";
                    txtnom.Text = "";
                    txtpostnom.Text = "";
                    cbxsexe.Text = "";
                    txtpassword.Text = "";
                    txttel.Text = "";
                    cbxmatriculestricture.Text = "";
                }
                actualiser_dgvUsers(dataGridView1.Text);
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Number.ToString());
                if (ex.Number == 1062)
                {
                    MessageBox.Show(" Vous avez reprie le même Matricule à deux reprise");
                }
                else
                {
                    MessageBox.Show("Echec d'enregistrement!!", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                
            }
            finally
            {
                con.Close();
            }
           
        }
        private void remplir_matriculeStructure()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT MatriculeStrict, NomStructure FROM structure";
            cmd.Connection = con;
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbxmatriculestricture.Items.Add(reader[0].ToString());
                    cbxmatriculestricture.Items.Add(reader[1].ToString());
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            txtmatricule.Text = dataGridView1.SelectedRows[0].Cells["MatriculeUt"].Value.ToString(); ;
            txtnom.Text = dataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString(); ;
            txtpostnom.Text = dataGridView1.SelectedRows[0].Cells["Postnom"].Value.ToString(); ;
            cbxsexe.Text = dataGridView1.SelectedRows[0].Cells["Sexe"].Value.ToString(); ;
            txtpassword.Text = dataGridView1.SelectedRows[0].Cells["Password"].Value.ToString(); ;
            txttel.Text = dataGridView1.SelectedRows[0].Cells["Tel"].Value.ToString(); ;
            cbxmatriculestricture.Text = dataGridView1.SelectedRows[0].Cells["MatriculeStrict"].Value.ToString(); 
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {

            cmd.CommandText = "UPDATE utilisateur SET MatriculeUt=@MatriculeUt, Nom=@Nom,  Postnom=@Postnom, Sexe=@Sexe, Password=@Password,  Tel=@Tel,MatriculeStrict=@MatriculeStrict WHERE  MatriculeUt=@MatriculeUt";

            cmd.Parameters.Add("@MatriculeUt", MySqlDbType.VarChar).Value = txtmatricule.Text;
            cmd.Parameters.Add("@Nom", MySqlDbType.VarChar).Value = txtnom.Text;
            cmd.Parameters.Add("@Postnom", MySqlDbType.VarChar).Value = txtpostnom.Text;
            cmd.Parameters.Add("@Sexe", MySqlDbType.VarChar).Value = cbxsexe.Text;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = txtpassword.Text;
            cmd.Parameters.Add("@Tel", MySqlDbType.VarChar).Value = txttel.Text;
            cmd.Parameters.Add("@MatriculeStrict", MySqlDbType.VarChar).Value = cbxmatriculestricture.Text;
            cmd.Connection = con;
           
            
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Mis à jour effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmatricule.Text = "";
                    txtnom.Text = "";
                    txtpostnom.Text = "";
                    cbxsexe.Text = "";
                    txtpassword.Text = "";
                    txttel.Text = "";
                    cbxmatriculestricture.Text = "";
                }
                actualiser_dgvUsers(dataGridView1.Text);
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

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM utilisateur WHERE MatriculeUt =@MatriculeUt";
            cmd.Parameters.Add("@MatriculeUt", MySqlDbType.VarChar).Value = txtmatricule.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Supprimer avec succès...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actualiser_dgvUsers(dataGridView1.Text);
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

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            Imprimer frm = new Imprimer();
            frm.Show();
        }
    }
}
