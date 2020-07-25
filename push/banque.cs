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
    public partial class banque : UserControl
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public banque()
        {
            InitializeComponent();
        }

        private void banque_Load(object sender, EventArgs e)
        {
            actualiser_dgvbanque("");
            remplircbmatstruct();
            remplircbidtypeop();
            remplircbcompte();

            txtdatebq.Format = DateTimePickerFormat.Custom;
            txtdatebq.CustomFormat = "dddd dd MMMM yyyy hh:mm:ss";
        }
        private void actualiser_dgvbanque(string rechercher)
        {
            cmd = new MySqlCommand("SELECT banque.idBq,banque.dateBq,banque.moisAnneeBq,compte.Numero,compte.Nom, structure.NomStructure, banque.montantBq,banque.deviseBq FROM banque, compte, souscompte, typeop, structure WHERE compte.IdCompt=souscompte.IdCompt and compte.IdCompt=banque.IdCompt and typeop.IdType=banque.IdType and structure.MatriculeStrict=banque.MatriculeStrict  AND structure.NomStructure LIKE '" + rechercheStructure.Text + "%'  AND banque.moisAnneeBq LIKE '" + cbxrecherchemoisannee.Text + "%'", con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                cmd.Connection = con;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            txtdatebq.Format = DateTimePickerFormat.Custom;
            txtdatebq.CustomFormat = "dddd dd MMMM yyyy hh:mm:ss";
            cmd = new MySqlCommand("INSERT INTO  banque(dateBq,moisAnneeBq,deviseBq,montantBq,MatriculeStrict,	IdType,IdCompt) values (@dateBq,@moisAnneeBq,@deviseBq,@montantBq,@MatriculeStrict,	@IdType,@IdCompt)", con);
            cmd.Parameters.Add("@dateBq", MySqlDbType.DateTime).Value = txtdatebq.Value;
            cmd.Parameters[0].Value = txtdatebq.Value;
            cmd.Parameters.Add("@moisAnneeBq", MySqlDbType.VarChar).Value = cbxmoisAnnee.Text;
            cmd.Parameters.Add("@deviseBq", MySqlDbType.VarChar).Value = cbdevisebq.Text;
            cmd.Parameters.Add("@montantBq", MySqlDbType.Decimal).Value = ttxtmontantbq.Text;
            cmd.Parameters.Add("@MatriculeStrict", MySqlDbType.VarChar).Value = cbmatstructbq.Text;
            cmd.Parameters.Add("@IdType", MySqlDbType.Int16).Value = cbidtypeopbq.Text;
            cmd.Parameters.Add("@IdCompt", MySqlDbType.Int16).Value = cbcomptebq.Text;
            try
            { 
                con.Open();
                //MessageBox.Show(con.State.ToString());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Enregistrement est éffectuer avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   txtdatebq.Text="";
                   cbxmoisAnnee.Text="";
                   cbdevisebq.Text="";
                   ttxtmontantbq.Text="";
                   cbmatstructbq.Text="";
                   cbidtypeopbq.Text="";
                   cbcomptebq.Text="";

                }
                actualiser_dgvbanque(dataGridView1.Text);
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
        private void remplircbmatstruct()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT MatriculeStrict, NomStructure FROM structure";
            cmd.Connection = con;
            try
            {
                con.Close();
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbmatstructbq.Items.Add(reader[0].ToString());
                    cbmatstructbq.Items.Add(reader[1].ToString());
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
        private void remplircbidtypeop()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT IdType, Designation FROM typeop";
            cmd.Connection = con;
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbidtypeopbq.Items.Add(reader[0].ToString());
                    cbidtypeopbq.Items.Add(reader[1].ToString());
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
        private void remplircbcompte()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT IdCompt, Nom FROM compte";
            cmd.Connection = con;
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbcomptebq.Items.Add(reader[0].ToString());
                    cbcomptebq.Items.Add(reader[1].ToString());
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

        private void button4_Click(object sender, EventArgs e)
        {
            idbq.Text = dataGridView1.SelectedRows[0].Cells["idBq"].Value.ToString();
            txtdatebq.Text = dataGridView1.SelectedRows[0].Cells["dateBq"].Value.ToString(); 
            cbxmoisAnnee.Text = dataGridView1.SelectedRows[0].Cells["moisAnneeBq"].Value.ToString(); 
            cbdevisebq.Text = dataGridView1.SelectedRows[0].Cells["deviseBq"].Value.ToString(); ;
            ttxtmontantbq.Text = dataGridView1.SelectedRows[0].Cells["montantBq"].Value.ToString(); 
            cbmatstructbq.Text = dataGridView1.SelectedRows[0].Cells["MatriculeStrict"].Value.ToString(); 
            cbidtypeopbq.Text = dataGridView1.SelectedRows[0].Cells["IdType"].Value.ToString(); 
            cbcomptebq.Text = dataGridView1.SelectedRows[0].Cells["IdCompt"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdatebq.Format = DateTimePickerFormat.Custom;
            txtdatebq.CustomFormat = "dddd dd MMMM yyyy hh:mm:ss";

            cmd.CommandText = "UPDATE banque SET dateBq=@dateBq, moisAnneeBq=@moisAnneeBq,  deviseBq=@deviseBq, montantBq=@montantBq, MatriculeStrict=@MatriculeStrict, IdType=@IdType, IdCompt=@IdCompt WHERE  idBq=@idBq";
        
            cmd.Parameters.Add("@dateBq", MySqlDbType.DateTime).Value = txtdatebq.Value;
            cmd.Parameters[0].Value = txtdatebq.Value;
            cmd.Parameters.Add("@moisAnneeBq", MySqlDbType.VarChar).Value = cbxmoisAnnee.Text;
            cmd.Parameters.Add("@deviseBq", MySqlDbType.VarChar).Value = cbdevisebq.Text;
            cmd.Parameters.Add("@montantBq", MySqlDbType.Decimal).Value = ttxtmontantbq.Text;
            cmd.Parameters.Add("@MatriculeStrict", MySqlDbType.VarChar).Value = cbmatstructbq.Text;
            cmd.Parameters.Add("@IdType", MySqlDbType.Int16).Value = cbidtypeopbq.Text;
            cmd.Parameters.Add("@IdCompt", MySqlDbType.Int16).Value = cbcomptebq.Text;
            cmd.Connection = con;

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Mis à jour effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdatebq.Text = "";
                    cbxmoisAnnee.Text = "";
                    cbdevisebq.Text = "";
                    ttxtmontantbq.Text = "";
                    cbmatstructbq.Text = "";
                    cbidtypeopbq.Text = "";
                    cbcomptebq.Text = "";
                }
               actualiser_dgvbanque(dataGridView1.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM banque WHERE idBq =@inBq";
            cmd.Parameters.Add("idBq", MySqlDbType.Int16).Value = idbq.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Supprimer avec succès...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actualiser_dgvbanque(dataGridView1.Text);
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

        private void cbxrecherchemoisannee_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiser_dgvbanque(cbxrecherchemoisannee.Text);
        }

        private void rechercheStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiser_dgvbanque(rechercheStructure.Text);
        }
    }
}
