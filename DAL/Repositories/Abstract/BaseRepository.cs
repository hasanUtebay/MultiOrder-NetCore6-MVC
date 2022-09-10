using DAL.Context;
using DAL.Repositories.Interfaces.Abstract;
using EntityLayer.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstract
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        protected readonly ProjectContext _context; 
        protected readonly DbSet<T> _table; 
        public BaseRepository(ProjectContext context)
        {
            _context = context;
            _table = context.Set<T>();

        }
        // Create
        public void Create(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        // Delete
        public void Delete(T entity)
        {
            entity.Statu = false;
            entity.RemovedDate = DateTime.Now;
            _context.SaveChanges();

        }

        // Return One 
        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).FirstOrDefault();
        }

        // Return Many
        public List<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        // Update
        public void Update(T entity)
        {            
            entity.ModifiedDate = DateTime.Now;

            //_context.Entry<T>(entity).State = EntityState.Modified;
            _table.Update(entity);
            _context.SaveChanges();
        }
    }
}
