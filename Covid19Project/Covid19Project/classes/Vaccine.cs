using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Project.classes
{
    class Vaccine:Citoyen
    {
        private DateTime dateVaccination;
        public Vaccine(string _Nom, string _Prenom, int _Age, string _Sexe, string _Cin, string _Adresse, string _NumTel) : base(_Nom, _Prenom, _Age, _Sexe, _Cin, _Adresse, _NumTel){}
        public Vaccine(string _Nom, string _Prenom, int _Age, string _Sexe, string _Cin, string _Adresse, string _NumTel, DateTime _dateVaccination) : base(_Nom, _Prenom, _Age, _Sexe, _Cin, _Adresse, _NumTel)
        {
            dateVaccination = _dateVaccination;
        }
        public void setDateVaccination(DateTime _date)
        {
            dateVaccination = _date;
        }
        public DateTime getDateVaccination()
        {
            return dateVaccination;
        }
    }
}
