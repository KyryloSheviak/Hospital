using System;

namespace Hospital.DAL.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IClientManager ClientManager { get; }
        IRepository<T> Repository<T>() where T : class;
        void Save();
    }
}