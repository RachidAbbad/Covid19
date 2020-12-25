using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
<<<<<<< Updated upstream
=======
using System.Data.SqlClient;
>>>>>>> Stashed changes
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using MySql.Data.MySqlClient;
>>>>>>> Stashed changes

namespace Covid19Project
{
    public partial class Form1 : Form
    {
<<<<<<< Updated upstream
=======
        private string serveur = "localhost";
        private string user = "root";
        private string pass = "";
        private string db = "gestion_du_stock";
        private MySqlConnection cnn = new MySqlConnection();
        SqlCommand cmd;
        SqlDataAdapter sda;
        public void Connection()
        {
            string StringConn = "SERVEUR =" + serveur + ";DATABASE = " + db + ";UID = " + user + "PASSWORD = " + pass;
            cnn = new MySqlConnection(StringConn);
            try
            {
                MessageBox.Show("succces");
                cnn.Open();
                cnn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
>>>>>>> Stashed changes
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======
        public void connection()
        {
            cnn.ConnectionString = @"Data Source=DESKTOP-10LGI3U\SQLEXPRESS;Initial Catalog = dbTest; User ID =sa; Password =password";
            try
            {
                cnn.Open();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
>>>>>>> Stashed changes

        private void Form1_Load(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
<<<<<<< Updated upstream
            vaccinateurPanel.Visible = false;
=======
            retabliePanel.Visible = false;
            citoyenPanel.Visible = true;
            vaccinePanel.Visible = false;
>>>>>>> Stashed changes
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
<<<<<<< Updated upstream
            vaccinateurPanel.Visible = false;
            citoyenPanel.Visible = true;
=======
            retabliePanel.Visible = false;
            citoyenPanel.Visible = true;
            vaccinePanel.Visible = false;
>>>>>>> Stashed changes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = true;
<<<<<<< Updated upstream
            vaccinateurPanel.Visible = false;
            citoyenPanel.Visible = false;
=======
            retabliePanel.Visible = false;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = false;
>>>>>>> Stashed changes
        }

        private void button3_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = true;
            suspectPanel.Visible = false;
<<<<<<< Updated upstream
            vaccinateurPanel.Visible = false;
            citoyenPanel.Visible = false;
=======
            retabliePanel.Visible = false;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = false;
>>>>>>> Stashed changes
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
<<<<<<< Updated upstream
            citoyenPanel.Visible = false;
            vaccinateurPanel.Visible = true;
=======
            retabliePanel.Visible = true;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            patientPanel.Visible = false;
            suspectPanel.Visible = false;
            retabliePanel.Visible = false;
            citoyenPanel.Visible = false;
            vaccinePanel.Visible = true;
        }
        public void fillDataGrid(DataGrid d,string nameTable)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ajouterVaccine ajout = new ajouterVaccine();
            ajout.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ajouterVaccine ajout = new ajouterVaccine(/*cin*/);
            ajout.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            faireTest test = new faireTest(/*cin*/);
            test.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            faireTest test = new faireTest(/*cin*/);
            test.Show();
>>>>>>> Stashed changes
        }
    }
}
