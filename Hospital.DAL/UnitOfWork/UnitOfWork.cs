﻿using System;
using Hospital.DAL.Context;
using Hospital.DAL.Interface;
using Hospital.DAL.Repository;
using System.Threading.Tasks;
using System.Collections;

namespace Hospital.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private Hashtable _repositories;

        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IClientManager _clientManager;

        public UnitOfWork(ApplicationDbContext context/*, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager*/)
        {
            _context = context;
            //_userManager = userManager;
            //_roleManager = roleManager;
            //_clientManager = new ClientManager(_context);
        }

        public IClientManager ClientManager => _clientManager;

        public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);

                var repositoryInstance =
                    Activator.CreateInstance(repositoryType
                        .MakeGenericType(typeof(T)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<T>)_repositories[type];
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                    //_userManager.Dispose();
                }
                this.disposed = true;
            }
        }
    }
}
