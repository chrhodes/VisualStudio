using System.Threading.Tasks;

using VNC.Core.Mvvm;

namespace $customAPPLICATION$.Presentation.ViewModels
{
    public interface ICombinedMainViewModel : IViewModel
    {
        Task LoadAsync();
    }
}
