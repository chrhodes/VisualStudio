using System.Threading.Tasks;

using APPLICATION.Core.Events;
using APPLICATION.DomainServices;
using Prism.Events;

using VNC.Core.Mvvm;
using System;
using System.Windows.Input;
using Prism.Commands;

namespace APPLICATION.Presentation.ViewModels
{
    class TYPEDetailViewModel : ViewModelBase, ITYPEDetailViewModel
    {
        private ITYPEDataService _dataService;
        private IEventAggregator _eventAggregator;

        public TYPEDetailViewModel(
                ITYPEDataService dataService,
                IEventAggregator eventAggregator)
        {
            _dataService = dataService;
            _eventAggregator = eventAggregator;
       
            _eventAggregator.GetEvent<OpenTYPEDetailViewEvent>()
                .Subscribe(OnOpenTYPEDetailView);

            SaveCommand = new DelegateCommand(
                OnSaveExecute, OnSaveCanExecute);
        }

        private void OnOpenTYPEDetailView(AfterTYPESavedEventArgs obj)
        {
            throw new NotImplementedException();
        }

        private async void OnOpenTYPEDetailView(int typeId)
        {
            await LoadAsync(typeId);
        }

        public async Task LoadAsync(int id)
        {
            Type = await _dataService.FindByIdAsync(id);
        }

        private APPLICATION.Domain.TYPE _type;

        public APPLICATION.Domain.TYPE Type
        {
            get { return _type; }
            private set
            {
                _type = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }

        async void OnSaveExecute()
        {
            await _dataService.UpdateAsync(Type);

            // Tell the Customer that we have updated something
            _eventAggregator.GetEvent<AfterTYPESavedEvent>()
                .Publish(new AfterTYPESavedEventArgs
                {
                    Id = Type.Id,
                    DisplayMember = Type.FieldString
                    //DisplayMember = $"{Type.FieldString} {Customer.LastName}"
                });

        }

        bool OnSaveCanExecute()
        {
            // TODO(crhodes)
            // Check if Customer is valid
            return true;
        }
    }
}
