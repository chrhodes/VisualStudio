using System.Data.Entity;

using Common.Domain;

using VNC_PT_APPLICATION.Domain;

namespace VNC_PT_APPLICATION.Application.Interfaces
{
    public interface IDatabaseService
    {
        IDbSet<>  { get; set; }

    void Save();
}
}
