using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19Project
{
    class Persistance
    {
        private string serveur = "127.0.0.1";
        private string user = "root";
        private string pass = "";
        private string db = "covid19";
        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataAdapter sda;
        //Constructeur
        public Persistance()
        {
            initConnection();
            cmd = new MySqlCommand();
            sda = new MySqlDataAdapter();
            cmd.Connection = cnx;
        }
        //Connection au serveur
        public void initConnection()
        {
            string StringConn = "server=" + serveur + ";database=" + db + ";uid=" + user + ";pwd=" + pass + ";";
            cnx = new MySqlConnection(StringConn);
            try
            {
                cnx.Open();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Suspect
        public void insertSuspect(string cin)
        {
            try
            {
                cnx.Open();
                cmd.CommandText = "INSERT INTO suspect(cinsuspect) VALUES ('" + cin + "');";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le citoyen a été ajouté à la liste des suspects");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void deleteSuspect(string cin)
        {
            try
            {
                cnx.Open();
                cmd.CommandText = "Delete From Suspect where cinsuspect = '" + cin + "';";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le suspect sera supprimé de la liste des suspects .");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Patient
        public void insertPatient(string cin ,string dateTest)
        {
            try
            {
                cnx.Open();
                cmd.CommandText = "Insert into patient(cinpatient,enquarantine) values('" + cin + "',false);" +//Ajouter au liste des patients
                "Insert into historiquemaladie(cinPatient,dateMaladie) values('" + cin + "','" + dateTest + "');";
                cmd.ExecuteNonQuery();
                
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void deletePatient(string cin)
        {
            try
            {
                cnx.Open();
                cmd.CommandText = "delete from patient where cinpatient='" + cin + "';";//supprimer au liste des patients
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Vacciné
        public void insertVaccine(string cin, string nomVaccin, string dateVaccination)
        {
            try
            {
                cnx.Open();
                cmd.CommandText = "INSERT INTO vaccine(cinVaccine,nomVaccin,dateVaccination) " +
                        "Values('" + cin + "', '" + nomVaccin + "', '" + dateVaccination + "');" +//Insert into liste du vaccinés
                        "Update carnetSanitaire set  faitvaccin = true,datevaccination ='" + dateVaccination + "' WHERE cincitoyen='" + cin + "';";//Ajouter la vaccination au carnet sanitaire
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Le citoyen a été ajouté à la liste des vacciné");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //Tests
        public void insertTest(string cin, string nomTest, string dateTest, string resultat)
        {
            try
            {
                cnx.Open();
                cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '" + nomTest + "', '" + dateTest + "', " + resultat + ");";//Inserer le test
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Rétablies
        public void insertRetablie(string cin, string dateRecuperation)
        {
            try
            {
                cnx.Open();
                cmd.CommandText = "Insert into retablie(cinretablie,dateretablie) values('" + cin + "','" + dateRecuperation + "');";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le patient sera ajouté au liste des Rétablies.");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Degré de gravité
        public void changeGravite(string cin,string etat)
        { 
            try
            {
                cnx.Open();
                cmd.CommandText = "update citoyen set gravite = '" + etat + "' Where cincitoyen = '" + cin + "'";
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Mettre Patient en Quarantine
        public void Mettre_Quarantine(string cin)
        {
            try
            {
                cnx.Open();
                cmd.CommandText = "update patient set enquarantine = true Where cinpatient = '" + cin + "';";
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //
        public void fillDataGrid(DataGridView d, string nameTable)
        {
            if(cnx.State == ConnectionState.Closed)
                cnx.Open();
            if (d.Name == "citoyenDataGrid")
            {
                string cmdString = "select * from " + nameTable;
                cmd = new MySqlCommand(cmdString, cnx);
                sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                d.DataSource = dt;
                for (int i = 0; i < d.Rows.Count; i++)
                {
                    if (d.Rows[i].Cells[7].Value?.ToString() == "Faible")
                    {
                        d.Rows[i].Cells[7].Style.BackColor = Color.Green;
                    }
                    else if (d.Rows[i].Cells[7].Value?.ToString() == "Moyen")
                    {
                        d.Rows[i].Cells[7].Style.BackColor = Color.Orange;
                    }
                    else if (d.Rows[i].Cells[7].Value?.ToString() == "Haute")
                    {
                        d.Rows[i].Cells[7].Style.BackColor = Color.Red;
                    }

                }
            }
            else
            {
                string cmdString = "select * from " + nameTable + ",citoyen WHERE citoyen.cinCitoyen=" + nameTable + ".cin" + nameTable;
                cmd = new MySqlCommand(cmdString, cnx);
                sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dt.Columns.Remove("cinCitoyen");
                d.DataSource = dt;
            }
            cnx.Close();
        }
        //Methode de Vaccination :


        //Afficher le carnet sanitaire :

    }
}
