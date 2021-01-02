using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesFic
{
    class Privilege
    {
        //attribut
        private int id_pri;
        private int id_en;
        private int id_u;
        private bool read;
        private bool write;
        private bool execute;
        //end

        public Privilege()
        {
        }

        public Privilege(int i, int ie, int iu,bool r = true,bool w = true, bool x = true)
        {
            id_pri = i;
            id_en = ie;
            id_u = iu;
            read = r;
            write = w;
            execute = x;
        }

        public Privilege(int i, int ie, int iu, Boolean pers, Boolean isRep, bool r = true, bool w = true, bool x = true)
        {
            if (!pers && isRep)
            {
                id_pri = i;
                id_en = ie;
                id_u = iu;
                read = r;
                write = w;
                execute = x;
                new AccesDonneesPD().create(new Privilege { Id_en = ie, Id_u = iu, Read = r, Write = w, Execute = x });
            }else if(!pers && !isRep)
            {
                id_pri = i;
                id_en = ie;
                id_u = iu;
                read = r;
                write = w;
                execute = x;
                new AccesDonneesPF().create(new Privilege { Id_en = ie, Id_u = iu, Read = r, Write = w, Execute = x });
            }else if(pers && isRep)
            {
                new AccesDonneesPD().create(new Privilege { Id_en = ie, Id_u = iu, Read = r, Write = w, Execute = x });
            }
            else if (pers && !isRep)
            {
                new AccesDonneesPF().create(new Privilege { Id_en = ie, Id_u = iu, Read = r, Write = w, Execute = x });
            }



        }

        //getters and setters
        public int Id_pri
        {
            get
            {
                return id_pri;
            }

            set
            {
                id_pri = value;
            }
        }

        public int Id_en
        {
            get
            {
                return id_en;
            }

            set
            {
                id_en = value;
            }
        }

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

        public bool Read
        {
            get
            {
                return read;
            }

            set
            {
                read = value;
            }
        }

        public bool Write
        {
            get
            {
                return write;
            }

            set
            {
                write = value;
            }
        }

        public bool Execute
        {
            get
            {
                return execute;
            }

            set
            {
                execute = value;
            }
        }

        //end
        public List<Privilege> getAllDossier()
        {
            return new AccesDonneesPD().getAll();
        }

        public List<Privilege> getAllFichier()
        {
            return new AccesDonneesPF().getAll();
        }

        public Privilege findFichier(int i)
        {
            return new AccesDonneesPF().find(i);
        }

        public Privilege findDossier(int i)
        {
            return new AccesDonneesPF().find(i);
        }

        public static Privilege getpri(List<Privilege> tt,int i_d)
        {
            foreach (Privilege t in tt)
            {
                if (t.id_en==i_d)
                {
                    return t;
                }
            }
            return null;
        }

        public void chmod(int mod)
        {
            if (mod == 7)
                this.ModifierPrivilige(true, true, true);
            else if (mod == 6)
                this.ModifierPrivilige(true, true, false);
            else if (mod==4)
                this.ModifierPrivilige(true, false, false);
            else if (mod == 5)
                this.ModifierPrivilige(true, false, true);
            else if (mod == 1)
                this.ModifierPrivilige(false, false, true);
            else if (mod == 0)
                this.ModifierPrivilige(false, false, false);
        }

        public void ModifierPrivilige(bool r, bool w, bool x)
        {
            read = r;
            write = w;
            execute = x;
            new AccesDonneesPD().update(this);
            new AccesDonneesPF().update(this);
        }

        public Boolean testWrite(int i_user)
        {
            if (this.write || this.id_u == i_user)
                return true;
            return false;
        }
        public Boolean testRead(int i_user)
        {
            if (this.read || this.id_u == i_user)
                return true;
            return false;
        }
        public Boolean testExecute(int i_user)
        {
            if (this.execute || this.id_u == i_user)
                return true;
            return false;
        }
    }
}
