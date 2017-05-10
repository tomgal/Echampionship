using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChampionshipMVVM.Class
{
    public class Jeux
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private String _nom;

        public String Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        private String _urlImage;

        public String UrlImage
        {
            get
            {
                return _urlImage;
            }
            set
            {
                _urlImage = value;
            }
        }

        private String _level;

        public String Level
        {
            get { return _level; }
            set { _level = value; }
        }


        public Jeux(String _name, String _url)
        {
            Nom = _name;
            UrlImage = _url;
        }

    }
}
