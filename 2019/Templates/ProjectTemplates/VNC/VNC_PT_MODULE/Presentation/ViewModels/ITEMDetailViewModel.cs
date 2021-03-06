﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using Prism.Commands;
using Prism.Events;

using $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.Domain;
using $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.DomainServices;
using $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.Presentation.ModelWrappers;

using VNC;
using VNC.Core.Events;
using VNC.Core.Mvvm;
using VNC.Core.Services;

namespace $xxxAPPLICATIONxxx$$xxxNAMESPACExxx$.Presentation.ViewModels
{
    public class $xxxITEMxxx$DetailViewModel : DetailViewModelBase, I$xxxITEMxxx$DetailViewModel, IInstanceCountVM
    {
        #region Contructors, Initialization, and Load

        public $xxxITEMxxx$DetailViewModel(
            I$xxxITEMxxx$DataService $xxxITEMxxx$DataService,
            IEventAggregator eventAggregator,
            IMessageDialogService messageDialogService) : base(eventAggregator, messageDialogService)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            _$xxxITEMxxx$DataService = $xxxITEMxxx$DataService;

            InitializeViewModel();

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void InitializeViewModel()
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_CATEGORY);

            InstanceCountVM++;

            Title = "$xxxITEMxxx$s";
            $xxxITEMxxx$s = new ObservableCollection<$xxxITEMxxx$Wrapper>();

            AddCommand = new DelegateCommand(AddExecute);
            RemoveCommand = new DelegateCommand(RemoveExecute, RemoveCanExecute);

            Log.VIEWMODEL("Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion

        #region Enums

        #endregion

        #region Structures

        #endregion

        #region Fields and Properties

        private I$xxxITEMxxx$DataService _$xxxITEMxxx$DataService;

        public ICommand AddCommand { get; private set;}

        public ICommand RemoveCommand { get; private set;}

        public ObservableCollection<$xxxITEMxxx$Wrapper> $xxxITEMxxx$s { get; private set;}

        private $xxxITEMxxx$Wrapper _selected$xxxITEMxxx$;

        public $xxxITEMxxx$Wrapper Selected$xxxITEMxxx$
        {
            get { return _selected$xxxITEMxxx$; }
            set
            {
                _selected$xxxITEMxxx$ = value;
                OnPropertyChanged();
                ((DelegateCommand)RemoveCommand).RaiseCanExecuteChanged();
            }
        }

        #endregion

        #region Event Handlers

        // private async void OpenDetailView(OpenDetailViewEventArgs args)
        // {
            // Int64 startTicks = Log.EVENT("($xxxITEMxxx$DetailViewModel) Enter", Common.LOG_CATEGORY);

            // await LoadAsync(args.Id);

            // Log.EVENT("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_CATEGORY, startTicks);
        // }

        #endregion

        #region Public Methods

        public override async Task LoadAsync(int id)
        {
            Int64 startTicks = Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Enter Id:({id})", Common.LOG_CATEGORY);

            Id = id;

            foreach (var wrapper in $xxxITEMxxx$s)
            {
                wrapper.PropertyChanged -= Wrapper_PropertyChanged;
            }

            $xxxITEMxxx$s.Clear();

            var items = await _$xxxITEMxxx$DataService.AllAsync();

            foreach (var model in items)
            {
                var wrapper = new $xxxITEMxxx$Wrapper(model);
                wrapper.PropertyChanged += Wrapper_PropertyChanged;
                $xxxITEMxxx$s.Add(wrapper);
            }

            Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_CATEGORY, startTicks);
        }

        void Wrapper_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (! HasChanges)
            {
                HasChanges = _$xxxITEMxxx$DataService.HasChanges();
            }

            if (e.PropertyName == nameof($xxxITEMxxx$Wrapper.HasErrors))
            {
                ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
            }
        }

        #endregion

        #region Protected Methods

        protected override bool DeleteCanExecute()
        {
            // TODO(crhodes)
            // Why do we need this?
            return true;
        }

        protected override async void DeleteExecute()
        {
            Int64 startTicks = Log.VIEWMODEL($"($xxxITEMxxx$DetailViewModel) Enter Id:({Selected$xxxITEMxxx$.Id})", Common.LOG_CATEGORY);

            Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_CATEGORY, startTicks);
        }

        protected override bool SaveCanExecute()
        {
            return HasChanges && $xxxITEMxxx$s.All(p => !p.HasErrors);
        }

        protected override async void SaveExecute()
        {
            Int64 startTicks = Log.VIEWMODEL($"($xxxITEMxxx$DetailViewModel) Enter Id:({Selected$xxxITEMxxx$.Id})", Common.LOG_CATEGORY);

            try
            {
                await _$xxxITEMxxx$DataService.UpdateAsync();

                HasChanges = _$xxxITEMxxx$DataService.HasChanges();

                PublishAfterCollectionSavedEvent();
            }
            catch (Exception ex)
            {
                // while (ex.InnerException != null)
                // {
                    // ex = ex.InnerException;
                // }

                MessageDialogService.ShowInfoDialog(
                    "Error while saving the $xxxITEMxxx$s, " +
                    "the data will be reloaded.  Details: " + ex);
                await LoadAsync(Id);
            }

            Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_CATEGORY, startTicks);
        }

        #endregion

        #region Private Methods

        void AddExecute()
        {
            Int64 startTicks = Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Enter", Common.LOG_CATEGORY);

            var wrapper = new $xxxITEMxxx$Wrapper(new Domain.$xxxITEMxxx$());
            wrapper.PropertyChanged += Wrapper_PropertyChanged;

            _$xxxITEMxxx$DataService.Add(wrapper.Model);
            $xxxITEMxxx$s.Add(wrapper);

            wrapper.Name = "";  // Trigger the validation

            Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_CATEGORY, startTicks);
        }

        private async void RemoveExecute()
        {
            Int64 startTicks = Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Enter", Common.LOG_CATEGORY);

            var isReferenced =
                await _$xxxITEMxxx$DataService.IsReferencedBy$xxxTYPExxx$Async(Selected$xxxITEMxxx$.Id);

            if (isReferenced)
            {
                MessageDialogService.ShowInfoDialog(
                    $"The $xxxTYPExxx$ ({Selected$xxxITEMxxx$.Name})" +
                    " can't be removed;  It is referenced by at least one $xxxTYPExxx$");
                return;
            }

            Selected$xxxITEMxxx$.PropertyChanged -= Wrapper_PropertyChanged;
            _$xxxITEMxxx$DataService.Remove(Selected$xxxITEMxxx$.Model);
            $xxxITEMxxx$s.Remove(Selected$xxxITEMxxx$);
            Selected$xxxITEMxxx$ = null;
            HasChanges = _$xxxITEMxxx$DataService.HasChanges();

            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();

            Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_CATEGORY, startTicks);
        }

        bool RemoveCanExecute()
        {
            return Selected$xxxITEMxxx$ != null;
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
