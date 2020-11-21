using System.Threading.Tasks;

using VNC.Core.Mvvm;

namespace APPLICATION.Presentation.ViewModels
{
    public interface ITYPEViewModel : IViewModel
    {
        Task LoadAsync();
    }
}
