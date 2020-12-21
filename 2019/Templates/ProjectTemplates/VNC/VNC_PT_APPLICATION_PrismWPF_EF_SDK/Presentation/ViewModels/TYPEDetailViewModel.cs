using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using Prism.Commands;
using Prism.Events;

using $customAPPLICATION$.Domain;
using $customAPPLICATION$.DomainServices;
using $customAPPLICATION$.Presentation.ModelWrappers;

using VNC;
using VNC.Core.DomainServices;
using VNC.Core.Events;
using VNC.Core.Mvvm;
using VNC.Core.Services;

namespace $customAPPLICATION$.Presentation.ViewModels
{
    public class $customTYPE$DetailViewModel : DetailViewModelBase, I$customTYPE$DetailViewModel, IInstanceCountVM
    {
        #region Contructors, Initialization, and Load

        public $customTYPE$DetailViewModel(
                I$customTYPE$DataService $customTYPE$DataService,
                I$xxxITEMxxx$LookupDataService $xxxITEMxxx$LookupDataService,
                IEventAggregator eventAggregator,
                IMessageDialogService messageDialogService) : base(eventAggregator, messageDialogService)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            InstanceCountVM++;

            _$customTYPE$DataService = $customTYPE$DataService;
            _$xxxITEMxxx$LookupDataService = $xxxITEMxxx$LookupDataService;            
            
            eventAggregator.GetEvent<AfterCollectionSavedEvent>()
                .Subscribe(AfterCollectionSaved);

            AddPhoneNumberCommand = new DelegateCommand(
                OnAddPhoneNumberExecute);

            RemovePhoneNumberCommand = new DelegateCommand(
                OnRemovePhoneNumberExecute, OnRemovePhoneNumberCanExecute);

            $xxxITEMxxx$s = new ObservableCollection<LookupItem>();
            PhoneNumbers = new ObservableCollection<$customTYPE$PhoneNumberWrapper>();            

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Enums

        #endregion

        #region Structures

        #endregion

        #region Fields and Properties

        private I$customTYPE$DataService _$customTYPE$DataService;
        private I$xxxITEMxxx$LookupDataService _$xxxITEMxxx$LookupDataService;
        
        public ICommand AddPhoneNumberCommand { get; }
        public ICommand RemovePhoneNumberCommand { get; }

        private DogPhoneNumberWrapper _selectedPhoneNumber;  

        public ObservableCollection<LookupItem> $xxxITEMxxx$s { get; }
        public ObservableCollection<$customTYPE$PhoneNumberWrapper> PhoneNumbers { get; }
        
        // Maybe call this $customTYPE$w
        // or 
        private $customTYPE$Wrapper _$customTYPE$;

        public $customTYPE$Wrapper $customTYPE$
        {
            get { return _$customTYPE$; }
            private set
            {
                _$customTYPE$ = value;
                OnPropertyChanged();
            }
        }
        
        public $customTYPE$PhoneNumberWrapper SelectedPhoneNumber
        {
            get { return _selectedPhoneNumber; }
            set
            {
                _selectedPhoneNumber = value;
                OnPropertyChanged();
                ((DelegateCommand)RemovePhoneNumberCommand).RaiseCanExecuteChanged();
            }
        }

        #endregion

        #region Event Handlers

        private async void OnOpenDetailView(OpenDetailViewEventArgs args)
        {
            Int64 startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            await LoadAsync(args.Id);

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }
        
