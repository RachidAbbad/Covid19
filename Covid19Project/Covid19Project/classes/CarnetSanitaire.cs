/***********************************************************************
 * Module:  CarnetSanitaire.cs
 * Author:  BIG CHOIX
 * Purpose: Definition of the Class CarnetSanitaire
 ***********************************************************************/

using System;

public class CarnetSanitaire
{
    private string cin;
   private bool VaccinFait;
   private DateTime DateVaccination;

    //Constructeur 
    public CarnetSanitaire(string _cin)
    {
        cin = _cin;
        VaccinFait = false;
    }

    //Setters
    public void setVaccinFait(bool _VaccinFait)
    {
        VaccinFait = _VaccinFait;
    }
    public void setDateVaccination(DateTime _DateVaccination)
    {
        DateVaccination = _DateVaccination;
    }

    //Getters
    public bool getVaccinFait()
    {
        return VaccinFait;
    }
    public DateTime getDateVaccination()
    {
        return DateVaccination;
    }


}