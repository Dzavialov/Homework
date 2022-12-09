using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    internal interface IRepository<TEntity>
    {
        IList<TEntity> GetAll();
        TEntity Get(int id);
        void Insert(TEntity entity);

    }
}
