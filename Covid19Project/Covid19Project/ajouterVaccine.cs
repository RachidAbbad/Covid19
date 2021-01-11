using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Covid19Project.classes;
using MySql.Data.MySqlClient;

namespace Covid19Project
{
    public partial class ajouterVaccine : Form
    {
        private string cin;
        private DateTime dateVaccination;
        string typeVaccin;
        private MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        Vaccine vaccine;

        public ajouterVaccine(MySqlConnection _cnn)
        {
            InitializeComponent();
            cnn = _cnn;
            fillVaccinCombobox();
        }

        public ajouterVaccine(Citoyen _citoyen,MySqlConnection _cnn)
        { 
            InitializeComponent();
            cin = _citoyen.getCin();
            cnn = _cnn;
            cinCombobox.Text = cin;
            fillVaccinCombobox();
            vaccine = new Vaccine(_citoyen.getNom(),_citoyen.getPrenom(),_citoyen.getAge(),_citoyen.getSexe(),_citoyen.getCin(),_citoyen.getAdresse(),_citoyen.getNumTel());
        }

        public void fillVaccinCombobox()
        {
            cnn.Open();
            cmd = new MySqlCommand("select * from vaccins", cnn);
            sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Select Data source of every Combobox
            vaccinCombobox.DataSource = dt;

            //Select The name of colum
            vaccinCombobox.ValueMember = "nomVaccin";
            vaccinCombobox.DisplayMember = "nomVaccin";
            //name

            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(vaccinCombobox.Text != "" && cinCombobox.Text != "")
            {
                try
                {
                    cnn.Open();
                    cmd.CommandText = "INSERT INTO vaccine(cinVaccine,nomVaccin,dateVaccination) " +
                        "Values('" + cin + "', '"+ vaccinCombobox.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "');" +
                        "Update carnetSanitaire set  faitvaccin = true,datevaccination ='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' WHERE cincitoyen='" + cin + "';" +
                        "update citoyen set gravite = 'Faible' Where cincitoyen = '"+cin+"';" +
                        "DELETE FROM SUSPECT WHERE cinsuspect = '"+cin+"'";
                    cmd.ExecuteNonQuery();
                    vaccine.setDateVaccination(dateTimePicker1.Value);
                    MessageBox.Show("Le citoyen a été ajouté à la liste des vacciné");
                    this.Close();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }     
        }
    }
}
