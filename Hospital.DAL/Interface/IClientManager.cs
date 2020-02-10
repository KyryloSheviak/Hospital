using Hospital.DAL.Entities;
using System;

namespace Hospital.DAL.Interface
{
    public interface IClientManager : IDisposable
    {
        void Create(Doctor item);
    }
}
