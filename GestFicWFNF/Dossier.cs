using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesFic
{
    class Dossier
    {

        //Attribus
        int id_d;
        string nomRep;
        DateTime Creation;
        Double taille;
        int parent;

        //end

        //constructeurs
        public Dossier()
        {

        }
        public Dossier(int i,string nom, int p)
        {
            id_d = i;
            nomRep = nom;
            taille = 0;
            parent = p;
            Creation = DateTime.Now;
        }

        public Dossier(string nom, int p, DateTime d,Boolean pers)
        {
            if (!pers)
            {
                new AccesDonneesDossier().create(new Dossier { NomRep=nom, Parent=p,DateCreation=d,Taille=0});
                nomRep = nom;
                taille = 0;
                parent = p;
                Creation = DateTime.Now;
            }
            else
                new AccesDonneesDossier().create(new Dossier { NomRep = nom, Parent = p, DateCreation = DateTime.Now, Taille = 0 });
        }


        //end

        //getters and setters
        public int Id_d
        {
            get
            {
                return id_d;
            }

            set
            {
                id_d = value;
            }
        }
        public string NomRep
        {
            get
            {
                return nomRep;
            }

            set
            {
                nomRep = value;
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

        public double Taille
        {
            get
            {
                return taille;
            }

            set
            {
                taille = value;
            }
        }

        public int Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        //end



        //methodes
        //list will become after select nomRep from Dossier;
        public Boolean existe(List<Dossier> tt,String rep)
        { 
            foreach(Dossier t in tt)
            {
                if (t.nomRep==rep && t.parent==this.id_d)
                {
                    return true;
                }
            }
            return false;
        } 

        public Boolean existe(List<Fichier> tt, String fic)
        {
            foreach (Fichier t in tt)
            {
                if (t.Parent == this.id_d && t.NomFic+"."+t.Extension == fic)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Dossier> getAll()
        {
            return new AccesDonneesDossier().getAll(); ;
        }

        public List<Dossier> getSubDos()
        {
            List<Dossier> temp=new List<Dossier>();
            foreach(Dossier t in new AccesDonneesDossier().getAll())
            {
                if (this.id_d == t.parent)
                {
                    temp.Add(t);
                }
            }
            return temp.Count > 0 ? temp : null;
        }

        public List<Fichier> getSubFic()
        {
            List<Fichier> temp = new List<Fichier>();
            foreach (Fichier t in new AccesDonneesFichier().getAll())
            {
                if (this.id_d == t.Parent)
                {
                    temp.Add(t);
                }
            }
            return temp.Count>0 ? temp : null;
        }

        public Dossier getDos(List<Dossier> ttd,String rep)
        {

            foreach (Dossier t in ttd)
            {
                if (t.parent == this.id_d && t.nomRep == rep)
                {
                    return t;
                }
            }
            return null;
        }

        public Dossier find(int i)
        {
            return (new AccesDonneesDossier()).find(i);
        }

        public Dossier update()
        {
            return new AccesDonneesDossier().update(this);
        }

        public Dossier getDosById(List<Dossier> ttd, int id)
        {

            foreach (Dossier t in ttd)
            {
                if (t.id_d == id)
                {
                    return t;
                }

            }
            return null;
        }

        public Fichier getFic(List<Fichier> ttf, String fic)
        {
            foreach (Fichier t in ttf)
            {
                if (t.NomFic == fic && t.Parent == this.id_d)
                {
                    return t;
                }
            }
            return null;
        }

        public Fichier getFicById(List<Fichier> ttf, int fic)
        {
            foreach (Fichier t in ttf)
            {
                if (t.Id_f == fic && t.Parent == this.parent)
                {
                    return t;
                }
            }
            return null;
        }

        /// <summary>
        /// return the path of a folder
        /// </summary>
        /// <param name="tt">la liste des dossiers</param>
        /// <returns>path</returns>
        public String getRoot(List<Dossier> tt)
        {
            Dossier temp= this.getDosById(tt, this.parent);
            String path = this.nomRep;
            if (temp != null)
            {
                while (temp != null)
                {
                    path = path.Insert(0,temp.nomRep+ @"\");
                    temp = temp.getDosById(tt, temp.parent);
                }
            }
            return path;
        }

        public String detail()
        {
            return $"\nNom : {NomRep} \tDate de creation : {DateCreation} \tTaille : {taille}";
        }


        public Boolean supp(List<Dossier> tt, String nom)
        {
            if (this.getDos(tt, nom) != null)
            {
                new AccesDonneesDossier().delete(this.getDos(tt, nom));
                tt.Remove(this.getDos(tt, nom));
                return true;
            }
            else
                return false;
        }

        public Boolean supp(List<Fichier> tt, String nom)
        {
            if (this.getFic(tt, nom) != null)
            {
                new AccesDonneesFichier().delete(this.getFic(tt, nom));
                tt.Remove(this.getFic(tt, nom));
                return true;
            }
            else
                return false;
        }

        public void copieFolderTo(Dossier folder, Dossier parent)
        {
            Dossier folder2 = new Dossier(folder.NomRep, parent.id_d,DateTime.Now,true);
            if (folder.getSubDos() != null)
            {
                foreach (Dossier sons in folder.getSubDos())
                {
                    copieFolderTo(sons, folder2);
                }
            }
            else
            {
                new Dossier(folder.NomRep, folder2.getDos(folder2.getAll(),parent.nomRep).Id_d, DateTime.Now, true);
            }
            if (folder.getSubFic() != null)
            {
                foreach (Fichier f in folder.getSubFic())
                {
                    copieFileTo(f, folder2);
                }
            }
        }

        public void copieFileTo(Fichier file, Dossier parent)
        {
            new Fichier(file.NomFic,file.Extension,parent.id_d, DateTime.Now,true);
        }

        //end

    }
}
