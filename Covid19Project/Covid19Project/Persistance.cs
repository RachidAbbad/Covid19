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
        private MySqlCommand cmd = new MySqlCommand();
        //Constructeur
        public Persistance(MySqlCommand _cmd)
        {
            cmd = _cmd;
        }
        //Suspect
        public void insertSuspect(string cin)
        {
            cmd.CommandText = "INSERT INTO suspect(cinsuspect) VALUES ('" + cin + "');";
            cmd.ExecuteNonQuery();
            changeGravite(cin, "Moyen");
            MessageBox.Show("Le citoyen a été ajouté à la liste des suspects");
        }
        public void deleteSuspect(string cin)
        {
            cmd.CommandText = "Delete From Suspect where cinsuspect = '" + cin + "';";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Le suspect n'est pas porteur du virus, il sera supprimé de la liste des suspects .");
        }
        //Patient
        public void insertPatient(string cin ,string dateTest)
        {
            cmd.CommandText = "Insert into patient(cinpatient,enquarantine) values('" + cin + "',false);" +//Ajouter au liste des patients
                "Insert into historiquemaladie(cinPatient,dateMaladie) values('"+cin+"','"+dateTest+"');";
            cmd.ExecuteNonQuery();
        }
        //Vacciné
        public void insertVaccine(string cin, string nomVaccin, string dateVaccination)
        {
            cmd.CommandText = "INSERT INTO vaccine(cinVaccine,nomVaccin,dateVaccination) " +
                        "Values('" + cin + "', '" + nomVaccin + "', '" + dateVaccination + "');" +//Insert into liste du vaccinés
                        "Update carnetSanitaire set  faitvaccin = true,datevaccination ='" + dateVaccination + "' WHERE cincitoyen='" + cin + "';" +//Ajouter la vaccination au carnet sanitaire
            cmd.ExecuteNonQuery();
            MessageBox.Show("Le citoyen a été ajouté à la liste des vacciné");
        }
        //Tests
        public void insertTest(string cin, string nomTest, string dateTest, string resultat)
        {
            cmd.CommandText = "INSERT INTO test(cin,nomtest, datetest, resultat) VALUES('" + cin + "', '" + nomTest + "', '" + dateTest + "', " + resultat + ");";//Inserer le test
            cmd.ExecuteNonQuery();
        }
        //Rétablies
        public void insertRetablie(string cin, string dateRecuperation)
        {
            cmd.CommandText = "Delete From patient where cinpatient = '" + cin + "';" +
                            "Insert into retablie(cinretablie,dateretablie) values('" + cin + "','" + dateRecuperation + "');";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Le patient n'est pas porteur du virus, il sera ajouté au liste des Rétablie.");
        }
        //Degré de gravité
        public void changeGravite(string cin,string etat)
        {
            cmd.CommandText = "update citoyen set gravite = '"+etat+"' Where cincitoyen = '" + cin + "'";
            cmd.ExecuteNonQuery();
        }
    }
}
