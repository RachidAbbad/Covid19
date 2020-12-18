/***********************************************************************
 * Module:  Test.cs
 * Author:  BIG CHOIX
 * Purpose: Definition of the Class Test
 ***********************************************************************/

using System;

public class Test
{
    private string Nom;
    private bool Resultat;
    private DateTime Date;

    //constructeurs
    public Test(string _Nom, bool _Resultat, DateTime _Date)
    {
        Nom = _Nom;
        Resultat = _Resultat;
        Date = _Date;
    }

    //Getters
    public string getNom()
    {
        return Nom;
    }
    public bool getResultat()
    {
        return Resultat;
    }
    public DateTime getDate()
    {
        return Date;
    }

    //Setters
    public void setNom(string _Nom)
    {
        Nom = _Nom;
    }
    public void setResultat(bool _Resultat)
    {
        Resultat = _Resultat;
    }
    public void setPeriodeVie(DateTime _Date)
    {
        Date = _Date;
    }
}