using Microsoft.EntityFrameworkCore;
using NetWithReact.Application.Common.Interfaces.Persistence.Common;
using NetWithReact.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Infrastructure.Persistence.Common
{
    public class EFRepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        public NetWithReactDbContext _dbContext;
        public EFRepositoryBase(NetWithReactDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        protected DbSet<TEntity> _dbSet;

        public TEntity Add(TEntity entity)
        {
            if(_dbSet.Add(entity) is { } EntityEntry)
            {
                _dbContext.SaveChanges();
                return EntityEntry.Entity;
            }
            return null;
        }

        public int Count()
        {
            return _dbSet.Count();
        }

        public TEntity Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Get(int queryPage, int querySize)
        {
            return _dbSet.Skip((queryPage - 1) * querySize).Take(querySize).ToList();
        }

        public TEntity GetById(long Id, bool ShowDeleted = false)
        {
            if (Id != null)
            {
                if (ShowDeleted == false)
                {
                    return _dbContext.Set<TEntity>().Where(x => x.Id == Id && x.IsDeleted == false).FirstOrDefault();
                }
            }
            else
            {
                return _dbContext.Set<TEntity>().Where(x => x.Id == Id).FirstOrDefault()!;
            }

            throw new Exception("Id is Null");
        }

        public TEntity Update(TEntity entity, bool deletion = false)
        {
            throw new NotImplementedException();
        }
    }
}
