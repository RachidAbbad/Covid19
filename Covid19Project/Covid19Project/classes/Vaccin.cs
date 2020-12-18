/***********************************************************************
 * Module:  Vaccin.cs
 * Author:  BIG CHOIX
 * Purpose: Definition of the Class Vaccin
 ***********************************************************************/

using System;

public class Vaccin
{
    //Attributs
   private string Nom;
   private string PaysFabrication;
   private string PeriodeVie;
   private string AutreInfos;

    //Constructeurs
    public Vaccin(string _Nom,string _PaysFabrication, string _PeriodeVie,string _AutreInfos)
    {
        Nom = _Nom;
        PaysFabrication = _PaysFabrication;
        PeriodeVie = _PeriodeVie;
        AutreInfos = _AutreInfos;
    }
    public Vaccin(string _Nom, string _PaysFabrication, string _PeriodeVie)
    {
        Nom = _Nom;
        PaysFabrication = _PaysFabrication;
        PeriodeVie = _PeriodeVie;
    }

    //Getters
    public string getNom()
    {
        return Nom;
    }
    public string getPaysFabrication()
    {
        return PaysFabrication;
    }
    public string getPeriodeVie()
    {
        return PeriodeVie;
    }
    public string getAutreInfos()
    {
        return AutreInfos;
    }

    //Setters
    public void setNom(string _Nom)
    {
        Nom = _Nom;
    }
    public void setPaysFabrication(string _PaysFabrication)
    {
        PaysFabrication = _PaysFabrication;
    }
    public void setPeriodeVie(string _PeriodeVie)
    {
        PeriodeVie = _PeriodeVie;
    }
    public void setAutreInfos(string _AutreInfos)
    {
        AutreInfos = _AutreInfos;
    }

    //Methods
}