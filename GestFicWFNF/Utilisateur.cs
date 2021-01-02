using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesFic
{
    class Utilisateur
    {
        //attribut
        int id_u;
        String nom;
        String mdp;
        Boolean statut;
        //end

        public Utilisateur()
        {
        }

        public Utilisateur(int i,String n, String m)
        {
            id_u = i;
            nom = n;
            mdp = m;
            statut = true;
                     
        }

        public Utilisateur(String n, String m,Boolean pers)
        {
            if (!pers)
            {
                new AccesDonneesUser().create(new Utilisateur { Nom = n, Mdp = m, Statut = false });
                nom = n;
                mdp = m;
                statut = true;
            }
            else
                new AccesDonneesUser().create(new Utilisateur { Nom = n, Mdp = m, Statut = false });
        }

        //getters and setters
        public int Id_u
        {
            get
            {
                return id_u;
            }

            set
            {
                id_u = value;

            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;

            }
        }

        public string Mdp
        {
            get
            {
                return mdp;
            }

            set
            {
                mdp = value;

            }
        }

        public bool Statut
        {
            get
            {
                return statut;
            }

            set
            {
                statut = value;

            }
        }

        //end

        //methodes
         public List<Utilisateur> getAll()
        {
            return new AccesDonneesUser().getAll();
        }

        public Utilisateur find(int i)
        {
            return new AccesDonneesUser().find(i);
        }

        public static Boolean login(List<Utilisateur> uu,String u,String mdp)
        {
            foreach(Utilisateur us in uu)
            {
                if (u == us.Nom && mdp == us.mdp)
                    return true;
            }
                return false;
        }

        public static Utilisateur islog(List<Utilisateur> tt)
        {
            foreach (Utilisateur t in tt)
            {
                if (t.Statut)
                {
                    return t;
                }
            }
            return null;
        }

        public static Utilisateur getUser( List<Utilisateur> tt, String t)
        {
            foreach (Utilisateur to in tt)
            {
                if (to.Nom == t)
                {
                    return to;
                }
            }
            return null;
        }
        //ends
    }
}
