using CandyStore.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace CandyStore.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        private bool disposed = false;

        public UnitOfWork(DbContext context) => _context = context;

        public void BeginTransaction() => _context.Database.BeginTransaction();
        public void Commit() => _context.Database.CommitTransaction();
        public void Rollback() => _context.Database.RollbackTransaction();
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing) _context.Dispose();

            this.disposed = true;

            _context.Database.CurrentTransaction?.Rollback();
        }

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
