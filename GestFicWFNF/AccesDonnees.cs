using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GesFic
{
    abstract class AccesDonnees<T>
    {
        public abstract T find(int id);
        public abstract List<T> getAll();
        public abstract void create(T obj);
        public abstract T update(T obj);
        public abstract void delete(T obj);
    }
}