        private async void AfterCollectionSaved(AfterCollectionSavedEventArgs args)
        {
            Int64 startTicks = Log.EVENT_HANDLER("($customTYPE$DetailViewModel) Enter", Common.LOG_APPNAME);

            if (args.ViewModelName == nameof($xxxITEMxxx$DetailViewModel))
            {
                await Load$xxxITEMxxx$sLookupAsync();
            }

            Log.EVENT_HANDLER("($customTYPE$DetailViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }        

        #endregion

        #region Public Methods

        public override async Task LoadAsync(int id)
        {
            Int64 startTicks = Log.VIEWMODEL($"($customTYPE$DetailViewModel) Enter Id:({id})", Common.LOG_APPNAME);

            var item = id > 0
                ? await _$customTYPE$DataService.FindByIdAsync(id)
                : CreateNew$customTYPE$();

            Id = item.Id;

            Initialize$customTYPE$(item);

            Initialize$customTYPE$PhoneNumbers(item.PhoneNumbers);

            await LoadFoodsLookupAsync();

            Log.VIEWMODEL("($customTYPE$DetailViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Protected Methods

        protected override bool OnDeleteCanExecute()
        {
            // TODO(crhodes)
            // Why do we need this?
            return true;
        }

        protected override async void OnDeleteExecute()
        {
            Int64 startTicks = Log.VIEWMODEL($"($customTYPE$DetailViewModel) Enter Id:({$customTYPE$.Id})", Common.LOG_APPNAME);

            var result = MessageDialogService.ShowOkCancelDialog(
                "Do you really want to delete the $customTYPE$?", "Question");
                
            if (result == MessageDialogResult.OK)
            {
                _$customTYPE$DataService.Remove($customTYPE$.Model);
                
                await _$customTYPE$DataService.UpdateAsync();
                
                PublishAfterDetailDeletedEvent($customTYPE$.Id);
            }

            Log.VIEWMODEL("($customTYPE$DetailViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }

        protected override bool OnSaveCanExecute()
        {
            // TODO(crhodes)
            // Check if $customTYPE$ is valid or has changes
            // This enables and disables the button

            var result =  $customTYPE$ != null
                && !$customTYPE$.HasErrors
                && HasChanges;

            return result;

            //return true;
        }

        protected override async void OnSaveExecute()
        {
            Int64 startTicks = Log.VIEWMODEL("($customTYPE$DetailViewModel) Enter Id:({$customTYPE$.Id})", Common.LOG_APPNAME);

            await _$customTYPE$DataService.UpdateAsync();

            //await SaveWithOptimisticConcurrencyAsync(_$customTYPE$DataService.UpdateAsync,
            //  () =>
            //  {
            //      HasChanges = _$customTYPE$DataService.HasChanges();
            //      Id = $customTYPE$.Id;
            //      RaiseDetailSavedEvent($customTYPE$.Id, $"{$customTYPE$.FieldString}");
            //  });
            
            HasChanges = false;
            Id = $customTYPE$.Id;
            
            PublishAfterDetailSavedEvent($customTYPE$.Id, $customTYPE$.FieldString);

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);
        }
        
        private void OnAddPhoneNumberExecute()
        {
            Int64 startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_APPNAME);

            var newNumber = new $customTYPE$PhoneNumberWrapper(new $customTYPE$PhoneNumber());
            newNumber.PropertyChanged += $customTYPE$PhoneNumberWrapper_PropertyChanged;
            PhoneNumbers.Add(newNumber);
            $customTYPE$.Model.PhoneNumbers.Add(newNumber.Model);
            newNumber.Number = ""; // Trigger validation :-)

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void OnRemovePhoneNumberExecute()
        {
            Int64 startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_APPNAME);

            SelectedPhoneNumber.PropertyChanged -= $customTYPE$PhoneNumberWrapper_PropertyChanged;
            //_friendRepository.RemovePhoneNumber(SelectedPhoneNumber.Model);
            PhoneNumbers.Remove(SelectedPhoneNumber);
            SelectedPhoneNumber = null;
            HasChanges = _$customTYPE$DataService.HasChanges();
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        private bool OnRemovePhoneNumberCanExecute()
        {
            return SelectedPhoneNumber != null;
        }

        #endregion

        #region Private Methods

        private Domain.$customTYPE$ CreateNew$customTYPE$()
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            var item = new Domain.$customTYPE$();
            item.FieldDate = DateTime.Now;
            item.FieldDate2 = DateTime.Now;
            _$customTYPE$DataService.Add(item);

            // TODO(crhodes)
            // Need to figure out how to handle creating new.
            // This tries to push all the way to the database which complains because
            // Haven't set Required Fields (e.g. FieldString)

            // This was our attempt to use our DataService later - but that creates a context and tries to add item which
            // throws exception

            //_dataService.Insert(item);

            // This is what was in Claudius Code (NB>  Add does not call Save Changes in his code
            //_friendRepository.Add(friend);

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);

            return item;
        }

        private void Initialize$customTYPE$($customTYPE$ item)
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            $customTYPE$ = new $customTYPE$Wrapper(item);

            $customTYPE$.PropertyChanged += (s, e) =>
            {
                if (!HasChanges)
                {
                    HasChanges = _$customTYPE$DataService.HasChanges();
                }

                if (e.PropertyName == nameof($customTYPE$.HasErrors))
                {
                    ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
                }

                if (e.PropertyName == nameof($customTYPE$.FieldString))
                {
                    SetTitle();
                }
            };

            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();

            // Little trick to trigger the validation when creating new entries
            if ($customTYPE$.Id == 0)
            {
                $customTYPE$.FieldString = "";
            }

            SetTitle();

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);
        }
        
        private void Initialize$customTYPE$PhoneNumbers(ICollection<$customTYPE$PhoneNumber> phoneNumbers)
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            foreach (var wrapper in PhoneNumbers)
            {
                wrapper.PropertyChanged -= $customTYPE$PhoneNumberWrapper_PropertyChanged;
            }

            PhoneNumbers.Clear();

            foreach (var phoneNumber in phoneNumbers)
            {
                var wrapper = new DogPhoneNumberWrapper(phoneNumber);
                PhoneNumbers.Add(wrapper);
                wrapper.PropertyChanged += $customTYPE$PhoneNumberWrapper_PropertyChanged;
            }

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void $customTYPE$PhoneNumberWrapper_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Int64 startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            if (!HasChanges)
            {
                HasChanges = _$customTYPE$DataService.HasChanges();
            }
            if (e.PropertyName == nameof($customTYPE$PhoneNumberWrapper.HasErrors))
            {
                ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
            }

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }      

        private async Task Load$xxxITEMxxx$sLookupAsync()
        {
            Int64 startTicks = Log.VIEWMODEL("($customTYPE$DetailViewModel) Enter", Common.LOG_APPNAME);

            $xxxITEMxxx$s.Clear();

            //ProgrammingLanguages.Add(new NullLookupItem());
            Foods.Add(new NullLookupItem { DisplayMember = " - " });

            var lookup = await _$xxxITEMxxx$LookupDataService
                                .Get$xxxITEMxxx$LookupAsync();

            foreach (var lookupItem in lookup)
            {
                $xxxITEMxxx$s.Add(lookupItem);
            }

            Log.VIEWMODEL("($customTYPE$DetailViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }        

        private void SetTitle()
        {
            Title = $"{$customTYPE$.FieldString}";
        }

        #endregion

        #region IInstanceCount

        private static int _instanceCountVM;

        public int InstanceCountVM
        {
            get => _instanceCountVM;
            set => _instanceCountVM = value;
        }

        #endregion
    }
}
