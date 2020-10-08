using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Infrastructure1
{
    public class ViewModelBase : IViewModel, IViewModel2, INotifyPropertyChanged
    {
        #region IViewModel

        public IView View { get; set; }

        #endregion IViewModel

        //public ViewModelBase() { }

        //public ViewModelBase(IView view)
        //{
        //    View = view;
        //    View.ViewModel = this;
        //}

        //private bool _isBusy;
        //public bool IsBusy
        //{
        //    get { return _isBusy; }
        //    set
        //    {
        //        _isBusy = value;
        //        OnPropertyChanged("IsBusy");
        //    }
        //}

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        // This is the traditional approach - requires string name to be passed in
        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        // This is the new CompilerServices attribute!

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged

    }
}
