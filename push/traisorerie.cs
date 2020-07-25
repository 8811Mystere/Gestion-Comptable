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
    public partial class traisorerie : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public traisorerie()
        {
            InitializeComponent();
        }

        private void traisorerie_Load(object sender, EventArgs e)
        {
            actualiserdgv("");
            actualiserdgv2("");
        }
        private void actualiserdgv(string recherche)
        {
            cmd = new MySqlCommand("SELECT operation.MoisAnnee,compte.Numero,compte.Nom, souscompte.NomCpt, structure.NomStructure, SUM(operation.Montant) as Montants,operation.Devise FROM operation, compte, souscompte, typeop, structure WHERE compte.IdCompt=souscompte.IdCompt and souscompte.IdSousCpt=operation.IdSousCpt and typeop.IdType=operation.IdType and structure.MatriculeStrict=operation.MatriculeStrict group by operation.MoisAnnee, souscompte.NomCpt, typeop.Designation, structure.NomStructure,operation.Devise AND structure.NomStructure LIKE '" + textBox1.Text + "%'  AND operation.MoisAnnee LIKE '" + textBox2.Text + "%' AND typeop.Designation='" + textBox4.Text + "'",con);
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
        private void actualiserdgv2(string recherche)
        {
            cmd = new MySqlCommand("SELECT op.MoisAnnee, st.NomStructure, tp.Designation, SUM(op.Montant) as Somme, op.Devise FROM operation as op join typeop as tp on tp.IdType = op.IdType join structure as st on st.MatriculeStrict = op.MatriculeStrict group by op.Devise, tp.Designation, st.NomStructure, op.MoisAnnee AND st.NomStructure LIKE '" + textBox1.Text + "%'  AND op.MoisAnnee LIKE '" + textBox2.Text + "%' AND tp.Designation='" + textBox4.Text +"'", con);
            cmd.CommandType = CommandType.Text; 
            try
            {
                con.Open();
            cmd.Connection = con;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            actualiserdgv(textBox1.Text);
            actualiserdgv2(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            actualiserdgv(textBox2.Text);
            actualiserdgv2(textBox2.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            actualiserdgv(textBox4.Text);
            actualiserdgv2(textBox4.Text);
        }
    }
}
