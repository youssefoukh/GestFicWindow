using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GesFic
{
    class AccesDonneesUser : AccesDonnees<Utilisateur>
    {
        public override void create(Utilisateur obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                List<Utilisateur> tt = new List<Utilisateur>();
                tt.Add(new Utilisateur {Nom = obj.Nom, Mdp= obj.Mdp,Statut=obj.Statut});
                connection.Execute("dbo.user_insert @Nom,@Mdp,@Statut", tt);
            }
        }

        public override void delete(Utilisateur obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                connection.Execute("dbo.user_delete @Id", new { Id = obj.Id_u });
            }
        }

        public override Utilisateur find(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                Utilisateur p = connection.Query<Utilisateur>("EXEC dbo.user_getId @Id", new { Id = id }).FirstOrDefault();
                return p;
            }
        }

        public override List<Utilisateur> getAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                var ou = connection.Query<Utilisateur>("SELECT * from utilisateur").ToList();
                return ou;
            }
        }

        public override Utilisateur update(Utilisateur obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                connection.Execute("EXEC dbo.user_update @Id_u,@username,@mdp,@statut", obj);
                return this.find(obj.Id_u);
            }
        }
    }
}
