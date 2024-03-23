using ConsoleApp_datalagring.Data;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_datalagring.Repositories
{
    internal class Repo<TEntity> where TEntity : class
    {
        private readonly DataContext _context;
        public Repo(DataContext context)
        {
            _context = context;
        }




        //create
        public TEntity Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        //get
        public IEnumerable <TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
            
        }
        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            var entiy = _context.Set<TEntity>().FirstOrDefault(expression);
            return entiy!;
        }

        //update
        public TEntity Update(Expression<Func<TEntity, bool>> expression, TEntity entity)
        {
            var entityToUpdate = _context.Set<TEntity>().FirstOrDefault(expression);
            _context.Entry(entityToUpdate!).CurrentValues.SetValues(entity);
            _context.SaveChanges();

            return entityToUpdate!;
        }
        //delete
        public void Delete(Expression<Func<TEntity, bool>> expression)
        {
            var entiy = _context.Set<TEntity>().FirstOrDefault(expression);
            _context.Remove(entiy!);
            _context.SaveChanges(); 
        }
    }
    
}
