using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public int Delete(int id)
        {
            return _repository.Delete(id);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IList<T> GetAllAsNoTracking()
        {
            return _repository.GetAllAsNoTracking();
        }

        public async Task<IList<T>> GetAllAsNoTrackingAsync()
        {
            return await _repository.GetAllAsNoTrackingAsync();
        }

        public async Task<IList<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public int Insert(T obj)
        {
            return _repository.Insert(obj);
        }

        public async Task<int> InsertAsync(T obj)
        {
            return await _repository.InsertAsync(obj);
        }

        public int Update(T obj)
        {
            return _repository.Update(obj);
        }

        public async Task<int> UpdateAsync(T obj)
        {
            return await _repository.UpdateAsync(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
