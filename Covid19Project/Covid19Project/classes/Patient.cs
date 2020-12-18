/***********************************************************************
 * Module:  Patient.cs
 * Author:  BIG CHOIX
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class Patient : Citoyen
{
    
    private Symptomes symptomes;

    //Constructeur
    public Patient(string _Nom, string _Prenom, int _Age, string _Sexe, string _Cin, string _Adresse, string _NumTel) : base(_Nom, _Prenom, _Age, _Sexe, _Cin, _Adresse, _NumTel)
    {

    }

    public void MettreQuarantine()
    {
        
    }



}