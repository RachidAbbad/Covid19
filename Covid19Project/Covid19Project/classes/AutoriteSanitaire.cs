/***********************************************************************
 * Module:  AutoriteSanitaire.cs
 * Author:  BIG CHOIX
 * Purpose: Definition of the Class AutoriteSanitaire
 ***********************************************************************/

using System;

public class AutoriteSanitaire
{
    //Attributs
    private int NbCadreMedicaux;
    private int NbMedicament;
    private int NbVaccin;

    //Getters
    public int getNbCadreMedicaux()
    {
        return NbCadreMedicaux;
    }
    public int getNbMedicament()
    {
        return NbMedicament;
    }
    public int getNbVaccin()
    {
        return NbVaccin;
    }

    //setters
    public void setNbCadreMedicaux(int _NbCadreMedicaux)
    {
        NbCadreMedicaux = _NbCadreMedicaux;
    }
    public void setNbMedicament(int _NbMedicament)
    {
        NbMedicament = _NbMedicament;
    }
    public void setNbVaccin(int _NbVaccin)
    {
        NbVaccin = _NbVaccin;
    }

    //Methods
    public Vaccin ImporteVaccin(int _nbVaccin, string _pays, string _nomVaccin, string _periodeVie, string _autreInfos)
    {
<<<<<<< Updated upstream
        Vaccin vaccin = new Vaccin(_nomVaccin, _pays, _periodeVie, _desicription);
=======
        Vaccin vaccin = new Vaccin(_nomVaccin, _pays, _periodeVie, _autreInfos);
>>>>>>> Stashed changes
        NbVaccin = _nbVaccin;
        return vaccin;
    }
    public Vaccin ImporteVaccin(int _nbVaccin, string _pays, string _nomVaccin, string _periodeVie)
   {
        Vaccin vaccin = new Vaccin(_nomVaccin,_pays,_periodeVie);
        NbVaccin = _nbVaccin;
        return vaccin;
   }



}