/***********************************************************************
 * Module:  Citoyen.cs
 * Author:  BIG CHOIX
 * Purpose: Definition of the Class Citoyen
 ***********************************************************************/

using System;

public class Citoyen
{
   private string Nom;
   private string Prenom;
   private int Age;
   private string Sexe;
   private string Cin;
   private string Adresse;
   private string NumTel;
    private string Etat;

    //Constructeur
    public Citoyen(string _Nom, string _Prenom, int _Age, string _Sexe, string _Cin, string _Adresse, string _NumTel)
    {
        Nom = _Nom;
        Prenom = _Prenom;
        Age = _Age;
        Sexe = _Sexe;
        Cin = _Cin;
        Adresse = _Adresse;
        NumTel = _NumTel;

    }
    public Citoyen(string _Nom, string _Prenom, int _Age, string _Sexe, string _Cin, string _Adresse, string _NumTel, string _Etat)
    {
        Nom = _Nom;
        Prenom = _Prenom;
        Age = _Age;
        Sexe = _Sexe;
        Cin = _Cin;
        Adresse = _Adresse;
        NumTel = _NumTel;
        Etat = _Etat;
    }
    
    //Getters
    public string getNom()
    {
        return Nom;
    }
    public string getPrenom()
    {
        return Prenom;
    }
    public int getAge()
    {
        return Age;
    }
    public string getSexe()
    {
        return Sexe;
    }
    public string getCin()
    {
        return Cin;
    }
    public string getAdresse()
    {
        return Adresse;
    }
    public string getNumTel()
    {
        return NumTel;
    }
    public string getEtat()
    {
        return Etat;
    }

    //Setters
    public void setNom(string _nom)
    {
        Nom = _nom;
    }
    public void setAge(int _age)
    {
        Age = _age;
    }
    public void setPrenom(string _prenom)
    {
        Prenom = _prenom;
    }
    public void setSexe(string _sexe)
    {
        Sexe = _sexe;
    }
    public void setCin(string _cin)
    {
        Cin = _cin;
    }
    public void setNumTel(string _numtel)
    {
        NumTel = _numtel;
    }
    public void setAdresse(string _adresse)
    {
        Adresse = _adresse;
    }
    public void changerEtat(string _etat)
    {
        Etat = _etat;
    }

}