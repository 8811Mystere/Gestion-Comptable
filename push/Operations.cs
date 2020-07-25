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
    public partial class Operations : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public Operations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Operations_Load(object sender, EventArgs e)
        {
            actualiserdgv("");
            remplircbmatstruct();
            remplircbidtypeop();
            remplircbsouscompte();

            dateOperation.Format = DateTimePickerFormat.Custom;
            dateOperation.CustomFormat = "dddd dd MMMM yyyy hh:mm:ss";
        }
        private void actualiserdgv(string recherche)
        {
            con.Close();
            con.Open();

            cmd = new MySqlCommand("select operation.IdOp, operation.DateOp, operation.MoisAnnee, compte.Numero,compte.Nom, souscompte.IdSousCpt, souscompte.NomCpt, typeop.IdType, typeop.Designation,  operation.MatriculeStrict, structure.NomStructure , operation.Devise, operation.Montant FROM operation, compte, souscompte, typeop, structure WHERE compte.IdCompt=souscompte.IdCompt and souscompte.IdSousCpt=operation.IdSousCpt and typeop.IdType=operation.IdType and structure.MatriculeStrict=operation.MatriculeStrict AND structure.NomStructure LIKE '" + textBox1.Text + "%' AND typeop.Designation LIKE '"+ textBox3.Text + "%' AND operation.Devise LIKE '"+ textBox4.Text + "%' AND operation.MoisAnnee LIKE '" + textBox5.Text + "%'", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }
            catch(MySqlException ex)
            {
                if(ex.Number==1080)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }
                else
                {
                    MessageBox.Show("Erreur d'un autre Numero" + ex.Message);
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
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
                    cbmatstruct.Items.Add(reader[0].ToString());
                    cbmatstruct.Items.Add(reader[1].ToString());
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
                    cbidtypeop.Items.Add(reader[0].ToString());
                    cbidtypeop.Items.Add(reader[1].ToString());
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
        private void remplircbsouscompte()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT IdSousCpt, NomCpt FROM souscompte";
            cmd.Connection = con;
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbsouscompte.Items.Add(reader[0].ToString());
                    cbsouscompte.Items.Add(reader[1].ToString());
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

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsuprime_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculs frm = new Calculs();
            frm.Show();
        }

        private void cbidtypeop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbdevise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmatstruct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbsouscompte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tresorerie2 frm = new tresorerie2();
           
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Close();
            Operations frm = new Operations();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            banque frm = new banque();
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            dateOperation.Format = DateTimePickerFormat.Custom;
            dateOperation.CustomFormat = "dddd dd MMMM yyyy hh:mm:ss";

            cmd = new MySqlCommand("INSERT INTO operation( DateOp, MoisAnnee, Devise, Montant, MatriculeStrict, IdType, IdSousCpt) values (@DateOp, @MoisAnnee, @Devise, @Montant, @MatriculeStrict, @IdType, @IdSousCpt)", con);

            cmd.Parameters.Add("@DateOp", MySqlDbType.DateTime).Value = dateOperation.Text;
            cmd.Parameters[0].Value = dateOperation.Value;
            cmd.Parameters.Add("@MoisAnnee", MySqlDbType.VarChar).Value = txtmois.Text;
            cmd.Parameters.Add("@Devise", MySqlDbType.VarChar).Value = cbdevise.Text;
            cmd.Parameters.Add("@Montant", MySqlDbType.Decimal).Value = ttxtmontant.Text;
            cmd.Parameters.Add("@MatriculeStrict", MySqlDbType.VarChar).Value = cbmatstruct.Text;
            cmd.Parameters.Add("@IdType", MySqlDbType.Int16).Value = cbidtypeop.Text;
            cmd.Parameters.Add("@IdSousCpt", MySqlDbType.Int16).Value = cbsouscompte.Text;

            try
            {
                con.Open();
               // MessageBox.Show(con.State.ToString());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Les opérations ont été enregistrer avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateOperation.Text = "";
                    txtmois.Text = "";
                    cbdevise.Text = "";
                    ttxtmontant.Text = "";
                    cbmatstruct.Text = "";
                    cbidtypeop.Text = "";
                    cbsouscompte.Text = "";
                    //Pour le numero de l'exeption dans catch
                    //MessageBox.Show(ex.Number.ToString());

                }
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells["IdOp"].Value.ToString();
            dateOperation.Text = dataGridView1.SelectedRows[0].Cells["DateOp"].Value.ToString();
            txtmois.Text = dataGridView1.SelectedRows[0].Cells["MoisAnnee"].Value.ToString();
            cbdevise.Text = dataGridView1.SelectedRows[0].Cells["Devise"].Value.ToString();
            ttxtmontant.Text = dataGridView1.SelectedRows[0].Cells["Montant"].Value.ToString();
            cbmatstruct.Text = dataGridView1.SelectedRows[0].Cells["MatriculeStrict"].Value.ToString();
            cbidtypeop.Text = dataGridView1.SelectedRows[0].Cells["IdType"].Value.ToString();
            cbsouscompte.Text = dataGridView1.SelectedRows[0].Cells["IdSousCpt"].Value.ToString();
        }

        private void btnmodif_Click_1(object sender, EventArgs e)
        {
            dateOperation.Format = DateTimePickerFormat.Custom;
            dateOperation.CustomFormat = "dddd dd MMMM yyyy hh:mm:ss";

            cmd.CommandText = "UPDATE operation SET DateOp=@DateOp, MoisAnnee='" + txtmois.Text + "', Devise='" + cbdevise.Text + "', Montant='" + ttxtmontant.Text + "',  MatriculeStrict='" + cbmatstruct.Text + "', IdType='" + cbidtypeop.Text + "', IdSousCpt='" + cbsouscompte.Text + "' WHERE  IdOp=" + textBox2.Text;
            cmd.Connection = con;

            cmd.Parameters.Add("@DateOp", MySqlDbType.DateTime).Value = dateOperation.Text;
            cmd.Parameters[0].Value = dateOperation.Value;

            con.Close();
            con.Open();
            try
            {

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Mis à jour effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = "";
                    dateOperation.Text = "";
                    txtmois.Text = "";
                    cbdevise.Text = "";
                    ttxtmontant.Text = "";
                    cbmatstruct.Text = "";
                    cbidtypeop.Text = "";
                    cbsouscompte.Text = "";
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

        private void btnsuprime_Click_1(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM operation WHERE IdOp =" + textBox2.Text;
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

        private void btnactu_Click(object sender, EventArgs e)
        {
            actualiserdgv("");
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            actualiserdgv(textBox5.Text);
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            actualiserdgv(textBox4.Text);
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            actualiserdgv(textBox3.Text);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            actualiserdgv(textBox1.Text);
        }
    }
}
