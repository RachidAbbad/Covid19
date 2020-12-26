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
    public partial class faireTest : Form
    {
        string cin;
        DateTime dateTest;
        string typeTest;
        private MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataAdapter sda;
        private string Etat;
        public faireTest(string _cin, MySqlConnection _cnn,string _etat)
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
                if(Etat == "suspect")
                {
                    if(resultatTestCombobox.Text == "Negative")
                    {
                        cnn.Open();
                        cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '"+typeTestCombobox.Text+ "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', FALSE);" +
                            "Delete From Suspect where cinsuspect = '" + cin + "';";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Le test a été ajouté avec succès \n Le suspect n'est pas porteur du virus, il sera supprimé de la liste des suspects .");
                    
                    }
                    else if(resultatTestCombobox.Text == "Positive")
                    {
                        cnn.Open();
                        cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '" + typeTestCombobox.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', TRUE);" +
                            "Insert into patient(cinpatient) values('" + cin + "');" +
                            "Delete From Suspect where cinsuspect = '" + cin + "';";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Le test a été ajouté avec succès \n Le suspect est passé à la liste des patients .");
                        cnn.Close();
                    }
                    this.Close();
                }else if(Etat == "patient")
                {
                    if (resultatTestCombobox.Text == "Negative")
                    {
                        cnn.Open();
                        cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '" + typeTestCombobox.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', FALSE);" +
                            "Delete From patient where cinpatient = '" + cin + "';" +
                            "Insert into retablie(cinretablie,dateretablie) values('"+cin+"','"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") + "');";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Le test a été ajouté avec succès \n Le patient n'est pas porteur du virus, il sera ajouté au liste des Rétablie.");

                    }
                    else if (resultatTestCombobox.Text == "Positive")
                    {
                        cnn.Open();
                        cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '" + typeTestCombobox.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', TRUE);";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Le test a été ajouté avec succès \n Le patient est toujours porteur du virus.");
                        cnn.Close();
                    }
                    this.Close();
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

