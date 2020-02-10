using System;
using System.Threading.Tasks;

namespace Hospital.DAL.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IClientManager ClientManager { get; }
        IRepository<T> Repository<T>() where T : class;
        Task SaveAsync();
    }
}