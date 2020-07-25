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
    public partial class Calculs : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;uid=root;pwd='';database=nteko");
        MySqlCommand cmd;
        public Calculs()
        {
            InitializeComponent();
        }

        private void Calculs_Load(object sender, EventArgs e)
        {
            afficherecette("");
            calculer_repport();


        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //actualiserdgv(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //actualiserdgv(textBox2.Text);
        }
        private void afficherecette(string Recherche)
        {           
    
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //afficherecette(textBox3.Text);
        }

        private void btnCalculerSolde_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            //------------------------------------- calcul de la caisse ------------------------------------------
            //--------------------------------recette à fc -------------------------------------------------------
            afficherecette("");
            cmd = new MySqlCommand("SELECT SUM(op.Montant) FROM operation as op join typeop as tp on tp.IdType = op.IdType join structure as st on st.MatriculeStrict = op.MatriculeStrict group by op.Devise, tp.Designation, st.NomStructure, op.MoisAnnee having st.NomStructure LIKE '" + structure.Text + "%'  AND op.MoisAnnee = '" + moisannee.Text + "' AND Devise='Fc' AND Designation='Recette'", con);
            cmd.CommandType = CommandType.Text;
            

            decimal recetteCDF;
            try
            {
                recetteCDF = (decimal)cmd.ExecuteScalar();
            }
            catch(NullReferenceException)
            {
                recetteCDF = 0;
            }
            catch(InvalidCastException)
            {
                recetteCDF = 0;
            }
            labelSoldeCDF.Text = recetteCDF.ToString();
            //----------------------------------------------depense à fc -------------------------------------------------------
            cmd = new MySqlCommand("SELECT SUM(op.Montant) FROM operation as op join typeop as tp on tp.IdType = op.IdType join structure as st on st.MatriculeStrict = op.MatriculeStrict group by op.Devise, tp.Designation, st.NomStructure, op.MoisAnnee having st.NomStructure LIKE '" + structure.Text + "%'  AND op.MoisAnnee = '" + moisannee.Text + "' AND Devise='Fc' AND Designation='Depense'", con);
            cmd.CommandType = CommandType.Text;
            

            decimal depenseCDF;
            decimal convertion;
            try
            {
                depenseCDF = (decimal)cmd.ExecuteScalar();
            }
            catch (NullReferenceException)
            {
                depenseCDF = 0;
            }
            catch (InvalidCastException)
            {
                depenseCDF = 0;
            }
            
            labelSoldeCDF.Text = (recetteCDF - depenseCDF).ToString();
            convertion = (decimal.Parse(labelSoldeCDF.Text) / decimal.Parse(txttaut.Text));
            lblconvertion.Text = convertion.ToString();

            //-------------------------------------------------------------- recette en $ -----------------------
            cmd = new MySqlCommand("SELECT SUM(op.Montant) FROM operation as op join typeop as tp on tp.IdType = op.IdType join structure as st on st.MatriculeStrict = op.MatriculeStrict group by op.Devise, tp.Designation, st.NomStructure, op.MoisAnnee having st.NomStructure LIKE '" + structure.Text + "%'  AND op.MoisAnnee = '" + moisannee.Text + "' AND Devise='$' AND Designation='Recette'", con);
            cmd.CommandType = CommandType.Text;
            

            decimal recetteUSD;
            try
            {
                recetteUSD = (decimal)cmd.ExecuteScalar();
            }
            catch (NullReferenceException)
            {
                recetteUSD = 0;
            }
            catch (InvalidCastException)
            {
                recetteUSD = 0;
            }
            labelSoldeUSD.Text = recetteUSD.ToString();
            //--------------------------------- depense en $ -------------------------------------------------------------------
            cmd = new MySqlCommand("SELECT SUM(op.Montant) FROM operation as op join typeop as tp on tp.IdType = op.IdType join structure as st on st.MatriculeStrict = op.MatriculeStrict group by op.Devise, tp.Designation, st.NomStructure, op.MoisAnnee having st.NomStructure LIKE '" + structure.Text + "%'  AND op.MoisAnnee = '" + moisannee.Text + "' AND Devise='$' AND Designation='Depense'", con);
            cmd.CommandType = CommandType.Text;
           

            decimal depenseUSD;
            try
            {
                depenseUSD = (decimal)cmd.ExecuteScalar();
            }
            catch (NullReferenceException)
            {
                depenseUSD = 0;
            }
            catch (InvalidCastException)
            {
                depenseUSD = 0;
            }

            labelSoldeUSD.Text = (recetteUSD - depenseUSD).ToString();
            //total------------------------------------------ total du mois -------------------------------------------
            cmd = new MySqlCommand("SELECT SUM(op.Montant) FROM operation as op join typeop as tp on tp.IdType = op.IdType join structure as st on st.MatriculeStrict = op.MatriculeStrict group by op.Devise, tp.Designation, st.NomStructure, op.MoisAnnee having st.NomStructure LIKE '" + structure.Text + "%'  AND op.MoisAnnee = '" + moisannee.Text + "' AND Devise='$'", con);
            cmd.CommandType = CommandType.Text;
            

            decimal soldetotal;
           
            try
            {
                soldetotal = (decimal)cmd.ExecuteScalar();
            }
            catch (NullReferenceException)
            {
                soldetotal = 0;
            }
            catch (InvalidCastException)
            {
                soldetotal = 0;
            }
            labelsoldetotal.Text = (decimal.Parse(txtmoispasser.Text) + convertion + decimal.Parse(labelSoldeUSD.Text)).ToString();
            //--------------------------------------------------------------------------------------------------------------
            //------------------------------------- fin pour la caisse -------------------------------------------



            //------------------------------------- calcul de la banque ------------------------------------------
           
            afficherecette("");
           
            //-------------------------------------------------------------- recette en $ -----------------------
            cmd = new MySqlCommand("SELECT SUM(op.montantBq) FROM banque as op join typeop as tp on tp.IdType = op.IdType join structure as st on st.MatriculeStrict = op.MatriculeStrict group by op.deviseBq, tp.Designation, st.NomStructure, op.moisAnneeBq having st.NomStructure LIKE '" + structure.Text + "%'  AND op.moisAnneeBq = '" + moisannee.Text + "' AND deviseBq='$' AND Designation='Recette'", con);
            cmd.CommandType = CommandType.Text;


            decimal recetteUSDbq;
            try
            {
                recetteUSDbq = (decimal)cmd.ExecuteScalar();
            }
            catch (NullReferenceException)
            {
                recetteUSDbq = 0;
            }
            catch (InvalidCastException)
            {
                recetteUSDbq = 0;
            }
            labelSoldeUSDbq.Text = recetteUSDbq.ToString();
            //--------------------------------- depense en $ -------------------------------------------------------------------
            cmd = new MySqlCommand("SELECT SUM(op.montantBq) FROM banque as op join typeop as tp on tp.IdType = op.IdType join structure as st on st.MatriculeStrict = op.MatriculeStrict group by op.deviseBq, tp.Designation, st.NomStructure, op.moisAnneeBq having st.NomStructure LIKE '" + structure.Text + "%'  AND op.moisAnneeBq = '" + moisannee.Text + "' AND deviseBq='$' AND Designation='Depense'", con);
            cmd.CommandType = CommandType.Text;


            decimal depenseUSDbq;
            try
            {
                depenseUSDbq = (decimal)cmd.ExecuteScalar();
            }
            catch (NullReferenceException)
            {
                depenseUSDbq = 0;
            }
            catch (InvalidCastException)
            {
                depenseUSDbq = 0;
            }

            labelSoldeUSDbq.Text = (recetteUSDbq - depenseUSDbq).ToString();
            //total------------------------------------------ total du mois -------------------------------------------
            
            decimal soldetotalbq;
            try
            {
                soldetotalbq = (decimal)cmd.ExecuteScalar();
            }
            catch (NullReferenceException)
            {
                soldetotalbq = 0;
            }
            catch (InvalidCastException)
            {
                soldetotalbq = 0;
            }
            labelsoldetotalbq.Text = (decimal.Parse(txtmoispasserbq.Text) + decimal.Parse(labelSoldeUSDbq.Text)).ToString();
            //--------------------------------------------------------------------------------------------------------------
            //------------------------------------- fin pour la banque ----------------------------------------------------
            //--------------------------------------Solde final ------------------------------------------------------------
            soldefinmois.Text = (decimal.Parse(txtmoispasserbq.Text) + decimal.Parse(labelSoldeUSDbq.Text)+ decimal.Parse(txtmoispasser.Text) + convertion + decimal.Parse(labelSoldeUSD.Text)).ToString();


            lbltotcaisse.Text = decimal.Parse(labelsoldetotal.Text).ToString();
            lbltotbanque.Text = decimal.Parse(labelsoldetotalbq.Text).ToString();
            //------------------------------------------fin ----------------------------------------------------------------
            con.Close();
        }

        private void structure_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficherecette(structure.Text);
        }

        private void moisannee_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficherecette(moisannee.Text);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelSoldeUSDbq_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void calculer_repport()
        {
            cmd = new MySqlCommand("SELECT SUM(op.Montant) FROM operation as op join typeop as tp on tp.IdType = op.IdType join structure as st on st.MatriculeStrict = op.MatriculeStrict group by op.Devise, tp.Designation, st.NomStructure, op.MoisAnnee having st.NomStructure LIKE '" + structure.Text + "%'  AND op.MoisAnnee = '" + cbxmoisprecedent.Text + "' AND Devise='$'", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            decimal SOLDE_PRECEDENT;

            try
            {
                con.Open();
                SOLDE_PRECEDENT = (decimal)cmd.ExecuteScalar();


            }

            catch (NullReferenceException)
            {

                SOLDE_PRECEDENT = 0;

            }
            catch (InvalidCastException)
            {

                SOLDE_PRECEDENT = 0;

            }
            finally
            {
                con.Close();
            }
            txtmoispasser.Text = SOLDE_PRECEDENT.ToString();
            //SOLDE_PRECEDENT = decimal.Parse(labelsoldetotal.Text);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
