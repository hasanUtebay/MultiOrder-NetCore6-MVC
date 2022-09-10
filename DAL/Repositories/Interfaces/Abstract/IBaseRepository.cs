using EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        // Create
        void Create(T entity);

        // Update
        void Update(T entity);

        // Delete
        void Delete(T entity);

        // Select One
        T GetDefault(Expression<Func<T, bool>> expression);

        // Select Many
        List<T> GetDefaults(Expression<Func<T, bool>> expression);
    }
}
