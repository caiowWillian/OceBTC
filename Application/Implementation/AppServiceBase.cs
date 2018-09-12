using Application.Interface;
using Domain.Interfaces.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Implementation
{
    public class AppServiceBase<T> : IAppServiceBase<T>
        where T : class
    {
        private readonly IServiceBase<T> _serviceBase;
        
        public AppServiceBase(IServiceBase<T> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public int Delete(int id)
        {
            return _serviceBase.Delete(id);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _serviceBase.DeleteAsync(id);
        }

        public IList<T> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public IList<T> GetAllAsNoTracking()
        {
            return _serviceBase.GetAllAsNoTracking();
        }

        public async Task<IList<T>> GetAllAsNoTrackingAsync()
        {
            return await _serviceBase.GetAllAsNoTrackingAsync();
        }

        public async Task<IList<T>> GetAllAsync()
        {
            return await _serviceBase.GetAllAsync();
        }

        public T GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _serviceBase.GetByIdAsync(id);
        }

        public int Insert(T obj)
        {
            return _serviceBase.Insert(obj);
        }

        public async Task<int> InsertAsync(T obj)
        {
            return await _serviceBase.InsertAsync(obj);
        }

        public int Update(T obj)
        {
            return _serviceBase.Update(obj);
        }

        public async Task<int> UpdateAsync(T obj)
        {
            return await _serviceBase.UpdateAsync(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
