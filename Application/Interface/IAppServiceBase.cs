﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IAppServiceBase<T> : IDisposable
        where T : class
    {
        IList<T> GetAll();
        Task<IList<T>> GetAllAsync();

        IList<T> GetAllAsNoTracking();
        Task<IList<T>> GetAllAsNoTrackingAsync();

        T GetById(int id);
        Task<T> GetByIdAsync(int id);

        int Insert(T obj);
        Task<int> InsertAsync(T obj);

        int Update(T obj);
        Task<int> UpdateAsync(T obj);

        int Delete(int id);
        Task<int> DeleteAsync(int id);
    }
}
