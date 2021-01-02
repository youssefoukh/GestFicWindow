using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GesFic
{
    class AccesDonneesFichier : AccesDonnees<Fichier>
    {
        public override void create(Fichier obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                connection.Execute("dbo.fichier_insert @NomFic,@DateCreation,@Taille,@extension,@Parent", new { NomFic = obj.NomFic, DateCreation = obj.DateCreation, Parent = obj.Parent, Taille = obj.Taille, Extension = obj.Extension });
            }
        }

        public override void delete(Fichier obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                connection.Execute("dbo.fichier_delete @Id", new { Id = obj.Id_f });
            }
        }

        public override Fichier find(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                Fichier p = connection.Query<Fichier>("EXEC dbo.fichier_getId @Id", new { Id = id }).FirstOrDefault();
                return p;
            }
        }

        public override List<Fichier> getAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                return connection.Query<Fichier>("SELECT ID_F,NomFic,Creation,taille,extension,parent from fichier").ToList();
            }
        }

        public override Fichier update(Fichier obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                connection.Execute("EXEC dbo.fichier_update @Id_f,@NomFic,@DateCreation,@Taille,@extension,@Parent", new { Id_f=obj.Id_f,NomFic = obj.NomFic, DateCreation = obj.DateCreation, Parent = obj.Parent, Taille = obj.Taille, Extension = obj.Extension });
                return this.find(obj.Id_f);
            }
        }
    }
}
