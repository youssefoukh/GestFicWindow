using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
namespace GesFic
{
    class AccesDonneesDossier : AccesDonnees<Dossier>
    {

        public override List<Dossier> getAll()
        {
            using (IDbConnection connection=new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                    var ou = connection.Query<Dossier>("SELECT * from dossier").ToList();
                    return ou;
            }
        }

        public override void create(Dossier obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                List<Dossier> tt =new List<Dossier>();
                tt.Add(new Dossier { NomRep = obj.NomRep, DateCreation = obj.DateCreation,Parent = obj.Parent, Taille = obj.Taille });
                connection.Execute("dbo.dossier_insert @NomRep,@DateCreation,@Taille,@Parent", tt);
            }
        }

        public override void delete(Dossier obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                connection.Execute("dbo.dossier_delete @Id", new { Id = obj.Id_d });
            }
        }

        public override Dossier find(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                Dossier p= connection.QueryFirstOrDefault<Dossier>("EXEC dbo.dossier_getId @Id", new { Id = id });
                return p;
            }
        }

        public override Dossier update(Dossier obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                connection.Execute("EXEC dbo.dossier_update @Id_d,@NomRep,@DateCreation,@Taille,@Parent", obj);
                return this.find(obj.Id_d);
            }
        }
    }
}
