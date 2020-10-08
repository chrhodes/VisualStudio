using System.Threading.Tasks;

using VNC.Core.Mvvm;

namespace VNC_PT_APPLICATION.Presentation.TYPE.ViewModels
{
    public interface ITYPEDetailViewModel : IViewModel
    {
        Task LoadAsync(int id);
    }
}
