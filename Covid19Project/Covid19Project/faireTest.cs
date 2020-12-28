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
        string cin;
        DateTime dateTest;
        string typeTest;
        private MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        private string Etat;
        private Suspect suspect;
        private Retablie retablie;
        private Patient patient;
        private Test test;
        public faireTest(Citoyen _citoyen,MySqlConnection _cnn,string _etat)
        {
            InitializeComponent();                                                      
            cin = _citoyen.getCin();
            if(Etat == "suspect")
                suspect = new Suspect(_citoyen.getNom(), _citoyen.getPrenom(), _citoyen.getAge(), _citoyen.getSexe(), _citoyen.getCin(), _citoyen.getAdresse(), _citoyen.getNumTel());
            else if(Etat == "patient")
                patient = new Patient(_citoyen.getNom(), _citoyen.getPrenom(), _citoyen.getAge(), _citoyen.getSexe(), _citoyen.getCin(), _citoyen.getAdresse(), _citoyen.getNumTel());
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
            //name

            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                if(Etat == "suspect")
                {
                    if(resultatTestCombobox.Text == "Negative")
                    {
                        cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '"+typeTestCombobox.Text+ "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', FALSE);" +
                            "Delete From Suspect where cinsuspect = '" + cin + "';" +
                            "update citoyen set gravite = 'Faible' Where cincitoyen = '" + cin + "';";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Le test a été ajouté avec succès \n Le suspect n'est pas porteur du virus, il sera supprimé de la liste des suspects .");
                        test = new Test(typeTestCombobox.Text, false, dateTimePicker1.Value);
                    }
                    else if(resultatTestCombobox.Text == "Positive")
                    {
                        cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '" + typeTestCombobox.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', TRUE);" +
                            "Insert into patient(cinpatient) values('" + cin + "');" +
                            "Delete From Suspect where cinsuspect = '" + cin + "';" +
                            "update citoyen set gravite = 'Haute' Where cincitoyen = '" + cin + "';";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Le test a été ajouté avec succès \n Le suspect est passé à la liste des patients .");
                        test = new Test(typeTestCombobox.Text, true, dateTimePicker1.Value);
                    }
                    this.Close();
                }else if(Etat == "patient")
                {
                    if (resultatTestCombobox.Text == "Negative")
                    {
                        cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '" + typeTestCombobox.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', FALSE);" +
                            "Delete From patient where cinpatient = '" + cin + "';" +
                            "Insert into retablie(cinretablie,dateretablie) values('"+cin+"','"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") + "');" +
                            "update citoyen set gravite = 'Faible' Where cincitoyen = '" + cin + "';";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Le test a été ajouté avec succès \n Le patient n'est pas porteur du virus, il sera ajouté au liste des Rétablie.");
                        test = new Test(typeTestCombobox.Text, false, dateTimePicker1.Value);
                    }
                    else if (resultatTestCombobox.Text == "Positive")
                    {
                        cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '" + typeTestCombobox.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', TRUE);";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Le test a été ajouté avec succès \n Le patient est toujours porteur du virus.");
                        test = new Test(typeTestCombobox.Text, true, dateTimePicker1.Value);
                    }
                    this.Close();
                    cnn.Close();
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
