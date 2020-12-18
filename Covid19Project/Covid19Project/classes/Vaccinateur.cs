/***********************************************************************
 * Module:  AutoriteSanitaire.cs
 * Author:  BIG CHOIX
 * Purpose: Definition of the Class AutoriteSanitaire
 ***********************************************************************/

using System;

public class Vaccinateur : Citoyen
{
    private string NumAutorisation;

    //Constructeur
    public Vaccinateur(string _Nom, string _Prenom, int _Age, string _Sexe, string _Cin, string _Adresse, string _NumTel, string _NumAutorisation):base(_Nom,_Prenom,_Age,_Sexe,_Cin,_Adresse,_NumTel)
    {
        NumAutorisation = _NumAutorisation;
    }
    public void Vaccination(Patient patient, CarnetSanitaire carnet)
       {
        carnet.setVaccinFait(true);
        patient.changerEtat("sain");
       }


}