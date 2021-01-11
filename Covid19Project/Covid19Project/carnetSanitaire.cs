using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Covid19Project
{
    public partial class carnetSanitaire : Form
    {
        private string cin;
        private string faitvaccin;
        private string DateVaccination;
        MySqlCommand cmd;
        MySqlConnection cnn;
        MySqlDataReader myReader;
        public carnetSanitaire(string _cin, string _faitvaccin, string _DateVaccination, MySqlConnection _cnn)
        {
            InitializeComponent();
            cin = _cin;
            faitvaccin = _faitvaccin;
            cnn = _cnn;
            DateVaccination = _DateVaccination;//.Substring(0,9);
            fillLabelVaccin();
            fillLabelHistorique();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillLabelVaccin()
        {
            cinLabel.Text += cin;
            if (faitvaccin == "0")
                faitvaccinLabel.Text = "Vaccin non Fait";
            else if(faitvaccin == "1")
                faitvaccinLabel.Text = "Vaccin Fait";
            datevaccinationLabel.Text = DateVaccination;
        }
        private void fillLabelHistorique()
        {
            try
            {
                cnn.Open();
                cmd = new MySqlCommand("Select DateMaladie FROM historiquemaladie WHERE cinPatient='" + cin + "'",cnn);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    historiqueLabel.Text += "\n" + myReader.GetString(0).Substring(0,9);
                    Console.WriteLine(myReader.ToString());
                }
                myReader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
