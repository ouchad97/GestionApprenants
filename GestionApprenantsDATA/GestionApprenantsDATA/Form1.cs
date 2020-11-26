using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionApprenantsDATA
{
    public partial class Form1 : Form
    {
        private int i;
        System.Text.RegularExpressions.Regex rTEL = new System.Text.RegularExpressions.Regex(@"^[0][5-7][0-9]{8}$");
        System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
        System.Text.RegularExpressions.Regex rPrenm = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z]+(([a-zA-Z ])?[a-zA-Z]*)*$");
        System.Text.RegularExpressions.Regex rNom = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z]+(([a-zA-Z ])?[a-zA-Z]*)*$");
       
        public static DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Declaration.connecte();
            string req = "select * from Apprenant";
            Declaration.select(req);
            dt = new DataTable();
            dt.Load(Declaration.dr);
            dataGridView1.DataSource = dt;
            Declaration.deconnecte();

            ID.Enabled = false;

            pays.DataSource = new[]{"Maroc","France","Espagne"};
            specialite.DataSource = new[] {"C#","JEE","FEBE"};
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                ID.Text = row.Cells[0].Value.ToString();
                nom.Text = row.Cells[1].Value.ToString();
                prenom.Text = row.Cells[2].Value.ToString();
                email.Text = row.Cells[3].Value.ToString();
                phone.Text = row.Cells[4].Value.ToString();
                adresse.Text = row.Cells[5].Value.ToString();
                pays.Text = row.Cells[6].Value.ToString();
                ville.Text = row.Cells[7].Value.ToString();
                specialite.Text = row.Cells[8].Value.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e){
            foreach (Control x in this.Controls){
                if (x is TextBox){ ((TextBox)x).Text = String.Empty;}
                if (x is ComboBox){ ((ComboBox)x).Text = String.Empty;}}

            Declaration.connecte();
            string req = "select * from Apprenant";
            Declaration.select(req);
            dt = new DataTable();
            dt.Load(Declaration.dr);
            dataGridView1.DataSource = dt;
            Declaration.deconnecte();
        }

        private void button1_Click(object sender, EventArgs e){
            //Pour Ajouter
            string req1;
            Declaration.connecte();
            try{
                req1 = ("insert into Apprenant values('" + nom.Text + "','" + prenom.Text + "','" + email.Text + "'," + phone.Text + ",'" + adresse.Text + "','" + pays.Text + "','" + ville.Text + "','" + specialite.Text + "')");
                Declaration.cmd = new SqlCommand(req1, Declaration.cn);



                //Nom Regex
                if (string.IsNullOrEmpty(nom.Text)){
                        errorProvider1.SetError(nom, "Le nom est obligatoire!");
                        i = 0;
                }else if (!rNom.IsMatch(nom.Text)){
                            errorProvider1.SetError(nom, "Le nom n'est pas correct"); 
                            i = 0;
                        }


                //Prenom Regex
                if (string.IsNullOrEmpty(nom.Text)){
                        errorProvider1.SetError(nom, "Le Prenom est obligatoire!");
                        i = 0;
                }else if (!rPrenm.IsMatch(nom.Text)){
                            errorProvider1.SetError(nom, "Le Prenom n'est pas correct");
                            i = 0;
                }



                //Email Regex
               if (string.IsNullOrEmpty(email.Text)){
                    errorProvider1.SetError(email, "Email est obligatoire!");
                    i = 0;
                }else if (!rEMail.IsMatch(email.Text)){
                    errorProvider1.SetError(email, "Email n'est pas correct");
                    i = 0;
                }


                //Tel Regex
                if (string.IsNullOrEmpty(phone.Text)){
                    errorProvider1.SetError(phone, "Phone est obligatoire!");
                    i = 0;
                }else if (!rTEL.IsMatch(phone.Text)){
                    errorProvider1.SetError(phone, "Phone n'est pas correct");
                    i = 0;
                }


                //AJOUT
                if ((rPrenm.IsMatch(nom.Text)) && (rNom.IsMatch(prenom.Text)) && (rEMail.IsMatch(email.Text)) && (rTEL.IsMatch(phone.Text))) {
                    errorProvider1.SetError(nom, null); 
                    errorProvider1.SetError(prenom, null);
                    errorProvider1.SetError(email, null);
                    errorProvider1.SetError(phone, null);
                    i = Declaration.cmd.ExecuteNonQuery();
                }

                if (i == 1) {
                    MessageBox.Show("Ajout effectué avec succès");
                    Declaration.deconnecte();
                    //dataGridView1.Refresh();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox ville 
            if (pays.SelectedItem.ToString() == "Maroc")
            {
                ville.Items.Clear();
                ville.Items.Add("Rabat");
                ville.Items.Add("Casablanca");
                ville.Items.Add("Safi");
                ville.Items.Add("Fes");
                ville.Items.Add("Agadir");
            }
            else
            {
                if (pays.SelectedItem.ToString() == "France")
                {
                    ville.Items.Clear();
                    ville.Items.Add("Marseille");
                    ville.Items.Add("Bordeaux");
                    ville.Items.Add("Strasbourg");
                    ville.Items.Add("Lyon");
                    ville.Items.Add("Paris");
                }

                if (pays.SelectedItem.ToString() == "Espagne")
                {   ville.Items.Clear();
                    ville.Items.Add("Barcelona");
                    ville.Items.Add("Seville");
                    ville.Items.Add("Madrid");
                    ville.Items.Add("Bilbao");
                    ville.Items.Add("Granada");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Declaration.connecte();
            try{
                string req2 = "update Apprenant set nom='" + nom.Text + "',prenom='" + prenom.Text + "',email='" + email.Text + "',telephone=" + phone.Text + ",adresse='" + adresse.Text + "',pays='" + pays.Text + "',ville='" + ville.Text + "',specialite='" + specialite.Text + "' where IdAp=" + ID.Text;
            Declaration.cmd = new SqlCommand(req2, Declaration.cn);


            //Nom Regex
            if (string.IsNullOrEmpty(nom.Text))
            {
                errorProvider1.SetError(nom, "Le nom est obligatoire!");
                i = 0;
            }
            else if (!rNom.IsMatch(nom.Text))
            {
                errorProvider1.SetError(nom, "Le nom n'est pas correct");
                i = 0;
            }


            //Prenom Regex
            if (string.IsNullOrEmpty(nom.Text))
            {
                errorProvider1.SetError(nom, "Le Prenom est obligatoire!");
                i = 0;
            }
            else if (!rPrenm.IsMatch(nom.Text))
            {
                errorProvider1.SetError(nom, "Le Prenom n'est pas correct");
                i = 0;
            }



            //Email Regex
            if (string.IsNullOrEmpty(email.Text))
            {
                errorProvider1.SetError(email, "Email est obligatoire!");
                i = 0;
            }
            else if (!rEMail.IsMatch(email.Text))
            {
                errorProvider1.SetError(email, "Email n'est pas correct");
                i = 0;
            }


            //Tel Regex
            if (string.IsNullOrEmpty(phone.Text))
            {
                errorProvider1.SetError(phone, "Phone est obligatoire!");
                i = 0;
            }
            else if (!rTEL.IsMatch(phone.Text))
            {
                errorProvider1.SetError(phone, "Phone n'est pas correct");
                i = 0;
            }


            //AJOUT
            if ((rPrenm.IsMatch(nom.Text)) && (rNom.IsMatch(prenom.Text)) && (rEMail.IsMatch(email.Text)) && (rTEL.IsMatch(phone.Text)))
            {
                errorProvider1.SetError(nom, null);
                errorProvider1.SetError(prenom, null);
                errorProvider1.SetError(email, null);
                errorProvider1.SetError(phone, null);
                i = Declaration.cmd.ExecuteNonQuery();
            }

            if (i == 1)
            {
                MessageBox.Show("Modification effectué avec succès");

                Declaration.deconnecte();
                //dataGridView1.Refresh();
                //this.Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string req3 = "delete from Apprenant where IdAp=" + ID.Text;

            try {
                Declaration.connecte();
                Declaration.cmd = new SqlCommand(req3, Declaration.cn);
                i = Declaration.cmd.ExecuteNonQuery();
                if (i == 0){
                    MessageBox.Show("Echec de suppression");
                    this.Close();
                }else{
                    MessageBox.Show("Element supprimer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                Declaration.connecte();
                string req4 = "SELECT COUNT(IdAp)FROM Apprenant";
                Declaration.select(req4);
                dt = new DataTable();
                dt.Load(Declaration.dr);
                MessageBox.Show(dt.Rows[0][0].ToString());
                Declaration.deconnecte();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
