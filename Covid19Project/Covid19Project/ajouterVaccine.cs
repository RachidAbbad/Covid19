using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public ajouterVaccine(MySqlConnection _cnn)
        {
            InitializeComponent();
            cnn = _cnn;
            fillVaccinCombobox();
        }

        public ajouterVaccine(string _cin, MySqlConnection _cnn)
        { 
            InitializeComponent();
            cin = _cin;
            cnn = _cnn;
            cinCombobox.Text = cin;
            fillVaccinCombobox();
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
                        "update citoyen set gravite = 'Faible' Where cinciroyen = '"+cin+"';";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Le citoyen a été ajouté à la liste des vacciné");
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
