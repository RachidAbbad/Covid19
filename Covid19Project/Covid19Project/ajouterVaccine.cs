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
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        Persistance pers ;

        public ajouterVaccine(string _cin,MySqlConnection _cnn)
        { 
            InitializeComponent();
            cin = _cin;
            cnn = _cnn;
            cinCombobox.Text = cin;
            fillVaccinCombobox();
            pers = new Persistance();
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
                    pers.insertVaccine(cin, vaccinCombobox.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    pers.changeGravite(cin, "Faible");
                    this.Close();
            }     
        }
    }
}
