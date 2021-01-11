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
        private int timeLeft = 10;
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        string cin;
        Persistance persistance_instance ;


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
            DisableButtons();
            persistance_instance = new Persistance();
            remplir_Data_Grid();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Stop();
        }
        private void remplir_Data_Grid()
        {
            persistance_instance.fillDataGrid(citoyenDataGrid, "citoyen");
            persistance_instance.fillDataGrid(patientDataGrid, "patient");
            persistance_instance.fillDataGrid(retablieDataGrid, "retablie");
            persistance_instance.fillDataGrid(suspectDataGrid, "suspect");
            persistance_instance.fillDataGrid(vaccineDataGrid, "vaccine");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            retabliePanel.Visible = false;
            citoyenPanel.Visible = true;
            vaccinePanel.Visible = false;
            persistance_instance.fillDataGrid(citoyenDataGrid, "citoyen");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = true;
            retabliePanel.Visible = false;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = false;
            persistance_instance.fillDataGrid(suspectDataGrid, "suspect");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = true;
            suspectPanel.Visible = false;
            retabliePanel.Visible = false;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = false;
            persistance_instance.fillDataGrid(patientDataGrid, "patient");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            retabliePanel.Visible = true;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = false;
            persistance_instance.fillDataGrid(retablieDataGrid, "retablie");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            retabliePanel.Visible = false;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = true;
            persistance_instance.fillDataGrid(vaccineDataGrid, "vaccine");
        }

        //Afficher les données de BD en DatagridView
        

        private void button5_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow dr = new DataGridViewRow();
            for (int i = 0; i < citoyenDataGrid.Rows.Count; i++)
            {
                dr = citoyenDataGrid.Rows[i];
                if (dr.Selected == true)
                {
                    cin = citoyenDataGrid.Rows[i].Cells[0].Value.ToString();
                }
            }
            ajouterVaccine ajout = new ajouterVaccine(cin,cnn);
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
                    cin = suspectDataGrid.Rows[i].Cells[0].Value.ToString();
                }
            }
            faireTest test = new faireTest(cin,cnn,"suspect");
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
                }
            }
            faireTest test = new faireTest(cin,cnn,"patient");
            test.Show();
            
        }
        //Ajout au list du suspects 
        private void button7_Click(object sender, EventArgs e)//Solved
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
            persistance_instance.insertSuspect(cin);
            persistance_instance.changeGravite(cin, "Moyen");
        }

        //Mettre en quarantine
        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            for (int i = 0; i < patientDataGrid.Rows.Count; i++)
            {
                if (dr.Selected == true)
                {
                    cin = patientDataGrid.Rows[i].Cells[1].Value.ToString();
                }
            }
            persistance_instance.fillDataGrid(patientDataGrid, "patient");
            persistance_instance.Mettre_Quarantine(cin);
            timer1.Start();
        }

        //Actualiser les dataGrid contenu
        private void Form1_Activated(object sender, EventArgs e)
        {
            remplir_Data_Grid();
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
            carnetSanitaire carnet = new carnetSanitaire(cin, faitvaccin, DateVaccination,cnn);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRestantQuarantine.Text =  timeLeft.ToString()+" Sec";
            timeLeft -= 1;

            if (timeLeft < 0)
            {
                timer1.Stop();
                faireTest test = new faireTest(cin,cnn,"patient");
                test.Show();
                timeLeft = 10;
            }
        }
    }
}
