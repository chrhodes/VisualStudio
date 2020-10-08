using System.Collections.ObjectModel;
using System.Threading.Tasks;

using VNC_PT_APPLICATION.Core.Events;
using VNC_PT_APPLICATION.DomainServices;

using Prism.Events;

using VNC.Core.Domain;
using VNC.Core.Mvvm;

namespace VNC_PT_APPLICATION.Presentation.TYPE.ViewModels
{
    public class TYPEViewModel : ViewModelBase, ITYPEViewModel, IViewModel
    {
        private ITYPELookupDataService _dataService;
        private IEventAggregator _eventAggregator;

        public TYPEViewModel(
                ITYPELookupDataService TYPELookupDataService,
                IEventAggregator eventAggregator)
        {
            _dataService = TYPELookupDataService;
            _eventAggregator = eventAggregator;
            TYPEs = new ObservableCollection<NavigationItemViewModel>();
        }

        public async Task LoadAsync()
        {
            var lookup = await _dataService.GetTYPELookupAsync();
            TYPEs.Clear();

            foreach (var item in lookup)
            {
                TYPEs.Add(new NavigationItemViewModel(item.Id, item.DisplayMember));
            }
        }

        public ObservableCollection<NavigationItemViewModel> TYPEs { get; }

        public IView View
        {
            get;
            set;
        }

        NavigationItemViewModel _selectedTYPE;

        public NavigationItemViewModel SelectedTYPE
        {
            get { return _selectedTYPE; }
            set
            {
                _selectedTYPE = value;
                OnPropertyChanged();

                if (_selectedTYPE != null)
                {
                    _eventAggregator.GetEvent<OpenTYPEDetailViewEvent>()
                        .Publish(_selectedTYPE.Id);
                }
            }
        }
    }
}
