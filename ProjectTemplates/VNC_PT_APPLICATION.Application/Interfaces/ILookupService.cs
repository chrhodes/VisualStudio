using System.Data.Entity;

namespace VNC_PT_APPLICATION.Application.Interfaces
{
    public interface ILookupService<TEntity> where TEntity : class
    {
        IDbSet<TEntity> Items { get; set; }

        void Save();
    }
}
