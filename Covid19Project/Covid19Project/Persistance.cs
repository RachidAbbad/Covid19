using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        private MySqlConnection cnn;
        private MySqlCommand cmd;
        //Constructeur
        public Persistance(MySqlCommand _cmd)
        {
            initConnection();
        }
        //Connection au serveur
        public void initConnection()
        {
            string StringConn = "server=" + serveur + ";database=" + db + ";uid=" + user + ";pwd=" + pass + ";";
            cnn = new MySqlConnection(StringConn);
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
        //Suspect
        public void insertSuspect(string cin)
        {
            try
            {
                cmd.CommandText = "INSERT INTO suspect(cinsuspect) VALUES ('" + cin + "');";
                cmd.ExecuteNonQuery();
                changeGravite(cin, "Moyen");
                MessageBox.Show("Le citoyen a été ajouté à la liste des suspects");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void deleteSuspect(string cin)
        {
            try
            {
                cmd.CommandText = "Delete From Suspect where cinsuspect = '" + cin + "';";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le suspect sera supprimé de la liste des suspects .");
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
                cmd.CommandText = "Insert into patient(cinpatient,enquarantine) values('" + cin + "',false);" +//Ajouter au liste des patients
                "Insert into historiquemaladie(cinPatient,dateMaladie) values('" + cin + "','" + dateTest + "');";
                cmd.ExecuteNonQuery();
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
                cmd.CommandText = "INSERT INTO vaccine(cinVaccine,nomVaccin,dateVaccination) " +
                        "Values('" + cin + "', '" + nomVaccin + "', '" + dateVaccination + "');" +//Insert into liste du vaccinés
                        "Update carnetSanitaire set  faitvaccin = true,datevaccination ='" + dateVaccination + "' WHERE cincitoyen='" + cin + "';" +//Ajouter la vaccination au carnet sanitaire
                cmd.ExecuteNonQuery();
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
                cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '" + nomTest + "', '" + dateTest + "', " + resultat + ");";//Inserer le test
                cmd.ExecuteNonQuery();
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
                cmd.CommandText = "Delete From patient where cinpatient = '" + cin + "';" +
                            "Insert into retablie(cinretablie,dateretablie) values('" + cin + "','" + dateRecuperation + "');";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le patient n'est pas porteur du virus, il sera ajouté au liste des Rétablie.");
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
                cmd.CommandText = "update citoyen set gravite = '" + etat + "' Where cincitoyen = '" + cin + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
