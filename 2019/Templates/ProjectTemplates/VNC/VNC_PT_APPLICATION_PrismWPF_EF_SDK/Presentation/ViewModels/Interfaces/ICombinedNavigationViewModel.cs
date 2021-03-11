using System.Threading.Tasks;

using VNC.Core.Mvvm;

namespace $xxxAPPLICATIONxxx$.Presentation.ViewModels
{
    public interface ICombinedNavigationViewModel : IViewModel
    {
        Task LoadAsync();
    }
}
