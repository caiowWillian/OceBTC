using Data.Context;
using Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class RepositoryBase<T>
        : IRepositoryBase<T>
        where T : class 
        
    {
        protected OceannicContext _ctx = new OceannicContext();
        private const string FieldDeletado = "Ativo";
        private const string FieldDataAtualizado = "UpdateDate";

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            return GetAllAsync().Result;
        }

        public IList<T> GetAllAsNoTracking()
        {
            return GetAllAsNoTrackingAsync().Result;
        }

        public async Task<IList<T>> GetAllAsNoTrackingAsync()
        {
            return await _ctx.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<IList<T>> GetAllAsync()
        {
            var list =  await _ctx.Set<T>().ToListAsync();

            try
            {
                return list;
                //return list.Where(x => (bool)(x.GetType().GetProperty(FieldDeletado).GetValue(x))).ToList();
            }
            catch (NullReferenceException)
            {
                return list;
            }
        }

        public T GetById(int id)
        {
            return GetByIdAsync(id).Result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _ctx.Set<T>().FindAsync(id);
        }

        public int Insert(T obj)
        {
            return InsertAsync(obj).Result;
        }

        public async Task<int> InsertAsync(T obj)
        {
            _ctx.Set<T>().Add(obj);
            return await _ctx.SaveChangesAsync();
        }

        public int Update(T obj)
        {
            return UpdateAsync(obj).Result;
        }

        public async Task<int> UpdateAsync(T obj)
        {
            try
            {
                obj.GetType()
                .GetProperty(FieldDataAtualizado)
                .SetValue(obj, DateTime.Now);
            }
            catch (NullReferenceException) { }

            _ctx.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return await _ctx.SaveChangesAsync();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}