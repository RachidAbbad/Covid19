/***********************************************************************
 * Module:  Test.cs
 * Author:  BIG CHOIX
 * Purpose: Definition of the Class Test
 ***********************************************************************/

using System;

public class Laboratoire
{
   private string Nom;
   private string Location;
    public void setNom(string _nom)
    {
        Nom = _nom;
    }
    public void setLocation(string _Location)
    {
        Location = _Location;
    }
    public string getNom()
    {
        return Nom;
    }
    public string getLocation()
    {
        return Location;
    }
}