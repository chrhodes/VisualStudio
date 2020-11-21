using System.Collections.ObjectModel;
using System.Threading.Tasks;

using APPLICATION.Core.Events;
using APPLICATION.DomainServices;
using APPLICATION.Presentation.ViewModels;

using Prism.Events;

using VNC.Core.DomainServices;
using VNC.Core.Mvvm;

namespace APPLICATION.Presentation.TYPE.ViewModels
{
    public class TYPEViewModel : ViewModelBase, ITYPEViewModel
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
