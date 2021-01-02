using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesFic
{
    class Fichier
    {
        //Attribus
        private int id_f;
        private String nomFic;
        private DateTime Creation;
        private String extension;
        private Double taille;
        private int parent;
        //Constructors
        public Fichier()
        {
        }

        public Fichier(int i,String nom,String ext,int p)
        {
            id_f = i;
            nomFic = nom;
            Creation = DateTime.Now;
            extension = ext;
            taille = 0;
            parent = p;
        }

        public Fichier(String nom, String ext, int p, DateTime d,Boolean pers)
        {
            if (!pers)
            {
                new AccesDonneesFichier().create(new Fichier { NomFic = nom, DateCreation = DateTime.Now, Parent = p, Taille = 0, Extension = ext });
                nomFic = nom;
                Creation = DateTime.Now;
                extension = ext;
                taille = 0;
                parent = p;
            }
            else
                new AccesDonneesFichier().create(new Fichier { NomFic = nom, DateCreation = DateTime.Now, Parent = p, Taille = 0, Extension = ext });
        }
        //end

        //getters and setters
        public string NomFic
        {
            get
            {
                return nomFic;
            }

            set
            {
                nomFic = value;
            }
        }

        public DateTime DateCreation
        {
            get
            {
                return Creation;
            }

            set
            {
                Creation = value;
            }
        }

        public string Extension
        {
            get
            {
                return extension;
            }

            set
            {
                extension = value;            }
        }

        public double Taille
        {
            get
            {
                return taille;
            }

            set
            {
                taille = value;            }
        }

        internal int Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;            }
        }

        public int Id_f
        {
            get
            {
                return id_f;
            }

            set
            {
                id_f = value;
            }
        }

        //end

        //methodes
        public List<Fichier> getAll()
        {
            return new AccesDonneesFichier().getAll();
        }

        public Fichier find(int i)
        {
            return new AccesDonneesFichier().find(i);
        }

        public Fichier update()
        {
            return new AccesDonneesFichier().update(this);
        }

        public Boolean Executer()
        {
            return false;
        }

        public Boolean Copier(Dossier dest)
        {
            return false;
        }

        public String detail()
        {
            return $"Nom : {NomFic} \tType : {extension} \tDate de creation : {DateCreation} \tTaille : {taille}";
        }

        //end
    }
}
