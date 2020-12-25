using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Project.classes
{
    class Suspect:Citoyen
    {
        public Suspect(string _Nom, string _Prenom, int _Age, string _Sexe, string _Cin, string _Adresse, string _NumTel):base( _Nom, _Prenom, _Age, _Sexe, _Cin, _Adresse, _NumTel){}
    }
}
