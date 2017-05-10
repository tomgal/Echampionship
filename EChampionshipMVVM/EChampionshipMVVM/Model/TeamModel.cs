using EChampionshipMVVM.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EChampionshipMVVM.Model
{
    public class TeamModel
    {
        public List<Equipe> getAllEquipes(int idUser)
        {
            List<Equipe> allEquipe = new List<Equipe>();
            Utilisateur user = new Utilisateur(idUser);
            foreach (int a in user.IdEquipes)
            {
                Equipe equipe = new Equipe(a);
                allEquipe.Add(equipe);
            }
            return allEquipe;
        }
    }
}
