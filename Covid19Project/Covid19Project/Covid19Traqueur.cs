using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Covid19Project.classes;
using MySql.Data.MySqlClient;

namespace Covid19Project
{
    public partial class Form1 : Form
    {
        private string serveur = "127.0.0.1";
        private string user = "root";
        private string pass = "";
        private string db = "covid19";
        private MySqlConnection cnn ;
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        private Citoyen citoyen;
        string cin, nom, prenom, adresse, sexe, numTel;
        int age;
        DateTime date = new DateTime();

        public void Connection()
        {
            string StringConn = "server="+ serveur + ";database="+ db + ";uid="+ user + ";pwd="+ pass +";";
            cnn = new MySqlConnection(StringConn);
            try
            {
                cnn.Open();
                cnn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            retabliePanel.Visible = false;
            citoyenPanel.Visible = true;
            vaccinePanel.Visible = false;
            Connection();
            fillDataGrid(citoyenDataGrid,"citoyen");
            fillDataGrid(patientDataGrid,"patient");
            fillDataGrid(retablieDataGrid,"retablie");
            fillDataGrid(suspectDataGrid,"suspect");
            fillDataGrid(vaccineDataGrid,"vaccine");
            DisableButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            retabliePanel.Visible = false;
            citoyenPanel.Visible = true;
            vaccinePanel.Visible = false;
            fillDataGrid(citoyenDataGrid, "citoyen");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = true;
            retabliePanel.Visible = false;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = false;
            fillDataGrid(suspectDataGrid, "suspect");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = true;
            suspectPanel.Visible = false;
            retabliePanel.Visible = false;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = false;
            fillDataGrid(patientDataGrid, "patient");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            retabliePanel.Visible = true;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = false;
            fillDataGrid(retablieDataGrid, "retablie");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            retabliePanel.Visible = false;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = true;
            fillDataGrid(vaccineDataGrid, "vaccine");
        }

        //Afficher les données de BD en DatagridView
        public void fillDataGrid(DataGridView d,string nameTable)
        {
            if(cnn.State.ToString() == "close")
            cnn.Open();
            if(d == citoyenDataGrid)
            {
                string cmdString = "select * from " + nameTable;
                cmd = new MySqlCommand(cmdString, cnn);
                sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                d.DataSource = dt;
                for (int i = 0; i < citoyenDataGrid.Rows.Count; i++)
                {
                    if (citoyenDataGrid.Rows[i].Cells[7].Value?.ToString() == "Faible")
                    {
                        citoyenDataGrid.Rows[i].Cells[7].Style.BackColor = Color.Green;
                    }
                    else if (citoyenDataGrid.Rows[i].Cells[7].Value?.ToString() == "Moyen")
                    {
                        citoyenDataGrid.Rows[i].Cells[7].Style.BackColor = Color.Orange;
                    }
                    else if (citoyenDataGrid.Rows[i].Cells[7].Value?.ToString() == "Haute")
                    {
                        citoyenDataGrid.Rows[i].Cells[7].Style.BackColor = Color.Red;
                    }

                }
                cnn.Close();
            }
            else
            {
                string cmdString = "select * from " + nameTable + ",citoyen WHERE citoyen.cinCitoyen=" + nameTable + ".cin"+nameTable;
                cmd = new MySqlCommand(cmdString, cnn);
                sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dt.Columns.Remove("cinCitoyen");
                d.DataSource = dt;
                for (int i = 0; i < citoyenDataGrid.Rows.Count; i++)
                {
                    if (citoyenDataGrid.Rows[i].Cells[7].Value?.ToString() == "Faible")
                    {
                        citoyenDataGrid.Rows[i].Cells[7].Style.BackColor = Color.Green;
                    }
                    else if (citoyenDataGrid.Rows[i].Cells[7].Value?.ToString() == "Moyen")
                    {
                        citoyenDataGrid.Rows[i].Cells[7].Style.BackColor = Color.Orange;
                    }
                    else if (citoyenDataGrid.Rows[i].Cells[7].Value?.ToString() == "Haute")
                    {
                        citoyenDataGrid.Rows[i].Cells[7].Style.BackColor = Color.Red;
                    }

                }
            }
            cnn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow dr = new DataGridViewRow();
            for (int i = 0; i < citoyenDataGrid.Rows.Count; i++)
            {
                dr = citoyenDataGrid.Rows[i];
                if (dr.Selected == true)
                {
                    cin = citoyenDataGrid.Rows[i].Cells[0].Value.ToString();
                    nom = citoyenDataGrid.Rows[i].Cells[1].Value.ToString();
                    prenom = citoyenDataGrid.Rows[i].Cells[2].Value.ToString();
                    adresse = citoyenDataGrid.Rows[i].Cells[3].Value.ToString();
                    numTel = citoyenDataGrid.Rows[i].Cells[4].Value.ToString();
                    age = int.Parse(citoyenDataGrid.Rows[i].Cells[5].Value.ToString());
                    sexe = citoyenDataGrid.Rows[i].Cells[6].Value.ToString();
                }
            }
            citoyen = new Citoyen(nom, prenom, age, sexe, cin, adresse, numTel);
            ajouterVaccine ajout = new ajouterVaccine(citoyen,cnn);
            ajout.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            for (int i = 0; i < suspectDataGrid.Rows.Count; i++)
            {
                dr = suspectDataGrid.Rows[i];
                if (dr.Selected == true)
                {
                    cin = suspectDataGrid.Rows[i].Cells[1].Value.ToString();
                    nom = suspectDataGrid.Rows[i].Cells[2].Value.ToString();
                    prenom = suspectDataGrid.Rows[i].Cells[3].Value.ToString();
                    adresse = suspectDataGrid.Rows[i].Cells[4].Value.ToString();
                    numTel = suspectDataGrid.Rows[i].Cells[5].Value.ToString();
                    sexe = suspectDataGrid.Rows[i].Cells[7].Value.ToString();
                }
            }
            citoyen = new Citoyen(nom, prenom, age, sexe, cin, adresse, numTel);
            faireTest test = new faireTest(citoyen,cnn,"suspect");
            test.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            for (int i = 0; i < patientDataGrid.Rows.Count; i++)
            {
                if (dr.Selected == true)
                {
                    cin = patientDataGrid.Rows[i].Cells[1].Value.ToString();
                    nom = patientDataGrid.Rows[i].Cells[2].Value.ToString();
                    prenom = patientDataGrid.Rows[i].Cells[3].Value.ToString();
                    adresse = patientDataGrid.Rows[i].Cells[4].Value.ToString();
                    numTel = patientDataGrid.Rows[i].Cells[5].Value.ToString();
                    sexe = patientDataGrid.Rows[i].Cells[7].Value.ToString();
                }
            }
            citoyen = new Citoyen(nom, prenom, age, sexe, cin, adresse, numTel);
            faireTest test = new faireTest(citoyen,cnn,"patient");
            test.Show();
            
        }

        private void ajoutVaccineVP_Click(object sender, EventArgs e)
        {
            ajouterVaccine ajout = new ajouterVaccine(cnn);
            ajout.Show();
        }

        //Ajout au list du suspects (Changer l'etat)
        private void button7_Click(object sender, EventArgs e)
        {
            string cin = null;
            DataGridViewRow dr = new DataGridViewRow();
            for (int i = 0; i < citoyenDataGrid.Rows.Count; i++)
            {
                dr = citoyenDataGrid.Rows[i];
                if (dr.Selected == true)
                {
                    cin = citoyenDataGrid.Rows[i].Cells[0].Value.ToString();
                }
            }
            try
            {
                cnn.Open();
                cmd.CommandText = "INSERT INTO suspect(cinsuspect) VALUES ('" + cin + "');" +
                    "update citoyen set gravite = 'Moyen' Where cincitoyen = '"+cin+"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le citoyen a été ajouté à la liste des suspects");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Actualiser les dataGrid contenu
        private void Form1_Activated(object sender, EventArgs e)
        {
            fillDataGrid(citoyenDataGrid, "citoyen");
            fillDataGrid(patientDataGrid, "patient");
            fillDataGrid(retablieDataGrid, "retablie");
            fillDataGrid(suspectDataGrid, "suspect");
            fillDataGrid(vaccineDataGrid, "vaccine");
        }

        //Desiactiver La MOdificattion en DataGridView
        private void DisableEditData()
        {
            patientDataGrid.ReadOnly = true;
            citoyenDataGrid.ReadOnly = true;
            retablieDataGrid.ReadOnly = true;
            suspectDataGrid.ReadOnly = true;
            vaccineDataGrid.ReadOnly = true;
        }

        private void DisableButtons()
        {
            button7.Enabled = false;
            button5.Enabled = false;
            button8.Enabled = false;
            button10.Enabled = false;
            button13.Enabled = false;
            button6.Enabled = false;
        }

        //Afficher le carnet sanitaire de citoyen
        private void button8_Click(object sender, EventArgs e)
        {
            string cin = null;
            string faitvaccin = null;
            string DateVaccination = null;
            DataGridViewRow dr = new DataGridViewRow();
            for (int i = 0; i < citoyenDataGrid.Rows.Count; i++)
            {
                dr = citoyenDataGrid.Rows[i];
                if (dr.Selected == true)
                {
                    cin = citoyenDataGrid.Rows[i].Cells[0].Value.ToString();
                    cnn.Open();
                    string cmdString = "select faitvaccin,datevaccination from carnetsanitaire where cincitoyen ='"+cin+"';";
                    cmd = new MySqlCommand(cmdString, cnn);
                    sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cnn.Close();
                    faitvaccin = dt.Rows[0]["faitvaccin"].ToString();
                    DateVaccination = dt.Rows[0]["datevaccination"].ToString();
                }
            }
            carnetSanitaire carnet = new carnetSanitaire(cin, faitvaccin, DateVaccination);
            carnet.Show();
        }

        private void ActivateButtons(object sender, EventArgs e)
        {
            if(citoyenDataGrid.SelectedRows.Count > 0)
            {
                button7.Enabled = true;
                button5.Enabled = true;
                button8.Enabled = true;
            }
            if (patientDataGrid.SelectedRows.Count > 0)
            {
                button13.Enabled = true;
                button6.Enabled = true;
            }
            if (suspectDataGrid.SelectedRows.Count > 0)
            {
                button10.Enabled = true;
            }

        }
    }
}
