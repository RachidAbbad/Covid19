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
    public partial class faireTest : Form
    {
        private string cin, Etat;
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        Persistance pers;
        public faireTest(string _cin,MySqlConnection _cnn,string _etat)
        {
            InitializeComponent();                                                      
            cin = _cin;
            typeTestCombobox.Text = cin;
            cnn = _cnn;
            resultatTestCombobox.Text ="---Choisir Résultat---";
            resultatTestCombobox.Items.Add("Negative");
            resultatTestCombobox.Items.Add("Positive");
            Etat = _etat;
            citoyenInfoLabel.Text += " : " +cin;
            fillTypeTestCombobox();
        }
        public void fillTypeTestCombobox()
        {
            cnn.Open();
            cmd = new MySqlCommand("select type from typetest", cnn);
            sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Select Data source of every Combobox
            typeTestCombobox.DataSource = dt;

            //Select The name of colum
            typeTestCombobox.ValueMember = "type";
            typeTestCombobox.DisplayMember = "type";
            cnn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pers  = new Persistance();
            if (Etat == "suspect")
                {
                    if(resultatTestCombobox.Text == "Negative")
                    {
                        pers.insertTest(cin, typeTestCombobox.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), "False");
                        pers.changeGravite(cin, "Faible");
                    }
                    else if(resultatTestCombobox.Text == "Positive")
                    {
                        pers.insertPatient(cin, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        pers.insertTest(cin, typeTestCombobox.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), "True");
                        pers.changeGravite(cin, "Haute");
                    }
                    pers.deleteSuspect(cin);
                    this.Close();
                }else if(Etat == "patient")
                {
                    if (resultatTestCombobox.Text == "Negative")
                    {
                        pers.insertTest(cin, typeTestCombobox.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), "False");
                        pers.insertRetablie(cin,dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        pers.deletePatient(cin);
                        pers.changeGravite(cin, "Faible");
                    }
                    else if (resultatTestCombobox.Text == "Positive")
                    {
                        pers.insertTest(cin, typeTestCombobox.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), "True");
                        MessageBox.Show("Le patient est toujours porteur du virus.");
                    }
                    this.Close();
                    
                }
        }
    }
}
