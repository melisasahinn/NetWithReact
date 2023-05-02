using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Common.Interfaces.Persistence.Common
{
    public interface IRepositoryBase <TEntity> where TEntity : class
    {
        TEntity GetById (long id, bool ShowDeleted = false);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity, bool deletion = false);
        TEntity Delete(long id);
        List<TEntity> Get(int queryPage, int querySize);
        int Count();
    }
}
