using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GesFic
{
    class AccesDonneesPF : AccesDonnees<Privilege>
    {
        public override void create(Privilege obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                List<Privilege> tt = new List<Privilege>();
                tt.Add(new Privilege { Id_pri = obj.Id_pri, Id_en = obj.Id_en, Id_u = obj.Id_u, Read = obj.Read, Write = obj.Write, Execute = obj.Execute });
                connection.Execute("dbo.privilegef_insert @Id_en,@Id_u,@Read,@Write,@Execute", tt);
            }
        }

        public override void delete(Privilege obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                connection.Execute("dbo.privilegef_delete @Id", new { Id = obj.Id_pri });
            }
        }

        public override Privilege find(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                Privilege p = connection.Query<Privilege>("EXEC dbo.pfichier_getId @Id", new { Id = id }).FirstOrDefault();
                return p;
            }
        }

        public override List<Privilege> getAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                var ou = connection.Query<Privilege>("SELECT * from pfichier").ToList();
                return ou;
            }
        }

        public override Privilege update(Privilege obj)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnStr("GESFIC")))
            {
                connection.Execute("EXEC dbo.pfichier_update @Id_d,@NomRep,@DateCreation,@Taille,@Parent", obj);
                return this.find(obj.Id_pri);
            }
        }
    }
}
