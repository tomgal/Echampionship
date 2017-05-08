using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChampionshipMVVM.Class
{
    public class Pari
    {
        private String nomEquipe1;

        public String NomEquipe1
        {
            get { return nomEquipe1; }
            set { nomEquipe1 = value; }
        }

        private String nomEquipe2;

        public String NomEquipe2
        {
            get { return nomEquipe2; }
            set { nomEquipe2 = value; }
        }

        private double _coteEquipe1;

        public double CoteEquipe1
        {
            get { return _coteEquipe1; }
            set { _coteEquipe1 = value; }
        }

        private double _coteEquipe2;

        public double CoteEquipe2
        {
            get { return _coteEquipe2; }
            set { _coteEquipe2 = value; }
        }

        private String _nomJeux;

        public String NomJeux
        {
            get { return _nomJeux; }
            set { _nomJeux = value; }
        }

        private String _urlJeux;

        public String UrlJeux
        {
            get { return _urlJeux; }
            set { _urlJeux = value; }
        }

        private String _urlLogoEq1;

        public String UrlLogoEq1
        {
            get { return _urlLogoEq1; }
            set { _urlLogoEq1 = value; }
        }

        private String _urlLogoEq2;

        public String UrlLogoEq2
        {
            get { return _urlLogoEq2; }
            set { _urlLogoEq2 = value; }
        }






    }
}
